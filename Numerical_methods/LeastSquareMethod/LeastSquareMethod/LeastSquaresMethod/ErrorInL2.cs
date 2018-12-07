using NumericalIntegration;
using MathFunc = System.Func<double, double>;

namespace LeastSquareMethod
{
    public class ErrorInL2
    {
        // METHODS
        public double CalculateFuncError(double a, double b, MathFunc func1, MathFunc func2)
        {
            IntegrationByGauss integral = new IntegrationByGauss(a, b);
            return System.Math.Sqrt(integral.
                CalculateIntegral((double x) => System.Math.Pow(func1(x) - func2(x), 2), isPoints4: true));
        }
    }
}
