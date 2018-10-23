using System;
using AddingMatrixInThread;

namespace MainProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Input number of rows and columns for firstMatrix:");
                uint firstRow = 100;
                uint firstColumn = 100;
                Matrix firstMatrix = new Matrix(firstRow, firstColumn);
                firstMatrix.RandomFill();

                //Console.WriteLine("Input number of rows and columns for secondMatrix:");
                uint secondRow = 100;
                uint secondColumn = 100;
                Matrix secondMatrix = new Matrix(secondRow, secondColumn);
                secondMatrix.RandomFill();

                //Console.WriteLine("Sum of matrix without threads: ");
                Matrix sumMatrix = firstMatrix + secondMatrix;

                //Console.WriteLine("Input number of threads for calculating sum of matrix:");
                uint numberOfThreads = 2;
                Matrix sumMatrixInThread = Configuration.SplitIntoThreadsAndStart(firstMatrix, secondMatrix, numberOfThreads);
                if (sumMatrix == sumMatrixInThread)
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
