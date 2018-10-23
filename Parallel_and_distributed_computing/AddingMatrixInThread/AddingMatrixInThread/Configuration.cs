using System;
using System.Threading;

namespace AddingMatrixInThread
{
    public class Configuration
    {
        public static Matrix SplitIntoThreadsAndStart(Matrix first, Matrix second, uint numberOfThreads)
        {
            if (first.Rows == second.Rows && first.Columns == second.Columns)
            {
                SumMatrix sumMatrix = new SumMatrix(first, second, numberOfThreads);
                Thread[] arrOfThreads = new Thread[numberOfThreads];
                for (uint i = 0; i < numberOfThreads; i++)
                {
                    arrOfThreads[i] = new Thread(sumMatrix.Run);
                    arrOfThreads[i].Start(i);
                }
                for (uint i = 0; i < numberOfThreads; i++)
                {
                    arrOfThreads[i].Join();
                }
                return sumMatrix.GetSumMatrix();
            }
            throw new ArgumentException("Different quantity of rows and columns is in matrix!");
        }
    }
}
