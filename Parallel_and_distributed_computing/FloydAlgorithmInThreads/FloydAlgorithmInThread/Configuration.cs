using System;
using System.Threading;

namespace FloydAlgorithmInThreads
{
    public class Configuration
    {
        public static Matrix SplitIntoThreadsAndStartFloydAlgorithm(Matrix weightMatrix, int numberOfThreads)
        {
            if (weightMatrix != null)
            {
                FloydAlgorithmInThread result = new FloydAlgorithmInThread(weightMatrix, numberOfThreads);
                result.GenerateNextElemMatrix();
                Thread[] arrOfThreads = new Thread[numberOfThreads];
                for (int i = 0; i < weightMatrix.Length; ++i)
                {
                    result.K = i;
                    for (int j = 0; j < numberOfThreads; ++j)
                    {
                        arrOfThreads[j] = new Thread(result.Run);
                        arrOfThreads[j].Start(j);
                    }
                    for (int j = 0; j < numberOfThreads; ++j)
                    {
                        arrOfThreads[j].Join();
                    }
                }
                return result.distanceMatrix;
            }
            throw new ArgumentNullException("Matrix is null.");
        }
    }
}
