using System;

namespace NumericalIntegration
{
    public class IntegrationByGauss
    {
        // FIELDS
        private double a;
        private double b;
        private PolynomialCoefficients[] coefPoints4;
        private PolynomialCoefficients[] coefPoints5;

        // CONSTRUCTOR
        public IntegrationByGauss(double a, double b)
        {
            this.a = a;
            this.b = b;

            coefPoints4 = new PolynomialCoefficients[4]
            {
                new PolynomialCoefficients{ t = -0.861136, C = 0.347855 },
                new PolynomialCoefficients{ t = -0.339981, C = 0.652145 },
                new PolynomialCoefficients{ t =  0.339981, C = 0.652145 },
                new PolynomialCoefficients{ t =  0.861136, C = 0.347855 }
            };

            coefPoints5 = new PolynomialCoefficients[5]
            {
                new PolynomialCoefficients{ t = -0.90618,  C = 0.23693 },
                new PolynomialCoefficients{ t = -0.538469, C = 0.47863 },
                new PolynomialCoefficients{ t =  0,        C = 0.56889 },
                new PolynomialCoefficients{ t =  0.538469, C = 0.47863 },
                new PolynomialCoefficients{ t =  0.90618,  C = 0.23693 }
            };
        }

        // METHODS
        public double XLnXFunction(double x, ref int numFuncCall)
        {
            ++numFuncCall;
            return x * Math.Log(x);
        }

        public double CalculateIntegral(out int numOfIter, out int numFuncCalls, bool isPoints4)
        {
            int numPoints = 0;
            PolynomialCoefficients[] coefPoints;
            if (isPoints4) 
            {
                numPoints = 4;
                coefPoints = coefPoints4;
            }
            else
            {
                numPoints = 5;
                coefPoints = coefPoints5;
            }
            numOfIter = 0;
            numFuncCalls = 0;
            double result = 0, x = 0;

            for (int i = 0; i < numPoints; ++i) 
            {
                x = (b + a + (b - a) * coefPoints[i].t) / 2;
                result += coefPoints[i].C * XLnXFunction(x, ref numFuncCalls);
                ++numOfIter;
            }
            result *= (b - a) / 2;

            return result;
        }
    }
}
