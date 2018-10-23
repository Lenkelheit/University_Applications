namespace AddingMatrixInThread
{
    public class SumMatrix
    {
        private Matrix first;
        private Matrix second;
        private Matrix sum;
        private uint numberOfThreads;
        public SumMatrix(Matrix n, Matrix m, uint numOfThreads)
        {
            first = n;
            second = m;
            sum = new Matrix(first.Rows, first.Columns);
            numberOfThreads = numOfThreads;
        }
        public Matrix GetSumMatrix()
        {
            return sum;
        }
        public void Run(object indexOfBeginning)
        {
            for (uint i = (uint)indexOfBeginning; i < first.Rows; i += numberOfThreads)
            {
                for (uint j = 0; j < first.Columns; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }
        }
    }
}
