using System;
using System.Threading;

namespace DijkstrasAlgorithmInThreads
{
    public class Configuration
    {
        // METHODS
        public static int[] SplitIntoThreadsAndStartDijkstrasAlgorithm(Matrix graph, int source, int numberOfThreads)
        {
            if (graph != null)
            {
                DijkstrasAlgorithmInThreads result = new DijkstrasAlgorithmInThreads(graph, source, numberOfThreads);
                Thread[] arrOfThreads = new Thread[numberOfThreads];

                for (int i = 0; i < graph.Length - 1; ++i)
                {
                    int u = result.MinimumDistance();
                    result.ShortestPathTreeSet[u] = true;

                    for (int j = 0; j < numberOfThreads; ++j)
                    {
                        arrOfThreads[j] = new Thread(result.Run);
                        arrOfThreads[j].Start(new Tuple<int, int>(j, u));
                    }
                    for (int j = 0; j < numberOfThreads; ++j)
                    {
                        arrOfThreads[j].Join();
                    }
                }
                return result.Distance;
            }
            throw new ArgumentNullException("Matrix is null.");
        }
    }
}
