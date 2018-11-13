using System;

namespace InterpolationOfBicubicSurface
{
    public class Projection
    {
        // CONST
        private const int THREE_DIMENSION = 3;

        // PROPERTIES
        public Matrix MatrixOfProjection { get; private set; }

        // CONSTRUCTORS
        public Projection()
        {
            MatrixOfProjection = new Matrix(THREE_DIMENSION, THREE_DIMENSION);
        }

        // METHODS
        public void CreateMatrixOfProjectionOnZEqualsNull(double angleY, double angleX)
        {
            double radAngleY = (angleY / 180) * Math.PI, radAngleX = (angleX / 180) * Math.PI;

            MatrixOfProjection[0, 0] = Math.Cos(radAngleY);
            MatrixOfProjection[0, 1] = Math.Sin(radAngleY) * Math.Sin(radAngleX);
            MatrixOfProjection[1, 1] = Math.Cos(radAngleX);
            MatrixOfProjection[2, 0] = Math.Sin(radAngleY);
            MatrixOfProjection[2, 1] = -Math.Cos(radAngleY) * Math.Sin(radAngleX);
        }

        public void CreateMatrixOfProjectionOnYEqualsNull(double angleX, double angleZ)
        {
            double radAngleX = (angleX / 180) * Math.PI, radAngleZ = (angleZ / 180) * Math.PI;

            MatrixOfProjection[0, 0] = Math.Cos(radAngleZ);
            MatrixOfProjection[1, 0] = -Math.Sin(radAngleZ) * Math.Cos(radAngleX);
            MatrixOfProjection[1, 2] = Math.Sin(radAngleX);
            MatrixOfProjection[2, 0] = Math.Sin(radAngleX) * Math.Sin(radAngleZ);
            MatrixOfProjection[2, 2] = Math.Cos(radAngleX);
        }

        public void CreateMatrixOfProjectionOnXEqualsNull(double angleZ, double angleY)
        {
            double radAngleZ = (angleZ / 180) * Math.PI, radAngleY = (angleY / 180) * Math.PI;

            MatrixOfProjection[0, 1] = Math.Sin(radAngleZ);
            MatrixOfProjection[0, 2] = -Math.Cos(radAngleZ) * Math.Sin(radAngleY);
            MatrixOfProjection[1, 1] = Math.Cos(radAngleZ);
            MatrixOfProjection[1, 2] = Math.Sin(radAngleZ) * Math.Sin(radAngleY);
            MatrixOfProjection[2, 2] = Math.Cos(radAngleY);
        }
    }
}
