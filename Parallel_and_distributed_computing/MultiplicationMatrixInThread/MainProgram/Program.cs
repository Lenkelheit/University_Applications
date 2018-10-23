using System;
using MultiplicationMatrixInThread;

namespace MainProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Input number of rows and columns for firstMatrix:");
                uint firstRowsAndColumns = 2;
                Matrix firstMatrix = new Matrix(firstRowsAndColumns);
                firstMatrix.RandomFill();
                firstMatrix.Show();
                Console.WriteLine();

                //Console.WriteLine("Input number of rows and columns for secondMatrix:");
                uint secondRowsAndColumns = 2;
                Matrix secondMatrix = new Matrix(secondRowsAndColumns);
                secondMatrix.RandomFill();
                secondMatrix.Show();
                Console.WriteLine();

                //Console.WriteLine("Product of matrix without threads: ");
                Matrix productMatrix = firstMatrix * secondMatrix;
                productMatrix.Show();
                Console.WriteLine();

                //Console.WriteLine("Input number of threads for calculating product of matrix:");
                uint numberOfThreads = 10;
                Matrix productMatrixInThread = Configuration.SplitIntoThreadsAndStartCannonAlgorithm(firstMatrix, secondMatrix, numberOfThreads);
                productMatrixInThread.Show();
                if (productMatrix == productMatrixInThread)
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    Console.WriteLine("Bad");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
