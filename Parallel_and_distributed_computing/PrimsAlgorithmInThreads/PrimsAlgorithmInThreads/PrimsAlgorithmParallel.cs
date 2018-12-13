using System;

namespace PrimsAlgorithmInThreads
{
    public class PrimsAlgorithmParallel
    {
        // FIELDS
        private Matrix graph;
        private int source;
        private int numberOfThreads;

        // PROPERTIES
        public int[] MinEdges { get; private set; }
        public bool[] Used { get; private set; }

        // CONSTRUCTORS
        public PrimsAlgorithmParallel(Matrix graph, int source, int numberOfThreads)
        {
            this.graph = graph;
            this.source = source;
            this.numberOfThreads = numberOfThreads;

            int verticesCount = graph.Length;
            MinEdges = new int[verticesCount];
            Used = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                MinEdges[i] = int.MaxValue;
            }

            MinEdges[source] = 0;
        }

        // METHODS
        public int FindMinimumEdges()
        {
            int minIndex = -1;

            for (int v = 0; v < Used.Length; ++v)
            {
                if (!Used[v] && (minIndex == -1 || MinEdges[v] < MinEdges[minIndex]))
                {
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
                if (graph[u, i] != 0 && !Used[i] && graph[u, i] < MinEdges[i]) 
                {
                    MinEdges[i] = graph[u, i];
                }
            }
        }
    }
}
