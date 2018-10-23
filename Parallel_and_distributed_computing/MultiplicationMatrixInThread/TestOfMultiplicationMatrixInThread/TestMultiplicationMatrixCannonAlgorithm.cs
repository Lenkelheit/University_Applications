using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationMatrixInThread;

namespace TestOfMultiplicationMatrixInThread
{
    [TestClass]
    public class TestMultiplicationMatrixCannonAlgorithm
    {
        [TestMethod]
        public void TestMatrixWithoutThreadsCannon100()
        {
            uint rowsAndColumns = 100;
            ConfigTest.RunWithoutThreadCannon(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon100NumThreads2()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon100NumThreads10()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon100NumThreads100()
        {
            uint rowsAndColumns = 100;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreadsCannon200()
        {
            uint rowsAndColumns = 200;
            ConfigTest.RunWithoutThreadCannon(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon200NumThreads2()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon200NumThreads10()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon200NumThreads100()
        {
            uint rowsAndColumns = 200;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreadsCannon500()
        {
            uint rowsAndColumns = 500;
            ConfigTest.RunWithoutThreadCannon(rowsAndColumns);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon500NumThreads2()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon500NumThreads10()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreadsCannon500NumThreads100()
        {
            uint rowsAndColumns = 500;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThreadCannon(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestComparisonOfMultipliedMatrixCannon()
        {
            uint rowsAndColumns = 100;

            uint numberOfThreads = 2;
            Matrix firstMatrix = new Matrix(rowsAndColumns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rowsAndColumns);
            secondMatrix.RandomFill();

            Matrix productMatrix = firstMatrix * secondMatrix;

            Matrix productMatrixInThread = Configuration.SplitIntoThreadsAndStartCannonAlgorithm(firstMatrix, secondMatrix, numberOfThreads);

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
