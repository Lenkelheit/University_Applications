using Microsoft.VisualStudio.TestTools.UnitTesting;
using DijkstrasAlgorithmInThreads;

namespace TestDijkstrasAlgorithmInThreads
{
    [TestClass]
    public class TestDijkstrasAlgorithm
    {
        [TestMethod]
        public void TestDijkstrasAlgorithmWithoutThreads200()
        {
            int rowsAndColumns = 200;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads200NumThreads4()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads200NumThreads10()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads200NumThreads100()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithoutThreads500()
        {
            int rowsAndColumns = 500;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads500NumThreads4()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads500NumThreads10()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads500NumThreads100()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithoutThreads1000()
        {
            int rowsAndColumns = 1000;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads1000NumThreads4()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads1000NumThreads10()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestDijkstrasAlgorithmWithThreads1000NumThreads100()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestComparisonOfDijkstrasAlgorithm()
        {
            int rowsAndColumns = 100;
            int numberOfThreads = 4;
            int source = 0;

            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            DijkstrasAlgorithm.Run(graph, source);
            int[] distanceWithoutThreads = DijkstrasAlgorithm.Distance;

            int[] distanceWithThreads = Configuration.SplitIntoThreadsAndStartDijkstrasAlgorithm(graph, source, numberOfThreads);

            for (int i = 0; i < distanceWithoutThreads.Length; ++i)
            {
                Assert.AreEqual(distanceWithoutThreads[i], distanceWithThreads[i]);
            }
        }
    }
}
