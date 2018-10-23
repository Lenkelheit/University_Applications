using System;
using System.Threading;

namespace SolvingSystemOfLAE
{
    public class Configuration
    {
        public static void RunInThreads(ParameterizedThreadStart runFunc, Thread[] arrOfThreads)
        {
            for (int j = 0; j < arrOfThreads.Length; j++)
            {
                arrOfThreads[j] = new Thread(runFunc);
                arrOfThreads[j].Start(j);
            }
        }
        public static void JoinThreads(Thread[] arrOfThreads)
        {
            for (int j = 0; j < arrOfThreads.Length; j++)
            {
                arrOfThreads[j].Join();
            }
        }
        public static Matrix SplitIntoThreadsAndStartSolveSystem(Matrix a, Matrix b, int numberOfThreads)
        {
            if (a.Rows == a.Columns && a.Rows == b.Rows && b.Columns == 1)
            {
                ResultOfSystem result = new ResultOfSystem(a, b, numberOfThreads);
                Thread[] arrOfThreads = new Thread[numberOfThreads];
                // алгоритм прямого ходу
                for (int i = 0; i < a.Columns; i++)
                {
                    result.IndexOfDiagonalElem = i;
                    result.AdditionalElem = i;

                    RunInThreads(result.RunDivisionOfTheFirstLine, arrOfThreads);
                    JoinThreads(arrOfThreads);

                    RunInThreads(result.RunForwardAlgorithm, arrOfThreads);
                    JoinThreads(arrOfThreads);
                }
                // алгоритм зворотного ходу
                for (int i = a.Columns - 1; i > 0; i--)
                {
                    result.IndexOfDiagonalElem = i;
                    RunInThreads(result.RunReverseAlgorithm, arrOfThreads);
                    JoinThreads(arrOfThreads);
                }

                return result.GetResult();
            }
            throw new ArgumentException("There is wrong quantity of equations, arguments or free members!");
        }
    }
}
