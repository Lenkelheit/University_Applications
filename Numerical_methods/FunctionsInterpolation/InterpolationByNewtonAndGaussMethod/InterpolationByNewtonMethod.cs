using System;
using System.Collections.Generic;

namespace InterpolationByNewtonAndGaussMethod
{
    public class InterpolationByNewtonMethod
    {
        // FIELDS
        private double a;
        private double b;
        private int n;
        private double h;
        private double[][] differences;

        // PROPERTIES
        public List<KeyValuePair<double, double>> Nodes { get; private set; }

        // CONSTRUCTORS
        public InterpolationByNewtonMethod(double a = 1.0, double b = 2.0, int n = 20)
        {
            this.a = a;
            this.b = b;
            this.n = n;

            h = (b - a) / n;
            Nodes = new List<KeyValuePair<double, double>>();
            CreateNodes();

            differences = new double[Nodes.Count][];
            int startIndex = 0;
            differences[startIndex] = new double[Nodes.Count];
            for (int i = 0; i < Nodes.Count; ++i) 
            {
                differences[startIndex][i] = Nodes[i].Value;
            }
            FillDifferencesMatrix(startIndex);
        }

        // METHODS
        public double XLnXFunction(double x)
        {
            return x * Math.Log(x);
        }

        private void CreateNodes()
        {
            double x = 0;
            for (int i = 0; i <= n; ++i)
            {
                x = a + i * h;
                Nodes.Add(new KeyValuePair<double, double>(x, XLnXFunction(x)));
            }
        }

        private void FillDifferencesMatrix(int startIndex)
        {
            if (differences[startIndex].Length == 1)
            {
                return;
            }
            int currentDifferencesCount = differences[startIndex].Length, nextIndex = startIndex + 1;
            differences[nextIndex] = new double[currentDifferencesCount - 1];
            for (int i = 0; i < currentDifferencesCount - 1; ++i)
            {
                differences[nextIndex][i] = differences[startIndex][i + 1] - differences[startIndex][i];
            }
            FillDifferencesMatrix(nextIndex);
        }

        public double BackInterpolationNewtonMethod(double x, double epsylon, out int numberIter)
        {
            double resultPolinom = Nodes[Nodes.Count - 1].Value;

            double numerator = 1, step = 1, prevResult = 0;
            int j = 1, factorial = 1, i = Nodes.Count - 2;
            do
            {
                prevResult = resultPolinom;
                numerator *= (x - Nodes[i + 1].Key);
                factorial *= j;
                step *= h;
                resultPolinom += numerator / (factorial * step) * differences[j][i];

                ++j;
                --i;
            } while (Math.Abs(resultPolinom - prevResult) > epsylon && i >= 0);
            numberIter = j;

            return resultPolinom;
        }
    }
}
