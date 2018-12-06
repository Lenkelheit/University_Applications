using DijkstrasAlgorithmInThreads;

namespace TestDijkstrasAlgorithmInThreads
{
    class ConfigTest
    {
        // METHODS
        public static void RunWithoutThread(int rowsAndColumns)
        {
            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            int source = 0;
            DijkstrasAlgorithm.Run(graph, source);
            int[] distance = DijkstrasAlgorithm.Distance;
        }
        public static void RunWithThread(int rowsAndColumns, int numOfThreads)
        {
            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            int source = 0;
            int[] distance = Configuration.SplitIntoThreadsAndStartDijkstrasAlgorithm(graph, source, numOfThreads);
        }
    }
}
