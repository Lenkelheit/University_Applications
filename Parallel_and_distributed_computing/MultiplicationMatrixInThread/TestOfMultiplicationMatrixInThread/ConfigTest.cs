using MultiplicationMatrixInThread;

namespace TestOfMultiplicationMatrixInThread
{
    class ConfigTest
    {
        public static void RunWithoutThreadCannon(uint rowsAndColumns)
        {
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrix = firstMatrix * secondMatrix;
        }
        public static void RunWithThreadCannon(uint rowsAndColumns, uint numOfThreads)
        {
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrixInThread = Configuration.SplitIntoThreadsAndStartCannonAlgorithm(firstMatrix, secondMatrix, numOfThreads);
        }
        public static void RunWithoutThreadString(uint rowsAndColumns)
        {
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrix = Matrix.Multiply(firstMatrix, secondMatrix);
        }
        public static void RunWithThreadString(uint rowsAndColumns, uint numOfThreads)
        {
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrixInThread = Configuration.SplitIntoThreadsAndStartStringAlgorithm(firstMatrix, secondMatrix, numOfThreads);
        }

    }
}
