using System;
using DijkstrasAlgorithmInThreads;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix graph = new Matrix(new int[,]
            {
                { 0, 4, 0, 10 },
                { 5, 0, 8, 3 },
                { 7, 8, 0, 7 },
                { 2, 0, 4, 0 }
            });
            int source = 0;
            int numberOfThreads = 4;

            DijkstrasAlgorithm.Run(graph, source);
            DijkstrasAlgorithm.Print();

            int[] distance = Configuration.SplitIntoThreadsAndStartDijkstrasAlgorithm(graph, source, numberOfThreads);

            if (distance != null)
            {
                Console.WriteLine("Vertex    Distance from source");

                for (int i = 0; i < distance.Length; ++i)
                {
                    Console.WriteLine($"{i}\t  {distance[i]}");
                }
            }

            Console.ReadLine();
        }
    }
}
