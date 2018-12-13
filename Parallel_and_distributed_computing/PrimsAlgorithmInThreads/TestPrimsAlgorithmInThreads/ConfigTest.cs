using PrimsAlgorithmInThreads;

namespace TestPrimsAlgorithmInThreads
{
    class ConfigTest
    {
        // METHODS
        public static void RunWithoutThread(int rowsAndColumns)
        {
            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            int source = 0;
            PrimsAlgorithm.Run(graph, source);
            int[] minEdges = PrimsAlgorithm.MinEdges;
        }

        public static void RunWithThread(int rowsAndColumns, int numOfThreads)
        {
            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            int source = 0;
            int[] minEdges = Configuration.SplitIntoThreadsAndStartPrimsAlgorithm(graph, source, numOfThreads);
        }
    }
}
