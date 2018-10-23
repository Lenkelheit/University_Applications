using System;
using System.Text;

namespace FloydAlgorithmInThreads
{
    public class FloydAlgorithm
    {
        private static Matrix nextElemMatrix;

        private static void GenerateNextElemMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[i, j] = j;
                }
            }
        }
        public static Matrix FindAllTheShortestPaths(Matrix weightMatrix)
        {
            if (weightMatrix != null)
            {
                int elem = 0;
                Matrix distanceMatrix = weightMatrix.Clone();
                nextElemMatrix = new Matrix(weightMatrix.Length);
                GenerateNextElemMatrix(nextElemMatrix);
                for (int k = 0; k < distanceMatrix.Length; ++k)
                {
                    for (int i = 0; i < distanceMatrix.Length; ++i)
                    {
                        for (int j = 0; j < distanceMatrix.Length; ++j)
                        {
                            elem = distanceMatrix[i, k] + distanceMatrix[k, j];
                            if (elem < distanceMatrix[i, j])
                            {
                                distanceMatrix[i, j] = elem;
                                nextElemMatrix[i, j] = nextElemMatrix[i, k];
                            }
                        }
                    }
                }
                return distanceMatrix;
            }
            else
            {
                throw new ArgumentNullException("Matrix is null.");
            }
        }
        public static string Path(int firstPoint, int lastPoint, Matrix distanceMatrix)
        {
            if (nextElemMatrix != null)
            {
                StringBuilder path = new StringBuilder();
                path.Append(firstPoint + " ");
                int changedFirst = firstPoint;
                while (changedFirst != lastPoint)
                {
                    changedFirst = nextElemMatrix[changedFirst, lastPoint];
                    path.Append(changedFirst + " ");
                }
                path.Append(": " + distanceMatrix[firstPoint, lastPoint]);
                return path.ToString();
            }
            else
            {
                throw new ArgumentNullException("Matrix is null.");
            }
        }
    }
}
