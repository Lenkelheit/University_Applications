using System;
using FloydAlgorithmInThreads;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int rowsAndColumns = 4;
                Matrix weightmatrix = new Matrix(rowsAndColumns);
                weightmatrix.RandomFill();
                //weightmatrix.Show();
                //Console.WriteLine();

                Matrix distanceMatrixWithoutThreads = FloydAlgorithm.FindAllTheShortestPaths(weightmatrix);
                //distanceMatrixWithoutThreads.Show();
                //Console.WriteLine();

                int numberOfThreads = 4;
                Matrix distanceMatrixWithThreads = Configuration.SplitIntoThreadsAndStartFloydAlgorithm(weightmatrix, numberOfThreads);
                //distanceMatrixWithThreads.Show();
                //Console.WriteLine();

                Console.WriteLine(FloydAlgorithm.Path(0, 3, distanceMatrixWithoutThreads));
                Console.WriteLine();
                Console.WriteLine(FloydAlgorithm.Path(0, 3, distanceMatrixWithThreads));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
