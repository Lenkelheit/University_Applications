using System;
using System.Linq;

namespace PrimsAlgorithmInThreads
{
    public class PrimsAlgorithm
    {
        // PROPERTIES
        public static int[] MinEdges { get; private set; }
        public static int[] MinimumSpanningTree { get; private set; }

        // METHODS
        private static int FindMinimumEdges(bool[] used)
        {
            int minIndex = -1;

            for (int v = 0; v < used.Length; ++v) 
            {
                if (!used[v] && (minIndex == -1 || MinEdges[v] < MinEdges[minIndex])) 
                {
                    minIndex = v;
                }
            }

            return minIndex;
        }

        public static void Run(Matrix graph, int source)
        {
            int verticesCount = graph.Length;
            MinEdges = new int[verticesCount];
            MinimumSpanningTree = new int[verticesCount];
            bool[] used = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                MinEdges[i] = int.MaxValue;
                MinimumSpanningTree[i] = -1;
            }

            MinEdges[source] = 0;

            for (int count = 0; count < verticesCount; ++count) 
            {
                int u = FindMinimumEdges(used);
                used[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (graph[u, v] != 0 && !used[v] && graph[u, v] < MinEdges[v]) 
                    {
                        MinEdges[v] = graph[u, v];
                        MinimumSpanningTree[v] = u;
                    }
                }
            }
        }

        public static void Print()
        {
            if (MinimumSpanningTree != null)
            {
                Console.WriteLine("Minimum spanning tree");

                for (int i = 0; i < MinimumSpanningTree.Length; ++i)
                {
                    Console.Write($"{MinimumSpanningTree[i]}\t");
                }
            }
        }

        public static int GetWeightOfMinimumSpanningTree()
        {
            return MinEdges.Sum();
        }
    }
}
