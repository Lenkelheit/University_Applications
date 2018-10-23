using System;

namespace SolvingSystemOfLAE
{
    public class SolvingSystemOfEquationsGaussMethod
    {
        public static Matrix SolveSystemOfLAE(Matrix a, Matrix b)
        {
            if (a.Rows == a.Columns && a.Rows == b.Rows && b.Columns == 1)
            {
                Matrix A = a.Clone();
                Matrix B = b.Clone();
                double aFirstElemInLine = 0, aFirstElemInNextLine = 0;
                // алгоритм прямого ходу
                for (int i = 0; i < A.Columns; i++)
                {
                    aFirstElemInLine = A[i, i];
                    for (int j = i; j < A.Rows; j++)
                    {
                        A[i, j] /= aFirstElemInLine;
                    }
                    B[i, 0] /= aFirstElemInLine;
                    for (int j = i + 1; j < A.Rows; j++)
                    {
                        aFirstElemInNextLine = A[j, i];
                        for (int k = i; k < A.Columns; k++)
                        {
                            A[j, k] += (-1) * aFirstElemInNextLine * A[i, k];
                        }
                        B[j, 0] += (-1) * aFirstElemInNextLine * B[i, 0];
                    }
                }
                // алгоритм зворотного ходу
                for (int i = A.Columns - 1; i > 0; i--)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        aFirstElemInNextLine = A[j, i];
                        for (int k = i; k > i - 1; k--)
                        {
                            A[j, k] += (-1) * aFirstElemInNextLine * A[i, k];
                        }
                        B[j, 0] += (-1) * aFirstElemInNextLine * B[i, 0];
                    }
                }
                return B;
            }
            else
            {
                throw new ArgumentException("There is wrong quantity of equations, arguments or free members!");
            }
        }
    }
}
