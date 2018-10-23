using SolvingSystemOfLAE;

namespace TestOfSolvingSystemOfLAE
{
    class ConfigTest
    {
        public static void RunWithoutThread(int rowsAndColumns)
        {
            Matrix a = new Matrix(rowsAndColumns, rowsAndColumns);
            a.RandomFill();

            Matrix b = new Matrix(rowsAndColumns, 1);
            b.RandomFill();

            Matrix x = SolvingSystemOfEquationsGaussMethod.SolveSystemOfLAE(a, b);
        }
        public static void RunWithThread(int rowsAndColumns, int numOfThreads)
        {
            Matrix a = new Matrix(rowsAndColumns, rowsAndColumns);
            a.RandomFill();

            Matrix b = new Matrix(rowsAndColumns, 1);
            b.RandomFill();

            Matrix x = Configuration.SplitIntoThreadsAndStartSolveSystem(a, b, numOfThreads);
        }
    }
}
