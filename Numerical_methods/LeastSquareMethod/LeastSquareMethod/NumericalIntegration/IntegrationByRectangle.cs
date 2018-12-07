using MathFunc = System.Func<double, double>;

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
        public double CalculateIntegral(MathFunc func, double eps)
        {
            double h = (b - a), result = 0, prevResult = 0, xFunc = 0;
            do
            {
                prevResult = result;
                result = 0;
                for (double i = a + h; i <= b; i += h)
                {
                    xFunc = func(i);
                    result += xFunc;
                }
                result *= h;
                h /= 2;
            } while (System.Math.Abs(result - prevResult) > eps);

            return result;
        }
    }
}
