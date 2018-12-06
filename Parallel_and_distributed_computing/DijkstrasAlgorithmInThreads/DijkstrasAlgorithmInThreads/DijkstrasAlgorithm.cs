using System;

namespace DijkstrasAlgorithmInThreads
{
    public class DijkstrasAlgorithm
    {
        // FIELDS
        public static int[] Distance { get; private set; }

        // METHODS
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public static void Print()
        {
            if (Distance != null)
            {
                Console.WriteLine("Vertex    Distance from source");

                for (int i = 0; i < Distance.Length; ++i) 
                {
                    Console.WriteLine($"{i}\t  {Distance[i]}");
                }
            }
        }

        public static void Run(Matrix graph, int source)
        {
            int verticesCount = graph.Length;
            Distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                Distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            Distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(Distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (!shortestPathTreeSet[v] && graph[u, v] != 0 && Distance[u] != int.MaxValue && Distance[u] + graph[u, v] < Distance[v])
                    {
                        Distance[v] = Distance[u] + graph[u, v];
                    }
                }
            }
        }
    }
}
