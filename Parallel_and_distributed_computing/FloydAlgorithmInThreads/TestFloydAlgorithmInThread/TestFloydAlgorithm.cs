using Microsoft.VisualStudio.TestTools.UnitTesting;
using FloydAlgorithmInThreads;

namespace TestFloydAlgorithmInThread
{
    [TestClass]
    public class TestFloydAlgorithm
    {
        [TestMethod]
        public void TestFloydAlgorithmWithoutThreads200()
        {
            int rowsAndColumns = 200;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads200NumThreads4()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads200NumThreads10()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads200NumThreads100()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithoutThreads500()
        {
            int rowsAndColumns = 500;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads500NumThreads4()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads500NumThreads10()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads500NumThreads100()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithoutThreads700()
        {
            int rowsAndColumns = 700;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads700NumThreads4()
        {
            int rowsAndColumns = 700;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads700NumThreads10()
        {
            int rowsAndColumns = 700;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestFloydAlgorithmWithThreads700NumThreads100()
        {
            int rowsAndColumns = 700;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestComparisonOfFloydAlgorithm()
        {
            int rowsAndColumns = 100;
            int numberOfThreads = 4;

            Matrix weightMatrix = new Matrix(rowsAndColumns);
            weightMatrix.RandomFill();

            Matrix distanceMatrix = FloydAlgorithm.FindAllTheShortestPaths(weightMatrix);

            Matrix distanceMatrixInThreads = Configuration.SplitIntoThreadsAndStartFloydAlgorithm(weightMatrix, numberOfThreads);

            for (int i = 0; i < distanceMatrix.Length; ++i)
            {
                for (int j = 0; j < distanceMatrix.Length; ++j)
                {
                    Assert.AreEqual(distanceMatrix[i, j], distanceMatrixInThreads[i, j]);
                }
            }
        }
    }
}
