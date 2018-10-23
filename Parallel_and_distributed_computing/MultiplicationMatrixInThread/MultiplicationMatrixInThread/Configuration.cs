using System;
using System.Threading;

namespace MultiplicationMatrixInThread
{
    public class Configuration
    {
        public static Matrix SplitIntoThreadsAndStartCannonAlgorithm(Matrix first, Matrix second, uint numberOfThreads)
        {
            if (first.Columns == second.Rows)
            {
                MatrixProduct matrixProduct = new MatrixProduct(first, second, numberOfThreads);
                Thread[] arrOfThreads = new Thread[numberOfThreads];
                bool isNeedShiftFirstRowAndColumn = false;
                for (uint iter = 0; iter < first.Rows; iter++)
                {
                    for (uint i = 0; i < numberOfThreads; i++)
                    {
                        arrOfThreads[i] = new Thread(matrixProduct.RunShift);
                        arrOfThreads[i].Start(new Tuple<bool, uint>(isNeedShiftFirstRowAndColumn, i));
                    }
                    for (uint i = 0; i < numberOfThreads; i++)
                    {
                        arrOfThreads[i].Join();
                    }
                    for (uint i = 0; i < numberOfThreads; i++)
                    {
                        arrOfThreads[i] = new Thread(matrixProduct.RunMultiplicationCannon);
                        arrOfThreads[i].Start(i);
                    }
                    for (uint i = 0; i < numberOfThreads; i++)
                    {
                        arrOfThreads[i].Join();
                    }
                    if (!isNeedShiftFirstRowAndColumn)
                    {
                        isNeedShiftFirstRowAndColumn = true;
                    }
                }
                return matrixProduct.GetMatrixProduct();
            }
            throw new ArgumentException("There is different quantity of columns in first matrix and rows in second matrix!");
        }
        public static Matrix SplitIntoThreadsAndStartStringAlgorithm(Matrix first, Matrix second, uint numberOfThreads)
        {
            if (first.Columns == second.Rows)
            {
                MatrixProduct matrixProduct = new MatrixProduct(first, second, numberOfThreads);
                Thread[] arrOfThreads = new Thread[numberOfThreads];
                for (uint i = 0; i < numberOfThreads; i++)
                {
                    arrOfThreads[i] = new Thread(matrixProduct.RunMultiplicationString);
                    arrOfThreads[i].Start(i);
                }
                for (uint i = 0; i < numberOfThreads; i++)
                {
                    arrOfThreads[i].Join();
                }
                return matrixProduct.GetMatrixProduct();
            }
            throw new ArgumentException("There is different quantity of columns in first matrix and rows in second matrix!");
        }
    }
}
