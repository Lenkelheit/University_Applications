using System;

namespace NumericalIntegration
{
    public class IntegrationByRectangle
    {
        // FIELDS
        private double a;
        private double b;

        // CONSTRUCTOR
        public IntegrationByRectangle(double a, double b)
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
            double h = (b - a), result = 0, prevResult = 0, xFunc = 0;
            do
            {
                prevResult = result;
                result = 0;
                numFuncCalls = 0;
                for (double i = a + h; i <= b; i += h)
                {
                    xFunc = XLnXFunction(i, ref numFuncCalls);
                    result += xFunc;
                }
                result *= h;
                h /= 2;
                ++numOfIter;
            } while (Math.Abs(result - prevResult) > eps);

            return result;
        }
    }
}
