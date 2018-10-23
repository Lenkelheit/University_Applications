using System;

namespace MultiplicationMatrixInThread
{
    public class MatrixProduct
    {
        private Matrix first;
        private Matrix second;
        private Matrix product;
        private uint numberOfThreads;
        public MatrixProduct(Matrix n, Matrix m, uint numOfThreads)
        {
            first = n.Clone();
            second = m.Clone();
            product = new Matrix(first.Rows);
            numberOfThreads = numOfThreads;
        }
        public Matrix GetMatrixProduct()
        {
            return product;
        }
        public void ShiftRowsAndColumns(bool isNeedShiftFirstRowAndColumn, uint indexOfBeginning)
        {
            //Matrix.ShiftRowsAndColumns(first, second, isNeedShiftFirstRowAndColumn);
            double fElem = 0, sElem = 0;
            // якщо потрібно зсувати перший рядок чи колонку, то починаємо відлік з indexOfBeginning
            for (uint i = (isNeedShiftFirstRowAndColumn ? indexOfBeginning : (indexOfBeginning + 1)); i < first.Rows; i += numberOfThreads)  
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
        public void RunShift(object param)
        {
            var paramShiftAndIndex = (Tuple<bool, uint>)param;
            ShiftRowsAndColumns(paramShiftAndIndex.Item1, paramShiftAndIndex.Item2);
        }
        public void RunMultiplicationCannon(object indexOfBeginning)
        { 
            uint indexOfBegin = (uint)indexOfBeginning;
            for (uint i = indexOfBegin; i < first.Rows; i += numberOfThreads)
            {
                for (uint j = 0; j < second.Columns; j++)
                {
                    product[i, j] += (first[i, j] * second[i, j]);
                }
            }
        }
        public void RunMultiplicationString(object indexOfBeginning)
        {
            uint indexOfBegin = (uint)indexOfBeginning;
            for (uint i = 0; i < first.Rows; i++)
            {
                for (uint j = indexOfBegin; j < second.Columns; j += numberOfThreads) 
                {
                    for (uint k = 0; k < first.Columns; k++)
                    {
                        product[i, j] += first[i, k] * second[k, j];
                    }
                }
            }
        }
    }
}
