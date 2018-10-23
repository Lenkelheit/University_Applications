using System;

namespace AddingMatrixInThread
{
    public class Matrix
    {
        private double[,] matrix;
        public uint Rows { get; }
        public uint Columns { get; }
        public Matrix(uint n = 0, uint m = 0)
        {
            Rows = n;
            Columns = n;
            matrix = new double[Rows, Columns];
        }
        public double this[uint firstIndex, uint secondIndex]
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
        public void RandomFill()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }
        }
        public void Show()
        {
            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
                {
                    Console.Write($"\t{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static bool operator ==(Matrix first, Matrix second)
        {
            if (first.Rows == second.Rows && first.Columns == second.Columns)
            {
                for (uint i = 0; i < first.Rows; i++)
                {
                    for (uint j = 0; j < first.Columns; j++)
                    {
                        if (first[i, j] != second[i, j])
                            return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool operator !=(Matrix first, Matrix second)
        {
            return !(first == second);
        }
        public static Matrix operator +(Matrix first, Matrix second)
        {
            if (first.Rows == second.Rows && first.Columns == second.Columns)
            {
                Matrix sum = new Matrix(first.Rows, first.Columns);
                for (uint i = 0; i < first.Rows; i++)
                {
                    for (uint j = 0; j < first.Columns; j++)
                    {
                        sum[i, j] = first[i, j] + second[i, j];
                    }
                }
                return sum;
            }
            throw new ArgumentException("Different quantity of rows and columns is in matrix!");
        }
    }
}
