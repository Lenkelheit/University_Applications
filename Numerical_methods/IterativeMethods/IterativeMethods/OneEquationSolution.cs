using System;
using static System.Math;

namespace IterativeMethods
{
    public class OneEquationSolution
    {
        // METHODS
        private double MyFunc(double x)
        {
            // ctg(x) = 1/tan(x)
            return (1 / Tan(x)) - (x / 3);
        }

        #region The chord method
        private double SecondDerivativeOfMyFunc(double x)
        {
            return 2 * Cos(x) / Pow(Sin(x), 3);
        }

        private double AlgorithmForChordMethod(double x, double a, double b, double e, out uint numOfIter)
        {
            double xNext = 0, eps = 0;
            numOfIter = 0;
            do
            {
                xNext = a - (MyFunc(a) * (b - a)) / (MyFunc(b) - MyFunc(a));
                if (x == a)
                {
                    eps = xNext - a;
                    a = xNext;
                    x = a;
                }
                else
                {
                    eps = xNext - b;
                    b = xNext;
                    x = b;
                }
                ++numOfIter;
            } while (Abs(eps) >= e);
            return x;
        }

        public double ChordMethod(double a, double b, double e, out uint numOfIter)
        {
            double x = 0;
            numOfIter = 0;
            if (MyFunc(b) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                x = a;
            }
            if (MyFunc(a) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                x = b;
            }
            return AlgorithmForChordMethod(x, a, b, e, out numOfIter);
        }
        #endregion

        #region The method of tangents(Newton)
        private double FirstDerivativeOfMyFunc(double x)
        {
            return -1 / Pow(Sin(x), 2) - 1 / 3;
        }

        private double AlgorithmForMethodOfTangents(double x, double e, out uint numOfIter)
        {
            double xNext = 0, eps = 0;
            numOfIter = 0;
            do
            {
                xNext = x - MyFunc(x) / FirstDerivativeOfMyFunc(x);
                eps = xNext - x;
                x = xNext;
                ++numOfIter;
            } while (Abs(eps) >= e);
            return x;
        }

        public double MethodOfTangents(double a, double b, double e, out uint numOfIter)
        {
            double x = 0;
            numOfIter = 0;
            if (MyFunc(a) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                x = a;
            }
            if (MyFunc(b) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                x = b;
            }
            return AlgorithmForMethodOfTangents(x, e, out numOfIter);
        }
        #endregion

        #region The combined method
        public Tuple<double, double> CombinedMethod(double a, double b, double e, out uint numOfIter)
        {
            // x - root of shortage
            // _x - root of excess
            double x = a, _x = b, xNext = 0, _xNext = 0, eps = 0;
            numOfIter = 0;
            if (MyFunc(a) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                do
                {
                    xNext = x - MyFunc(x) / FirstDerivativeOfMyFunc(x);
                    _xNext = x - (MyFunc(x) * (_x - x)) / (MyFunc(_x) - MyFunc(x));
                    eps = xNext - _xNext;
                    x = xNext;
                    _x = _xNext;
                    ++numOfIter;
                } while (Abs(eps) >= e);
            }
            if (MyFunc(b) * SecondDerivativeOfMyFunc((a + b) / 2) > 0)
            {
                do
                {
                    _xNext = _x - MyFunc(_x) / FirstDerivativeOfMyFunc(_x);
                    xNext = x - (MyFunc(x) * (_x - x)) / (MyFunc(_x) - MyFunc(x));
                    eps = xNext - _xNext;
                    x = xNext;
                    _x = _xNext;
                    ++numOfIter;
                } while (Abs(eps) >= e);
            }
            return new Tuple<double, double>(x, _x);
        }
        #endregion
    }
}
