using System;

namespace DijkstrasAlgorithmInThreads
{
    public class DijkstrasAlgorithmInThreads
    {
        // FIELDS
        private Matrix graph;
        private int source;
        private int numberOfThreads;

        // PROPERTIES
        public int[] Distance { get; private set; }
        public bool[] ShortestPathTreeSet { get; private set; }

        // CONSTRUCTORS
        public DijkstrasAlgorithmInThreads(Matrix graph, int source, int numberOfThreads)
        {
            this.graph = graph;
            this.source = source;
            this.numberOfThreads = numberOfThreads;

            int verticesCount = graph.Length;
            Distance = new int[verticesCount];
            ShortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                Distance[i] = int.MaxValue;
                ShortestPathTreeSet[i] = false;
            }

            Distance[source] = 0;
        }

        // METHODS
        public int MinimumDistance()
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < graph.Length; ++v) 
            {
                if (ShortestPathTreeSet[v] == false && Distance[v] <= min)
                {
                    min = Distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public void Run(object indexOfBeginning)
        {
            var indexOfBegin = indexOfBeginning as Tuple<int, int>;

            int v = indexOfBegin.Item1;
            int u = indexOfBegin.Item2;
            for (int i = v; i < graph.Length; i += numberOfThreads)
            {
                if (!ShortestPathTreeSet[i] && graph[u, i] != 0
                    && Distance[u] != int.MaxValue && Distance[u] + graph[u, i] < Distance[i])
                {
                    Distance[i] = Distance[u] + graph[u, i];
                }
            }
        }
    }
}
