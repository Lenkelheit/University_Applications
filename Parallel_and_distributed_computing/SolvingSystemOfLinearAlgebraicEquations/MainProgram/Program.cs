using System;
using SolvingSystemOfLAE;

namespace SolvingSystemOfLinearAlgebraicEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("A:");
                int aRowsAndColumns = 4;
                Matrix a = new Matrix(aRowsAndColumns, aRowsAndColumns);
                a.RandomFill();
                a.Show();
                Console.WriteLine();

                Console.WriteLine("B:");
                int bRowsAndColumns = 4;
                Matrix b = new Matrix(bRowsAndColumns, 1);
                b.RandomFill();
                b.Show();
                Console.WriteLine();

                Console.WriteLine("Solution of system without threads: ");
                Matrix x = SolvingSystemOfEquationsGaussMethod.SolveSystemOfLAE(a, b);
                for (int i = 0; i < x.Rows; i++)
                {
                    for (int j = 0; j < x.Columns; j++)
                    {
                        Console.WriteLine($" x{i}: {x[i, j]}");
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Solution of system with threads: ");
                int numberOfThreads = 2;
                Matrix result = Configuration.SplitIntoThreadsAndStartSolveSystem(a, b, numberOfThreads);
                for (int i = 0; i < result.Rows; i++)
                {
                    for (int j = 0; j < result.Columns; j++)
                    {
                        Console.WriteLine($" x{i}: {result[i, j]}");
                    }
                }
                if (x == result)
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
