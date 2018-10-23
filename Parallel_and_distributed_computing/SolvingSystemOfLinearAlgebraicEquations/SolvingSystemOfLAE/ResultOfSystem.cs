namespace SolvingSystemOfLAE
{
    public class ResultOfSystem
    {
        private Matrix A;
        private Matrix B;
        private int numberOfThreads;
        private double additionalElem;
        public double AdditionalElem
        {
            set
            {
                additionalElem = A[(int)value, (int)value];
            }
            get
            {
                return additionalElem;
            }
        }
        public int IndexOfDiagonalElem { get; set; }
        public ResultOfSystem(Matrix a, Matrix b, int numOfThreads)
        {
            A = a.Clone();
            B = b.Clone();
            numberOfThreads = numOfThreads;
        }
        public Matrix GetResult()
        {
            return B;
        }
        public void RunDivisionOfTheFirstLine(object indexOfBeginning)
        {
            // відбувається ділення кожного елемента рядка(i) на відповідний елемент на головній діагоналі(i, i)
            int indexOfBegin = (int)indexOfBeginning, i = IndexOfDiagonalElem;
            double aFirstElemInLine = additionalElem;
            for (int j = i + indexOfBegin; j <= A.Columns; j += numberOfThreads) 
            {
                if (j == A.Columns)  
                {
                    B[i, 0] /= aFirstElemInLine;
                    break;
                }
                A[i, j] /= aFirstElemInLine;
            }
        }
        public void RunForwardAlgorithm(object indexOfBeginning)
        {
            int indexOfBegin = (int)indexOfBeginning, i = IndexOfDiagonalElem;
            double aFirstElemInNextLine = 0;
            for (int j = i + 1 + indexOfBegin; j < A.Rows; j += numberOfThreads)   
            {
                aFirstElemInNextLine = A[j, i];
                for (int k = i; k <= A.Columns; k++)  
                {
                    if (k == A.Columns) 
                    {
                        B[j, 0] += (-1) * aFirstElemInNextLine * B[i, 0];
                        break;
                    }
                    A[j, k] += (-1) * aFirstElemInNextLine * A[i, k];
                }
            }
        }
        public void RunReverseAlgorithm(object indexOfBeginning)
        {
            int indexOfBegin = (int)indexOfBeginning, i = IndexOfDiagonalElem;
            double aFirstElemInNextLine = 0;
            for (int j = i - 1 - indexOfBegin; j >= 0; j -= numberOfThreads)
            {
                aFirstElemInNextLine = A[j, i];
                for (int k = i; k >= i - 1; k--)
                {
                    if (k == (i - 1))
                    {
                        B[j, 0] += (-1) * aFirstElemInNextLine * B[i, 0];
                        break;
                    }
                    A[j, k] += (-1) * aFirstElemInNextLine * A[i, k];
                }
            }
        }
    }
}
