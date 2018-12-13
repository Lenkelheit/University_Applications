using System;

namespace PrimsAlgorithmInThreads
{
    public class Matrix
    {
        // FIELDS
        private int[,] matrix;

        // PROPERTIES
        public int Length { get; private set; }

        // CONSTRUCTORS
        public Matrix(int n)
        {
            matrix = new int[n, n];
            Length = n;
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
            Length = matrix.GetLength(0);
        }

        // INDEXER
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

        // METHODS
        public void RandomFill()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int centralIndex = (int)Math.Ceiling(Length / 2D);
            for (int i = 0; i < centralIndex; ++i)  
            {
                for (int j = 0; j < Length; ++j)
                {
                    if (j != i)
                    {
                        matrix[i, j] = random.Next(1, 100);
                        matrix[j, i] = matrix[i, j];
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
