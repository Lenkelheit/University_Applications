using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationMatrixInThread;

namespace TestOfMultiplicationMatrixInThread
{
    [TestClass]
    public class TestMultiplicationMatrixStringAlgorithm
    {
        [TestMethod]
        public void TestMatrixWithoutThreadsString100()
        {
            uint rowsAndColumns = 100;
            ConfigTest.RunWithoutThreadString(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString100NumThreads2()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString100NumThreads10()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString100NumThreads100()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreadsString200()
        {
            uint rowsAndColumns = 200;
            ConfigTest.RunWithoutThreadString(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString200NumThreads2()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString200NumThreads10()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString200NumThreads100()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreadsString500()
        {
            uint rowsAndColumns = 500;
            ConfigTest.RunWithoutThreadString(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString500NumThreads2()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString500NumThreads10()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsString500NumThreads100()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadString(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestComparisonOfMultipliedMatrixString()
        {
            uint rowsAndColumns = 100;

            uint numberOfThreads = 2;
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrix = Matrix.Multiply(firstMatrix, secondMatrix);

            Matrix productMatrixInThread = Configuration.SplitIntoThreadsAndStartStringAlgorithm(firstMatrix, secondMatrix, numberOfThreads);

            for (uint i = 0; i < firstMatrix.Rows; i++)
            {
                for (uint j = 0; j < firstMatrix.Columns; j++)
                {
                    Assert.AreEqual(productMatrix[i, j], productMatrixInThread[i, j]);
                }
            }
        }
    }
}
