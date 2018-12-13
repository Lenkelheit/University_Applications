using System;
using System.Linq;
using PrimsAlgorithmInThreads;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix graph = new Matrix(new int[,]
            {
                {0, 11, 2, 0 },
                {11, 0, 6, 6 },
                {2, 6, 0, 7 },
                {0, 6, 7, 0 }
            });

            int source = 0;
            int numberOfThreads = 4;

            PrimsAlgorithm.Run(graph, source);
            PrimsAlgorithm.Print();
            Console.WriteLine($"\nWeight of minimum spanning tree: {PrimsAlgorithm.GetWeightOfMinimumSpanningTree()}");

            foreach (int elem in PrimsAlgorithm.MinEdges)
            {
                Console.Write($"{elem}\t");
            }

            int[] minEdges = Configuration.SplitIntoThreadsAndStartPrimsAlgorithm(graph, source, numberOfThreads);
            Console.WriteLine($"\nWeight of minimum spanning tree: {minEdges.Sum()}");
            foreach (int elem in minEdges) 
            {
                Console.Write($"{elem}\t");
            }

            Console.ReadLine();
        }
    }
}
