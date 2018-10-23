using AddingMatrixInThread;

namespace TestOfAddingMatrixInThread
{
    class ConfigTest
    {
        public static void RunWithoutThread(uint rows, uint columns)
        {
            Matrix firstMatrix = new Matrix(rows, columns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rows, columns);
            secondMatrix.RandomFill();

            Matrix sumMatrix = firstMatrix + secondMatrix;
        }
        public static void RunWithThread(uint rows, uint columns, uint numOfThreads)
        {
            Matrix firstMatrix = new Matrix(rows, columns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rows, columns);
            secondMatrix.RandomFill();

            uint numberOfThreads = numOfThreads;
            Matrix sumMatrixInThread = Configuration.SplitIntoThreadsAndStart(firstMatrix, secondMatrix, numberOfThreads);
        }
    }
}
