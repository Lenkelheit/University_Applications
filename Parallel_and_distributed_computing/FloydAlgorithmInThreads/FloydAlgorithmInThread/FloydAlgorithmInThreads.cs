namespace FloydAlgorithmInThreads
{
    public class FloydAlgorithmInThread
    {
        public Matrix distanceMatrix { get; set; }
        private int numberOfThreads;
        private Matrix nextElemMatrix;
        public int K { get; set; }

        public FloydAlgorithmInThread(Matrix distanceMatrix, int numberOfThreads)
        {
            this.distanceMatrix = distanceMatrix.Clone();
            this.numberOfThreads = numberOfThreads;
            nextElemMatrix = new Matrix(distanceMatrix.Length);
            K = 0;
        }
        public void GenerateNextElemMatrix()
        {
            for (int i = 0; i < nextElemMatrix.Length; ++i)
            {
                for (int j = 0; j < nextElemMatrix.Length; ++j)
                {
                    nextElemMatrix[i, j] = j;
                }
            }
        }
        public void Run(object indexOfBeginning)
        {
            int indexOfBegin = (int)indexOfBeginning;

            for (int i = indexOfBegin; i < distanceMatrix.Length; i += numberOfThreads)
            {
                for (int j = 0; j < distanceMatrix.Length; ++j)
                {
                    if ((distanceMatrix[i, K] + distanceMatrix[K, j]) < distanceMatrix[i, j])
                    {
                        distanceMatrix[i, j] = (distanceMatrix[i, K] + distanceMatrix[K, j]);
                        nextElemMatrix[i, j] = nextElemMatrix[i, K];
                    }
                }
            }
        }
    }
}
