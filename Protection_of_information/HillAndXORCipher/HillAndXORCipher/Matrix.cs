using System;

namespace HillAndXORCipher
{
    public class Matrix
    {
        // FIELDS
        private int[,] matrix;
        public int Rows { get; private set; }
        public int Columns { get; private set; }

        // CONSTRUCTORS
        public Matrix(int n, int m)
        {
            matrix = new int[n, m];
            Rows = n;
            Columns = m;
        }

        // INDEXER
        public int this[int first, int second]
        {
            get
            {
                return matrix[first, second];
            }
            set
            {
                matrix[first, second] = value;
            }
        }

        // METHODS
        public void Show()
        {
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    Console.Write($"\t{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
        public Matrix Clone()
        {
            Matrix cloneMatrix = new Matrix(Rows, Columns);
            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Columns; ++j)
                {
                    cloneMatrix[i, j] = matrix[i, j];
                }
            }
            return cloneMatrix;
        }
        public Matrix MultiplyWithMod(Matrix second, int mod)
        {
            if (second != null)
            {
                if (Columns == second.Rows)
                {
                    Matrix result = new Matrix(Rows, second.Columns);
                    for (int i = 0; i < Rows; ++i)
                    {
                        for (int j = 0; j < second.Columns; ++j)
                        {
                            for (int k = 0; k < Columns; ++k)
                            {
                                result[i, j] = (result[i, j] + (matrix[i, k] * second[k, j])) % mod;
                            }
                        }
                    }
                    return result;
                }
                else
                {
                    throw new Exception("There are different columns and rows in matrices.");
                }
            }
            else
            {
                throw new ArgumentNullException("The argument is null.");
            }
        }
        private void SwapRows(ref double[,] result, int row, int nextRow)
        {
            for (int i = 0; i < result.GetLength(row); ++i) 
            {
                double elem = result[row, i];
                result[row, i] = result[nextRow, i];
                result[nextRow, i] = elem;
            }
        }
        public int GetDeterminant()
        {
            if (Rows == Columns)
            {
                double[,] result = new double[Rows, Columns];
                for (int i = 0; i < Rows; ++i)
                {
                    for (int j = 0; j < Columns; ++j)
                    {
                        result[i, j] = matrix[i, j];
                    }
                }
                double determinant = 1, firstElemInNextLine = 0;
                // алгоритм прямого ходу
                for (int i = 0; i < Columns - 1; ++i) 
                {
                    int p = i + 1;
                    if (result[i, i] == 0)
                    {
                        while ((p != Columns) && (result[p, i] == 0)) 
                        {
                            ++p;
                        }
                        if (p == Columns)
                        {
                            return 0;
                        }
                        SwapRows(ref result, i, p);
                        determinant *= (-1);
                    }
                    for (int j = i + 1; j < Rows; ++j)
                    {
                        firstElemInNextLine = result[j, i];
                        for (int k = i; k < Columns; ++k)
                        {
                            result[j, k] += (-1) * firstElemInNextLine * result[i, k] / result[i, i];
                        }
                    }
                }
                for (int i = 0; i < Rows; ++i)
                {
                    determinant *= result[i, i];
                }
                return (int)determinant;
            }
            else
            {
                throw new Exception("Matrix isn`t square.");
            }
        }
        private int GetInvertibleDeterminant(int mod)
        {
            int x, y;
            int determinant = GetDeterminant();
            int g = HillCipher.ExtendedEuclideanAlgorithm(determinant, mod, out x, out y);
            if (g == 1) 
            {
                x = (x % mod + mod) % mod;
            }
            return x;
        }
        private Matrix GetMinorMatrix(int row, int column)
        {
            Matrix minorMatrix = new Matrix(Rows - 1, Columns - 1);
            int m = 0, p = 0;
            for (int i = 0; i < Rows; ++i)
            {
                if (i == row)
                {
                    continue;
                }
                p = 0;
                for (int j = 0; j < Columns; ++j)
                {
                    if (j == column)
                    {
                        continue;
                    }
                    minorMatrix[m, p++] = matrix[i, j];
                }
                ++m;
            }
            return minorMatrix;
        }
        private Matrix GetUnionMatrix(int mod)
        {
            Matrix unionMatrix = new Matrix(Rows, Columns);

            for (int i = 0; i < unionMatrix.Rows; ++i) 
            {
                for (int j = 0; j < unionMatrix.Columns; ++j) 
                {
                    Matrix additionalMinor = this.GetMinorMatrix(i, j);
                    unionMatrix[j, i] = (int)Math.Pow((-1), i + j) * additionalMinor.GetDeterminant() % mod;
                }
            }
            return unionMatrix;
        }
        public Matrix GetInvertibleMatrixWithMod(int mod)
        {
            if (Rows == Columns) 
            {
                if (GetDeterminant() != 0)
                {
                    Matrix result = new Matrix(Rows, Columns);
                    int invertibleDeterminant = GetInvertibleDeterminant(mod);
                    Matrix unionMatrix = GetUnionMatrix(mod);

                    for (int i = 0; i < result.Rows; ++i) 
                    {
                        for (int j = 0; j < result.Columns; ++j)
                        {
                            result[i, j] = (mod + ((invertibleDeterminant * unionMatrix[i, j]) % mod)) % mod;
                        }
                    }
                    return result;
                }
                else
                {
                    throw new Exception("Matrix is degenerate, because its determinant equals 0.");
                }
            }
            else
            {
                throw new Exception("Matrix isn`t square.");
            }
        }
    }
}
