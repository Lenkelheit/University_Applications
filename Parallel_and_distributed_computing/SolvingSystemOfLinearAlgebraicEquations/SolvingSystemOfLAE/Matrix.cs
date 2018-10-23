using System;

namespace SolvingSystemOfLAE
{
    public class Matrix
    {
        private double[,] matrix;
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public Matrix(int n = 0, int m = 0)
        {
            Rows = n;
            Columns = m;
            matrix = new double[Rows, Columns];
        }
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
        public void RandomFill()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    matrix[i, j] = random.Next(1, 50);
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
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
        public static bool operator ==(Matrix first, Matrix second)
        {
            if (first.Rows == second.Rows && first.Columns == second.Columns)
            {
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Columns; j++)
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
    }
}
