using System;

namespace LeastSquareMethod
{
    public class GaussSolutionNotFound : Exception
    {
        // CONSTRUCTOR
        public GaussSolutionNotFound(string msg)
            : base("Solution wasn`t found: \r\n" + msg)
        {
        }
    }

    public class LinearSystem
    {
        // FIELDS
        private double[,] workAMatrix;
        private double[,] aMatrix;

        private double[] workBVector;
        private double[] bVector;

        private double[] xVector;

        private double eps; // accurancy order for real numbers
        private int size;

        // PROPERTIES
        public double[] XVector
        {
            get
            {
                return xVector;
            }
        }

        // CONSTRUCTORS
        public LinearSystem(double[,] aMatrix, double[] bVector)
            : this(aMatrix, bVector, 0.0001)
        {
        }

        public LinearSystem(double[,] aMatrix, double[] bVector, double eps)
        {
            if (aMatrix == null || bVector == null)
            {
                throw new ArgumentNullException("The one argument is null.");
            }

            int bLength = bVector.Length;
            if (aMatrix.GetLength(0) != aMatrix.GetLength(1) || aMatrix.GetLength(0) != bLength) 
            {
                throw new ArgumentException("The rows and columns amount of matrix A must be the same as the size of vector B.");
            }

            this.aMatrix = aMatrix;
            this.workAMatrix = (double[,])aMatrix.Clone(); 

            this.bVector = bVector;
            this.workBVector = (double[])bVector.Clone();

            this.xVector = new double[bLength];

            this.size = bLength;
            this.eps = eps;

            GaussSolve();
        }

        // METHODS
        // initialize an array of row's indices
        private int[] InitIndex()
        {
            int[] index = new int[size];
            for (int i = 0; i < index.Length; ++i) 
            {
                index[i] = i;
            }
            return index;
        }

        // finding a main element in matrix
        private double FindR(int row, int[] index)
        {
            int maxIndex = row;
            double max = workAMatrix[row, index[maxIndex]];
            double maxAbs = Math.Abs(max);

            //if(row < size - 1)
            for (int curIndex = row + 1; curIndex < size; ++curIndex)
            {
                double cur = workAMatrix[row, index[curIndex]];
                double cur_abs = Math.Abs(cur);
                if (cur_abs > maxAbs)
                {
                    maxIndex = curIndex;
                    max = cur;
                    maxAbs = cur_abs;
                }
            }

            if (maxAbs < eps)
            {
                if (Math.Abs(bVector[row]) > eps)
                {
                    throw new GaussSolutionNotFound("The system of equations is incompatible.");
                }
                else
                {
                    throw new GaussSolutionNotFound("The system of equations has a lot of solutions.");
                }
            }

            // swaping row's indices
            int temp = index[row];
            index[row] = index[maxIndex];
            index[maxIndex] = temp;

            return max;
        }

        // Finding the SLAE solution by the Gauss method
        private void GaussSolve()
        {
            int[] index = InitIndex();
            GaussForwardStroke(index);
            GaussBackwardStroke(index);
        }

        private void GaussForwardStroke(int[] index)
        {
            // moving on each row from top to bottom
            for (int i = 0; i < size; ++i)
            {
                // 1) select main element
                double r = FindR(i, index);

                // 2) changing current A matrix row
                for (int j = 0; j < size; ++j)
                {
                    workAMatrix[i, j] /= r;
                }

                // 3) changing element at index "i" in B vector
                workBVector[i] /= r;

                // 4) subtract the current row from all the rows below
                for (int k = i + 1; k < size; ++k)
                {
                    double p = workAMatrix[k, index[i]];
                    for (int j = i; j < size; ++j)
                    {
                        workAMatrix[k, index[j]] -= workAMatrix[i, index[j]] * p;
                    }
                    workBVector[k] -= workBVector[i] * p;
                    workAMatrix[k, index[i]] = 0.0;
                }
            }
        }

        private void GaussBackwardStroke(int[] index)
        {
            // moving on each row from bottom to top
            for (int i = size - 1; i >= 0; --i)
            {
                // 1) initialize start value of x
                double xI = workBVector[i];

                // 3) updating x
                for (int j = i + 1; j < size; ++j)
                {
                    xI -= xVector[index[j]] * workAMatrix[i, index[j]];
                }
                xVector[index[i]] = xI;
            }
        }
    }
}
