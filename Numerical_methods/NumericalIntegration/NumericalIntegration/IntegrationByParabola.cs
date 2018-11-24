using System;

namespace NumericalIntegration
{
    public class IntegrationByParabola
    {
        // FIELDS
        private double a;
        private double b;

        // CONSTRUCTOR
        public IntegrationByParabola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        // METHODS
        public double XLnXFunction(double x, ref int numFuncCall)
        {
            ++numFuncCall;
            return x * Math.Log(x);
        }

        public double CalculateIntegral(double eps, out int numOfIter, out int numFuncCalls)
        {
            numOfIter = 0;
            double h = (b - a), totalResult = 0, prevResult = 0, result1 = 0, result2 = 0;
            do
            {
                prevResult = totalResult;
                result1 = 0;
                result2 = 0;
                numFuncCalls = 0;
                totalResult = XLnXFunction(a, ref numFuncCalls) + XLnXFunction(b, ref numFuncCalls);
                for (double i = a + h; i < b; i += h)
                {
                    result1 += XLnXFunction(i, ref numFuncCalls);
                }
                for (double i = a + h / 2; i < b; i += h)
                {
                    result2 += XLnXFunction(i, ref numFuncCalls);
                }
                totalResult = (totalResult + 2 * result1 + 4 * result2) * h / 6;
                h /= 2;
                ++numOfIter;
            } while (Math.Abs(totalResult - prevResult) > eps);

            return totalResult;
        }
    }
}
