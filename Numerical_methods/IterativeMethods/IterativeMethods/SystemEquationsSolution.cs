using System;
using static System.Math;

namespace IterativeMethods
{
    public class SystemEquationsSolution
    {
        // METHODS
        private Tuple<double, double> SystemOfFuncForIteration(double x, double y)
        {
            return new Tuple<double, double>(-Sin(y) - 0.4, Cos(x + 1) / 2);
        }

        #region The iterative method
        public Tuple<double, double> IterativeProcess(double x, double y, double e, out uint numOfIter)
        {
            double xNext = 0, yNext = 0, epsX = 0, epsY = 0;
            numOfIter = 0;
            do
            {
                var elem = SystemOfFuncForIteration(x, y);
                xNext = elem.Item1;
                yNext = elem.Item2;
                epsX = xNext - x;
                epsY = yNext - y;
                x = xNext;
                y = yNext;
                ++numOfIter;
            } while (Abs(epsX) >= e || Abs(epsY) >= e);
            return new Tuple<double, double>(x, y);
        }
        #endregion

        #region The Newton method
        private Tuple<double, double> SystemOfFuncForNewtonMethod(double x, double y)
        {
            return new Tuple<double, double>(x + Sin(y) + 0.4, 2 * y - Cos(x + 1));
        }

        private double DeterminantOfMatrix(double[,] matrix)
        {
            return (matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1]);
        }

        private Tuple<double, double> DerivativeOfX(double x, double y)
        {
            return new Tuple<double, double>(1, Sin(x + 1));
        }

        private Tuple<double, double> DerivativeOfY(double x, double y)
        {
            return new Tuple<double, double>(Cos(y), 2);
        }

        public Tuple<double, double> NewtonMethod(double x, double y, double e, out uint numOfIter)
        {
            double xNext = 0, yNext = 0, epsX = 0, epsY = 0;
            numOfIter = 0;
            do
            {
                var elemFAndG = SystemOfFuncForNewtonMethod(x, y);
                var derivateY = DerivativeOfY(x, y);
                var derivateX = DerivativeOfX(x, y);
                var determinantX = (-1) * DeterminantOfMatrix(new double[,]
                {
                    { elemFAndG.Item1, derivateY.Item1 },
                    { elemFAndG.Item2, derivateY.Item2 }
                });
                var determinantY = DeterminantOfMatrix(new double[,]
                {
                    { elemFAndG.Item1, derivateX.Item1 },
                    { elemFAndG.Item2, derivateX.Item2 }
                });
                var determinantN = DeterminantOfMatrix(new double[,]
                {
                    { derivateX.Item1, derivateY.Item1 },
                    { derivateX.Item2, derivateY.Item2 }
                });
                xNext = x + determinantX / determinantN;
                yNext = y + determinantY / determinantN;
                epsX = xNext - x;
                epsY = yNext - y;
                x = xNext;
                y = yNext;
                ++numOfIter;
            } while (Abs(epsX) >= e || Abs(epsY) >= e);
            return new Tuple<double, double>(x, y);
        }
        #endregion
    }
}
