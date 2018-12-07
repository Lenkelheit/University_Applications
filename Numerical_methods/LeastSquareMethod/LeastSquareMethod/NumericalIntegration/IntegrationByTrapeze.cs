using MathFunc = System.Func<double, double>;

namespace NumericalIntegration
{
    public class IntegrationByTrapeze
    {
        // FIELDS
        private double a;
        private double b;

        // CONSTRUCTOR
        public IntegrationByTrapeze(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        // METHODS
        public double CalculateIntegral(MathFunc func, double eps)
        {
            double h = (b - a), result = 0, prevResult = 0;
            do
            {
                prevResult = result;
                result = (func(a) + func(b)) / 2;
                for (double i = a + h; i < b; i += h) 
                {
                    result += func(i);
                }
                result *= h;
                h /= 2;
            } while (System.Math.Abs(result - prevResult) > eps);

            return result;
        }
    }
}
