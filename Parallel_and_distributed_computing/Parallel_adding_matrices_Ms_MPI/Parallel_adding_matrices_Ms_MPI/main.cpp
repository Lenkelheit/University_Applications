#include <iostream>
#include <ctime>
#include <thread>
#include <mpi.h>

using namespace std;

const int N = 5000;
int first_matr[N][N], second_matr[N][N], result_matr_mpi[N][N];

void simple_sum_matrix(int first_matrix[N][N], int second_matrix[N][N], int sum_matrix_result[N][N],
	size_t index_column = 0, size_t threads_step = 1)
{
	for (size_t i = 0; i < N; ++i)
	{
		for (size_t j = index_column; j < N; j += threads_step)
		{
			sum_matrix_result[i][j] = first_matrix[i][j] + second_matrix[i][j];
		}
	}
}

void parallel_sum_matrix(int first_matrix[N][N], int second_matrix[N][N], int sum_matrix_result[N][N], size_t threads_amount = 1)
{
	thread* thread_arr = new thread[threads_amount];
	for (size_t i = 0; i < threads_amount; ++i)
	{
		thread_arr[i] = thread(simple_sum_matrix, first_matrix, second_matrix, sum_matrix_result, i, threads_amount);
	}
	for (size_t i = 0; i < threads_amount; ++i)
	{
		thread_arr[i].join();
	}
	delete[] thread_arr;
}

void fill_matrices(int first_matr[N][N], int second_matr[N][N])
{
	srand(time(NULL));
	for (int i = 0; i < N; ++i)
	{
		for (int j = 0; j < N; ++j)
		{
			first_matr[i][j] = rand() % 100;
			second_matr[i][j] = rand() % 100;
		}
	}
}

void show_matrix(int matrix[N][N])
{
	for (size_t i = 0; i < N; ++i)
	{
		for (size_t j = 0; j < N; ++j)
		{
			cout << matrix[i][j] << "\t";
		}
		cout << endl;
	}
	cout << endl;
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
		// It will do the process with id = 0.

		fill_matrices(first_matr, second_matr);

		//show_matrix(first_matr);
		//show_matrix(second_matr);

		double start_time = MPI_Wtime();
		simple_sum_matrix(first_matr, second_matr, result_matr_mpi);
		cout << "Simple sum matrices time: " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi);

		int threads_amount;
		cout << "Input threads amount: ";
		cin >> threads_amount;

		start_time = MPI_Wtime();
		parallel_sum_matrix(first_matr, second_matr, result_matr_mpi, threads_amount);
		cout << "Parallel sum matrices time: " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi);

		start_time = MPI_Wtime();
		// N - rows amount.
		int rows_amount_in_process = N / processes_amount;
		int remainder_rows_amount = N % processes_amount;

		for (int process = 1; process < processes_amount; ++process)
		{
			// There process with id = 0 sends to all other processes
			// information about what matrices rows they must to process.
			// N - columns amount.
			MPI_Isend(&N, 1, MPI_INT, process, tag_columns_amount, MPI_COMM_WORLD, &requests[0]);

			MPI_Isend(&rows_amount_in_process, 1, MPI_INT, process, tag_rows_amount_in_process,
				MPI_COMM_WORLD, &requests[1]);

			MPI_Isend(&first_matr[(rows_amount_in_process*process) + remainder_rows_amount][0],
				rows_amount_in_process*N, MPI_INT, process, tag_first_matr, MPI_COMM_WORLD, &requests[2]);

			MPI_Isend(&second_matr[(rows_amount_in_process*process) + remainder_rows_amount][0],
				rows_amount_in_process*N, MPI_INT, process, tag_second_matr, MPI_COMM_WORLD, &requests[3]);
		}


		// Adding parts of matrices in process with id = 0.
		for (int i = 0; i < rows_amount_in_process + remainder_rows_amount; ++i)
		{
			for (int j = 0; j < N; ++j)
			{
				result_matr_mpi[i][j] = first_matr[i][j] + second_matr[i][j];
			}
		}


		for (int i = 1; i < processes_amount; ++i)
		{
			// Process with id = 0 receives from all other processes
			// calculated parts of matrices.
			MPI_Irecv(&result_matr_mpi[(rows_amount_in_process*i) + remainder_rows_amount][0],
				rows_amount_in_process*N, MPI_INT, i, tag_result_matr, MPI_COMM_WORLD, &requests[4]);
			// Waits when request for receiving will finish.
			MPI_Wait(&requests[4], &status);
		}

		cout << "MPI sum matrices time: " << MPI_Wtime() - start_time << endl;

		//show_matrix(result_matr_mpi);
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

		// All processes except one with id = 0 receive from process with id = 0 
		// parts of matrices for processing.
		MPI_Irecv(&first_matr[0][0], rows_amount_in_process*columns_amount, MPI_INT, 0, tag_first_matr, MPI_COMM_WORLD, &requests[7]);
		MPI_Irecv(&second_matr[0][0], rows_amount_in_process*columns_amount, MPI_INT, 0, tag_second_matr, MPI_COMM_WORLD, &requests[8]);

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
		MPI_Isend(&result_matr_mpi[0][0], rows_amount_in_process*columns_amount, MPI_INT, 0, tag_result_matr, MPI_COMM_WORLD, &requests[9]);

		// Waits when request for sending will finish.
		MPI_Wait(&requests[9], &status);
	}

	MPI_Finalize();

	system("pause");
}