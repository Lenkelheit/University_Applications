using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimsAlgorithmInThreads;

namespace TestPrimsAlgorithmInThreads
{
    [TestClass]
    public class TestPrimsAlgorithm
    {
        [TestMethod]
        public void TestPrimsAlgorithmWithoutThreads200()
        {
            int rowsAndColumns = 200;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads200NumThreads4()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads200NumThreads10()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads200NumThreads100()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithoutThreads500()
        {
            int rowsAndColumns = 500;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads500NumThreads4()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads500NumThreads10()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads500NumThreads100()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithoutThreads1000()
        {
            int rowsAndColumns = 1000;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads1000NumThreads2()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 2;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads1000NumThreads10()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestPrimsAlgorithmWithThreads1000NumThreads100()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }

        [TestMethod]
        public void TestComparisonOfPrimsAlgorithm()
        {
            int rowsAndColumns = 100;
            int numberOfThreads = 4;
            int source = 0;

            Matrix graph = new Matrix(rowsAndColumns);
            graph.RandomFill();

            PrimsAlgorithm.Run(graph, source);
            int[] minEdgesWithoutThreads = PrimsAlgorithm.MinEdges;

            int[] minEdgesWithThreads = Configuration.SplitIntoThreadsAndStartPrimsAlgorithm(graph, source, numberOfThreads);

            for (int i = 0; i < minEdgesWithoutThreads.Length; ++i)
            {
                Assert.AreEqual(minEdgesWithoutThreads[i], minEdgesWithThreads[i]);
            }
        }
    }
}
