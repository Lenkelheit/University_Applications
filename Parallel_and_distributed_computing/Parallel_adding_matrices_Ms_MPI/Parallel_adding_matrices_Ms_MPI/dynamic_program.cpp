#include <iostream>
#include <ctime>
#include <thread>
#include <mpi.h>

using namespace std;

void simple_sum_matrix(int** first_matrix, int** second_matrix, int** sum_matrix_result, int size,
	size_t index_column = 0, size_t threads_step = 1)
{
	for (size_t i = 0; i < size; ++i)
	{
		for (size_t j = index_column; j < size; j += threads_step)
		{
			sum_matrix_result[i][j] = first_matrix[i][j] + second_matrix[i][j];
		}
	}
}

void parallel_sum_matrix(int** first_matrix, int** second_matrix, int** sum_matrix_result, int size, 
	size_t threads_amount = 1)
{
	thread* thread_arr = new thread[threads_amount];
	for (size_t i = 0; i < threads_amount; ++i)
	{
		thread_arr[i] = thread(simple_sum_matrix, first_matrix, second_matrix, sum_matrix_result, size, i, threads_amount);
	}
	for (size_t i = 0; i < threads_amount; ++i)
	{
		thread_arr[i].join();
	}
	delete[] thread_arr;
}

void fill_matrices(int** first_matr, int** second_matr, int size)
{
	srand(time(NULL));
	for (int i = 0; i < size; ++i)
	{
		for (int j = 0; j < size; ++j)
		{
			first_matr[i][j] = rand() % 100;
			second_matr[i][j] = rand() % 100;
		}
	}
}

void show_matrix(int** matrix, int size)
{
	for (size_t i = 0; i < size; ++i)
	{
		for (size_t j = 0; j < size; ++j)
		{
			cout << matrix[i][j] << "\t";
		}
		cout << endl;
	}
	cout << endl;
}

int** allocate_2d_int(int rows, int columns)
{
	int* data = (int*)malloc(rows * columns * sizeof(int));
	int** array = (int**)malloc(rows * sizeof(int*));
	for (int i = 0; i < rows; ++i)
	{
		array[i] = &(data[columns * i]);
	}

	return array;
}


int main(int argc, char * argv[])
{
	// The special message tags.
	int tag_columns_amount = 112, tag_rows_amount_in_process = 111,
		tag_first_matr = 113, tag_second_matr = 114, tag_result_matr = 115;

	int process_id, processes_amount;

	// Requests with status are for checking if some process have received or sent some message.
	MPI_Request requests[10];
	MPI_Status status;

	MPI_Init(&argc, &argv);
	MPI_Comm_size(MPI_COMM_WORLD, &processes_amount);
	MPI_Comm_rank(MPI_COMM_WORLD, &process_id);

	if (process_id == 0)
	{
		int size = 5000;
		int** first_matr = allocate_2d_int(size, size);
		int** second_matr = allocate_2d_int(size, size);
		int** result_matr_mpi = allocate_2d_int(size, size);

		cout << endl << "Matrices dimension: " << size << " x " << size << endl;

		// It will do the process with id = 0.

		fill_matrices(first_matr, second_matr, size);

		//show_matrix(first_matr, size);
		//show_matrix(second_matr, size);

		double start_time = MPI_Wtime();
		simple_sum_matrix(first_matr, second_matr, result_matr_mpi, size);
		cout << "Simple sum matrices time: " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi, size);

		int threads_amount = 2;
		start_time = MPI_Wtime();
		parallel_sum_matrix(first_matr, second_matr, result_matr_mpi, size, threads_amount);
		cout << "Parallel sum matrices time with " << threads_amount << " threads : " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi, size);

		start_time = MPI_Wtime();
		// size - rows amount.
		int rows_amount_in_process = size / processes_amount;
		int remainder_rows_amount = size % processes_amount;

		for (int process = 1; process < processes_amount; ++process)
		{
			// There process with id = 0 sends to all other processes
			// information about what matrices rows they must to process.
			// size - columns amount.
			MPI_Isend(&size, 1, MPI_INT, process, tag_columns_amount, MPI_COMM_WORLD, &requests[0]);

			MPI_Isend(&rows_amount_in_process, 1, MPI_INT, process, tag_rows_amount_in_process,
				MPI_COMM_WORLD, &requests[1]);

			MPI_Isend(&(first_matr[(rows_amount_in_process*process) + remainder_rows_amount][0]),
				rows_amount_in_process*size, MPI_INT, process, tag_first_matr, MPI_COMM_WORLD, &requests[2]);

			MPI_Isend(&(second_matr[(rows_amount_in_process*process) + remainder_rows_amount][0]),
				rows_amount_in_process*size, MPI_INT, process, tag_second_matr, MPI_COMM_WORLD, &requests[3]);
		}


		// Adding parts of matrices in process with id = 0.
		for (int i = 0; i < rows_amount_in_process + remainder_rows_amount; ++i)
		{
			for (int j = 0; j < size; ++j)
			{
				result_matr_mpi[i][j] = first_matr[i][j] + second_matr[i][j];
			}
		}


		for (int i = 1; i < processes_amount; ++i)
		{
			// Process with id = 0 receives from all other processes
			// calculated parts of matrices.
			MPI_Irecv(&(result_matr_mpi[(rows_amount_in_process*i) + remainder_rows_amount][0]),
				rows_amount_in_process*size, MPI_INT, i, tag_result_matr, MPI_COMM_WORLD, &requests[4]);
			// Waits when request for receiving will finish.
			MPI_Wait(&requests[4], &status);
		}

		free(first_matr[0]);
		free(first_matr);

		free(second_matr[0]);
		free(second_matr);

		free(result_matr_mpi[0]);
		free(result_matr_mpi);

		cout << "MPI sum matrices time: " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi, size);

		system("pause");
	}
	else
	{
		int rows_amount_in_process;
		int columns_amount;

		// All processes except one with id = 0 receive 
		// information from process with id = 0 about what matrices rows they must to process.
		MPI_Irecv(&columns_amount, 1, MPI_INT, 0, tag_columns_amount, MPI_COMM_WORLD, &requests[5]);
		MPI_Irecv(&rows_amount_in_process, 1, MPI_INT, 0, tag_rows_amount_in_process, MPI_COMM_WORLD, &requests[6]);

		// Waits when request for receiving will finish.
		MPI_Wait(&requests[5], &status);
		MPI_Wait(&requests[6], &status);


		int** first_matr = allocate_2d_int(rows_amount_in_process, columns_amount);
		int** second_matr = allocate_2d_int(rows_amount_in_process, columns_amount);
		int** result_matr_mpi = allocate_2d_int(rows_amount_in_process, columns_amount);


		// All processes except one with id = 0 receive from process with id = 0 
		// parts of matrices for processing.
		MPI_Irecv(&(first_matr[0][0]), rows_amount_in_process*columns_amount, MPI_INT, 0, 
			tag_first_matr, MPI_COMM_WORLD, &requests[7]);
		MPI_Irecv(&(second_matr[0][0]), rows_amount_in_process*columns_amount, MPI_INT, 0, 
			tag_second_matr, MPI_COMM_WORLD, &requests[8]);

		// Waits when request for receiving will finish.
		MPI_Wait(&requests[7], &status);
		MPI_Wait(&requests[8], &status);

		// Adding parts of matrices in all processes except one with id = 0.
		for (int i = 0; i < rows_amount_in_process; ++i)
		{
			for (int j = 0; j < columns_amount; ++j)
			{
				result_matr_mpi[i][j] = first_matr[i][j] + second_matr[i][j];
			}
		}

		// All processes except one with id = 0 send to process with id = 0
		// parts of matrices that they have processed.
		MPI_Isend(&(result_matr_mpi[0][0]), rows_amount_in_process*columns_amount, MPI_INT, 0, 
			tag_result_matr, MPI_COMM_WORLD, &requests[9]);

		// Waits when request for sending will finish.
		MPI_Wait(&requests[9], &status);

		free(first_matr[0]);
		free(first_matr);

		free(second_matr[0]);
		free(second_matr);

		free(result_matr_mpi[0]);
		free(result_matr_mpi);
	}

	MPI_Finalize();
}