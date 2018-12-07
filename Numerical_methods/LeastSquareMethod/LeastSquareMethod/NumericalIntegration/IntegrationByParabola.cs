using MathFunc = System.Func<double, double>;

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
        public double CalculateIntegral(MathFunc func, double eps)
        {
            double h = (b - a), totalResult = 0, prevResult = 0, result1 = 0, result2 = 0;
            do
            {
                prevResult = totalResult;
                result1 = 0;
                result2 = 0;
                totalResult = func(a) + func(b);
                for (double i = a + h; i < b; i += h)
                {
                    result1 += func(i);
                }
                for (double i = a + h / 2; i < b; i += h)
                {
                    result2 += func(i);
                }
                totalResult = (totalResult + 2 * result1 + 4 * result2) * h / 6;
                h /= 2;
            } while (System.Math.Abs(totalResult - prevResult) > eps);

            return totalResult;
        }
    }
}
