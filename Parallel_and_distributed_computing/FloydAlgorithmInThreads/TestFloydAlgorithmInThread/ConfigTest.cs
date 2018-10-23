using FloydAlgorithmInThreads;

namespace TestFloydAlgorithmInThread
{
    class ConfigTest
    {
        public static void RunWithoutThread(int rowsAndColumns)
        {
            Matrix weightMatrix = new Matrix(rowsAndColumns);
            weightMatrix.RandomFill();

            Matrix distanceMatrix = FloydAlgorithm.FindAllTheShortestPaths(weightMatrix);
        }
        public static void RunWithThread(int rowsAndColumns, int numOfThreads)
        {
            Matrix weightMatrix = new Matrix(rowsAndColumns);
            weightMatrix.RandomFill();

            Matrix distanceMatrix = Configuration.SplitIntoThreadsAndStartFloydAlgorithm(weightMatrix, numOfThreads);
        }
    }
}
