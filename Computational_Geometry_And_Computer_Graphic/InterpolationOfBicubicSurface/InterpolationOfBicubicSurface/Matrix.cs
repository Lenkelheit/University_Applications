using System;

namespace InterpolationOfBicubicSurface
{
    public class Matrix
    {
        // FIELDS
        private double[,] matrix;

        //PROPERTIES
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        // CONSTRUCTOR
        public Matrix(int n = 0, int m = 0)
        {
            Rows = n;
            Columns = m;
            matrix = new double[Rows, Columns];
        }

        // INDEXER
        public double this[int firstIndex, int secondIndex]
        {
            set
            {
                matrix[firstIndex, secondIndex] = value;
            }
            get
            {
                return matrix[firstIndex, secondIndex];
            }
        }

        // METHODS
        public void Show()
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Console.Write($"\t{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public Matrix Clone()
        {
            Matrix newMatrix = new Matrix(Rows, Columns);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    newMatrix.matrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }

        public Matrix Transpos()
        {
            Matrix transposMatrix = new Matrix(Rows, Columns);
            for (int i = 0; i < transposMatrix.Rows; ++i)
            {
                for (int j = 0; j < transposMatrix.Columns; ++j)
                {
                    transposMatrix.matrix[j, i] = matrix[i, j];
                }
            }
            return transposMatrix;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.Columns == second.Rows)
            {
                Matrix firstMat = first.Clone();
                Matrix secondMat = second.Clone();
                Matrix product = new Matrix(firstMat.Rows, secondMat.Columns);
                for (int i = 0; i < firstMat.Rows; ++i) 
                {
                    for (int j = 0; j < secondMat.Columns; ++j) 
                    {
                        for (int k = 0; k < firstMat.Columns; ++k) 
                        {
                            product[i, j] += firstMat[i, k] * secondMat[k, j];
                        }
                    }
                }
                return product;
            }
            throw new ArgumentException("There is different quantity of columns in first matrix and rows in second matrix!");
        }
    }
}
