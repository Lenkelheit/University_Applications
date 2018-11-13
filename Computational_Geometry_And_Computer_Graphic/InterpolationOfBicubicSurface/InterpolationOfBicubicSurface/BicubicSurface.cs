using System;

namespace InterpolationOfBicubicSurface
{
    public class BicubicSurface
    {
        // CONST
        private const int FOUR_DIMENSION = 4;
        private const int THREE_DIMENSION = 3;

        // FIELDS
        private Matrix U;
        private Matrix N;
        private Matrix P;
        private Matrix transposN;
        private Matrix W;

        // CONSTRUCTOR
        public BicubicSurface(Matrix P)
        {
            U = new Matrix(1, FOUR_DIMENSION);

            N = new Matrix(FOUR_DIMENSION, FOUR_DIMENSION);
            FillNMatrix();

            this.P = P;

            transposN = N.Transpos();

            W = new Matrix(FOUR_DIMENSION, 1);
        }

        // METHODS
        public void SetUAndW(double u, double w)
        {
            FillUMatrix(u);

            FillWMatrix(w);
        }

        private void FillUMatrix(double u)
        {
            U[0, 0] = Math.Pow(u, 3);
            U[0, 1] = Math.Pow(u, 2);
            U[0, 1] = Math.Pow(u, 1);
            U[0, 3] = 1;
        }

        private void FillWMatrix(double w)
        {
            W[0, 0] = Math.Pow(w, 3);
            W[1, 0] = Math.Pow(w, 2);
            W[2, 0] = Math.Pow(w, 1);
            W[3, 0] = 1;
        }

        private void FillNMatrix()
        {
            N[0, 0] = 2;
            N[0, 1] = -2;
            N[0, 2] = 1;
            N[0, 3] = 1;
            N[1, 0] = -3;
            N[1, 1] = 3;
            N[1, 2] = -2;
            N[1, 3] = -1;
            N[2, 2] = 1;
            N[3, 0] = 1;
        }

        private Matrix CreatePartialMatrixP(int index)
        {
            Matrix partialMatrix = new Matrix(FOUR_DIMENSION, FOUR_DIMENSION);

            for (int i = 0; i < P.Rows; ++i)  
            {
                int k = 0;
                for (int j = index; j < P.Columns; j += 3) 
                {
                    partialMatrix[i, k++] = P[i, j];
                }
            }
            return partialMatrix;
        }

        public Matrix CalculateCoordinate()
        {
            Matrix XPMatrix = CreatePartialMatrixP(0);
            Matrix YPMatrix = CreatePartialMatrixP(1);
            Matrix ZPMatrix = CreatePartialMatrixP(2);

            Matrix coordinateX = U * N * XPMatrix * transposN * W;
            Matrix coordinateY = U * N * YPMatrix * transposN * W;
            Matrix coordinateZ = U * N * ZPMatrix * transposN * W;

            Matrix coordinate = new Matrix(1, THREE_DIMENSION);
            coordinate[0, 0] = coordinateX[0, 0];
            coordinate[0, 1] = coordinateY[0, 0];
            coordinate[0, 2] = coordinateZ[0, 0];
            return coordinate;
        }
    }
}
