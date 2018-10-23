using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolvingSystemOfLAE;

namespace TestOfSolvingSystemOfLAE
{
    [TestClass]
    public class TestSolutionSystemOfLAE
    {
        [TestMethod]
        public void TestSystemOfEquationsWithoutThreads200()
        {
            int rowsAndColumns = 200;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads200NumThreads4()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads200NumThreads10()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads200NumThreads100()
        {
            int rowsAndColumns = 200;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithoutThreads500()
        {
            int rowsAndColumns = 500;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads500NumThreads4()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads500NumThreads10()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads500NumThreads100()
        {
            int rowsAndColumns = 500;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithoutThreads1000()
        {
            int rowsAndColumns = 1000;
            ConfigTest.RunWithoutThread(rowsAndColumns);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads1000NumThreads4()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 4;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads1000NumThreads10()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 10;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestSystemOfEquationsWithThreads1000NumThreads100()
        {
            int rowsAndColumns = 1000;
            int numberOfThreads = 100;
            ConfigTest.RunWithThread(rowsAndColumns, numberOfThreads);
        }
        [TestMethod]
        public void TestComparisonOfSystemSolutions()
        {
            int rowsAndColumns = 100;

            int numberOfThreads = 4;
            Matrix a = new Matrix(rowsAndColumns, rowsAndColumns);
            a.RandomFill();

            Matrix b = new Matrix(rowsAndColumns, 1);
            b.RandomFill();

            Matrix x = SolvingSystemOfEquationsGaussMethod.SolveSystemOfLAE(a, b);

            Matrix xInThread = Configuration.SplitIntoThreadsAndStartSolveSystem(a, b, numberOfThreads);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < x.Columns; j++)
                {
                    Assert.AreEqual(x[i, j], xInThread[i, j]);
                }
            }
        }
    }
}
