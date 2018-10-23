using System;

namespace FloydAlgorithmInThreads
{
    public class Matrix
    {
        private int[,] matrix;
        public int Length { get; private set; }

        public Matrix(int n)
        {
            matrix = new int[n, n];
            Length = n;
        }
        public int this[int first, int second]
        {
            set
            {
                matrix[first, second] = value;
            }
            get
            {
                return matrix[first, second];
            }
        }
        public void RandomFill()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < Length; ++i)
            {
                for (int j = 0; j < Length; ++j)
                {
                    if (j != i)
                    {
                        matrix[i, j] = random.Next(1, 100);
                    }
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < Length; ++i)
            {
                for (int j = 0; j < Length; ++j)
                {
                    Console.Write($"\t{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public Matrix Clone()
        {
            Matrix newMatrix = new Matrix(Length);
            for (int i = 0; i < Length; ++i)
            {
                for (int j = 0; j < Length; ++j)
                {
                    newMatrix.matrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
    }
}
