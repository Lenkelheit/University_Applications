using System;

namespace MultiplicationMatrixInThread
{
    public class Matrix
    {
        private double[,] matrix;
        public uint Rows { get; private set; }
        public uint Columns { get; private set; }
        public Matrix(uint n = 0)
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
                    matrix[i, j] = random.Next(0, 50);
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
        public Matrix Clone()
        {
            Matrix newMatrix = new Matrix(Rows);
            for (uint i = 0; i < Rows; i++)
            {
                for (uint j = 0; j < Columns; j++)
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
        public static void ShiftRowsAndColumns(Matrix first, Matrix second, bool isNeedShiftFirstRowAndColumn)
        {
            double fElem = 0, sElem = 0;
            // якщо не потрібно зсувати перший рядок чи колонку, то починаємо відлік з 1
            for (uint i = isNeedShiftFirstRowAndColumn ? 0u : 1u; i < first.Rows; i++)
            {
                // залежно від потрібності зсуву першого рядка чи колонки буде відбуватись така кількість ітерацій
                for (uint j = 0; j < (isNeedShiftFirstRowAndColumn ? 1u : i); j++)
                {
                    fElem = first[i, 0];
                    sElem = second[0, i];
                    for (uint k = 0; k < first.Columns - 1; k++)
                    {
                        // для лівої матриці(first) виконуємо циклічний зсув вліво на 1 елемент 
                        first[i, k] = first[i, k + 1];
                        // для правої матриці(second) виконуємо циклічний зсув вгору на 1 елемент 
                        second[k, i] = second[k + 1, i];
                    }
                    first[i, first.Columns - 1] = fElem;
                    second[second.Rows - 1, i] = sElem;
                }
            }
        }
        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.Columns == second.Rows)
            {
                bool isNeedShiftFirstRowAndColumn = false;
                Matrix firstMat = first.Clone();
                Matrix secondMat = second.Clone();
                Matrix product = new Matrix(firstMat.Rows);
                for (uint iter = 0; iter < firstMat.Rows; iter++)
                {
                    ShiftRowsAndColumns(firstMat, secondMat, isNeedShiftFirstRowAndColumn);
                    if (!isNeedShiftFirstRowAndColumn)
                    {
                        isNeedShiftFirstRowAndColumn = true;
                    }
                    for (uint i = 0; i < firstMat.Rows; i++)
                    {
                        for (uint j = 0; j < secondMat.Columns; j++)
                        {
                            product[i, j] += firstMat[i, j] * secondMat[i, j];
                        }
                    }
                }
                return product;
            }
            throw new ArgumentException("There is different quantity of columns in first matrix and rows in second matrix!");
        }
        public static Matrix Multiply(Matrix first, Matrix second)
        {
            if (first.Columns == second.Rows)
            {
                Matrix product = new Matrix(first.Rows);
                for (uint i = 0; i < first.Rows; i++)
                {
                    for (uint j = 0; j < second.Columns; j++)
                    {
                        for (uint k = 0; k < first.Columns; k++)
                        {
                            product.matrix[i, j] += first.matrix[i, k] * second.matrix[k, j];
                        }
                    }
                }
                return product;
            }
            throw new ArgumentException("There is different quantity of columns in first matrix and rows in second matrix!");
        }
    }
}
