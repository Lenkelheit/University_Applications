using System;
using System.Collections.Generic;

namespace LeastSquareMethod
{
    public class MethodOfLeastSquares
    {
        // FIELDS
        private double a;
        private double b;
        private int n;

        // PROPERTIES
        public List<KeyValuePair<double, double>> Nodes { get; private set; }

        // CONSTRUCTORS
        public MethodOfLeastSquares(double a = 1.0, double b = 2.0, int n = 20)
        {
            this.a = a;
            this.b = b;
            this.n = n;

            double h = (b - a) / n;
            Nodes = new List<KeyValuePair<double, double>>();
            CreateNodes(h);
        }

        // METHODS
        public double XLnXFunction(double x)
        {
            return x * Math.Log(x);
        }

        private void CreateNodes(double h)
        {
            double x = 0;
            for (int i = 0; i <= n; ++i)
            {
                x = a + i * h;
                Nodes.Add(new KeyValuePair<double, double>(x, XLnXFunction(x)));
            }
        }

        private double LinearIndepFunc(double x, int degree)
        {
            // 1, x, x^2,..., x^degree
            return Math.Pow(x, degree);
        }

        private double FiKAndFiY(int k, int j)
        {
            double sum = 0;
            for (int i = 0; i < n; ++i) 
            {
                sum += LinearIndepFunc(Nodes[i].Key, k) * LinearIndepFunc(Nodes[i].Key, j);
            }
            return sum;
        }

        private double FuncAndFiY(int j)
        {
            double sum = 0;
            for (int i = 0; i < n; ++i) 
            {
                sum += Nodes[i].Value * LinearIndepFunc(Nodes[i].Key, j);
            }
            return sum;
        }

        private double[] FindСoeffsA(double epsylon, int degree)
        {
            double[,] matrixA = new double[degree, degree];
            double[] vectorB = new double[degree];

            for (int i = 0; i < degree; ++i) 
            {
                for (int j = 0; j < degree; ++j) 
                {
                    matrixA[i, j] = FiKAndFiY(j, i);
                }
                vectorB[i] = FuncAndFiY(i);
            }

            LinearSystem linearSystem = new LinearSystem(matrixA, vectorB, epsylon);
            return linearSystem.XVector;
        }

        private double CalculateGeneralPolynomSum(double x, double epsylon, int degree)
        {
            double[] coeffsA = FindСoeffsA(epsylon, degree);

            double sum = 0;
            for (int i = 0; i < degree; ++i) 
            {
                sum += coeffsA[i] * LinearIndepFunc(x, i);
            }
            return sum;
        }

        public double GeneralPolynom(double x, double epsylon, out int numberIter)
        {
            int degree = 1;
            double resultPolinom = CalculateGeneralPolynomSum(x, epsylon, degree), prevResult = 0;

            do
            {
                prevResult = resultPolinom;
                try
                {
                    resultPolinom = CalculateGeneralPolynomSum(x, epsylon, ++degree);
                }
                catch (GaussSolutionNotFound)
                {
                    break;
                }

            } while (Math.Abs(resultPolinom - prevResult) > epsylon && degree < n);
            numberIter = degree;
            return resultPolinom;
        }
    }
}
