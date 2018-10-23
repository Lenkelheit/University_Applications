using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddingMatrixInThread;

namespace TestOfAddingMatrixInThread
{
    [TestClass]
    public class TestAddingMatrix
    {
        [TestMethod]
        public void TestMatrixWithoutThreads100()
        {
            uint rows = 100;
            uint columns = 100;
            ConfigTest.RunWithoutThread(rows, columns);
        }
        [TestMethod]
        public void TestMatrixWithThreads100NumThreads2()
        {
            uint rows = 100;
            uint columns = 100;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads100NumThreads10()
        {
            uint rows = 100;
            uint columns = 100;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads100NumThreads100()
        {
            uint rows = 100;
            uint columns = 100;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreads2000()
        {
            uint rows = 2000;
            uint columns = 2000;
            ConfigTest.RunWithoutThread(rows, columns);
        }
        [TestMethod]
        public void TestMatrixWithThreads2000NumThreads2()
        {
            uint rows = 2000;
            uint columns = 2000;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads2000NumThreads10()
        {
            uint rows = 2000;
            uint columns = 2000;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads2000NumThreads100()
        {
            uint rows = 2000;
            uint columns = 2000;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithoutThreads5000()
        {
            uint rows = 5000;
            uint columns = 5000;
            ConfigTest.RunWithoutThread(rows, columns);
        }
        [TestMethod]
        public void TestMatrixWithThreads5000NumThreads2()
        {
            uint rows = 5000;
            uint columns = 5000;
            uint numberOfThreads = 2;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads5000NumThreads10()
        {
            uint rows = 5000;
            uint columns = 5000;
            uint numberOfThreads = 10;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestMatrixWithThreads5000NumThreads100()
        {
            uint rows = 5000;
            uint columns = 5000;
            uint numberOfThreads = 100;
            ConfigTest.RunWithThread(rows, columns, numberOfThreads);
        }
        [TestMethod]
        public void TestComparisonOfAddedMatrix()
        {
            uint rows = 100;
            uint columns = 100;
            uint numberOfThreads = 2;
            Matrix firstMatrix = new Matrix(rows, columns);
            firstMatrix.RandomFill();

            Matrix secondMatrix = new Matrix(rows, columns);
            secondMatrix.RandomFill();

            Matrix sumMatrix = firstMatrix + secondMatrix;

            Matrix sumMatrixInThread = Configuration.SplitIntoThreadsAndStart(firstMatrix, secondMatrix, numberOfThreads);

            for (uint i = 0; i < firstMatrix.Rows; i++)
            {
                for (uint j = 0; j < firstMatrix.Columns; j++)
                {
                    Assert.AreEqual(sumMatrix[i, j], sumMatrixInThread[i, j]);
                }
            }
        }

    }
}
