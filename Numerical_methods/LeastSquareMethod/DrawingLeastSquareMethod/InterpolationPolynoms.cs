using System;
using System.Windows.Forms;
using LeastSquareMethod;
using InterpolationByNewtonAndGaussMethod;
using MathFunc = System.Func<double, double>;

namespace DrawingLeastSquareMethod
{
    public partial class InterpolationPolynoms : Form
    {
        // FIELDS
        private double a;
        private double b;
        private int n;
        private InterpolationByNewtonMethod interpolationByNewton;
        private InterpolationByGaussMethod interpolationByGauss;
        private MethodOfLeastSquares leastSquaresMethod;
        private ErrorInL2 errorInL2;

        // CONSTRUCTOR
        public InterpolationPolynoms()
        {
            InitializeComponent();

            a = 1.0;
            b = 2.0;
            n = 20;

            labelA.Text += a;
            labelB.Text += b;
            labelN.Text += n;

            interpolationByNewton = new InterpolationByNewtonMethod(a, b, n);
            interpolationByGauss = new InterpolationByGaussMethod(a, b, n);
            leastSquaresMethod = new MethodOfLeastSquares(a, b, n);
            errorInL2 = new ErrorInL2();
        }

        // METHODS
        private void DrawNewtonGaussLeastSquareMethodPolinom(double eps)
        {
            int seriesCount = 2;
            for (int i = 0; i < seriesCount; ++i) 
            {
                chartInterpolationByNewton.Series[i].Points.Clear();

                chartInterpolationByGauss.Series[i].Points.Clear();

                chartLeastSquaresMethod.Series[i].Points.Clear();
            }

            // Function nodes
            for (int i = 0; i < interpolationByNewton.Nodes.Count; ++i)
            {
                chartInterpolationByNewton.Series[1].Points
                    .AddXY(interpolationByNewton.Nodes[i].Key, interpolationByNewton.Nodes[i].Value);

                chartInterpolationByGauss.Series[1].Points
                    .AddXY(interpolationByGauss.Nodes[i].Key, interpolationByGauss.Nodes[i].Value);

                chartLeastSquaresMethod.Series[1].Points
                    .AddXY(leastSquaresMethod.Nodes[i].Key, leastSquaresMethod.Nodes[i].Value);
            }

            // Interpolations
            int numberIter;
            for (double i = a; i <= b; i += 0.01)
            {
                chartInterpolationByNewton.Series[0].Points
                    .AddXY(i, interpolationByNewton.BackInterpolationNewtonMethod(i, eps, out numberIter));

                chartInterpolationByGauss.Series[0].Points
                    .AddXY(i, interpolationByGauss.BackInterpolationGaussMethod(i, eps, out numberIter));

                chartLeastSquaresMethod.Series[0].Points
                    .AddXY(i, leastSquaresMethod.GeneralPolynom(i, eps, out numberIter));
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double inputX, eps;
            if (!double.TryParse(textBoxX.Text, out inputX))
            {
                textBoxX.Text = "";
                MessageBox.Show("Cannot convert x to numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(textBoxEpsylon.Text, out eps))
            {
                textBoxEpsylon.Text = "";
                MessageBox.Show("Cannot convert eps to numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Function y = x * ln(x)
                double originalValue = interpolationByNewton.XLnXFunction(inputX);
                labelFxValue.Text = originalValue.ToString();

                int numberIterNewtonMethod, numberIterGaussMethod, numberIterLeastSquaresMethod;

                // Newton method
                double newtonValue = interpolationByNewton
                    .BackInterpolationNewtonMethod(inputX, eps, out numberIterNewtonMethod);
                labelInterpolationNewtonMethodFxValue.Text = newtonValue.ToString();
                labelNumberIterationNewtonMethodValue.Text = numberIterNewtonMethod.ToString();

                // Gauss method
                double gaussValue = interpolationByGauss
                    .BackInterpolationGaussMethod(inputX, eps, out numberIterGaussMethod);
                labelInterpolationGaussMethodFxValue.Text = gaussValue.ToString();
                labelNumberIterationGaussMethodValue.Text = numberIterGaussMethod.ToString();

                // Least squares method
                double leastSquareValue = leastSquaresMethod
                    .GeneralPolynom(inputX, eps, out numberIterLeastSquaresMethod);
                labelLeastSquaresMethodFx.Text = leastSquareValue.ToString();
                labelNumberLeastSquresValue.Text = numberIterLeastSquaresMethod.ToString();

                // Errors
                labelNewtonError.Text = Math.Abs(originalValue - newtonValue).ToString();
                labelGaussError.Text = Math.Abs(originalValue - gaussValue).ToString();
                labelLeastSquaresError.Text = Math.Abs(originalValue - leastSquareValue).ToString();

                // Errors in L^2([a, b])
                MathFunc func = (x) => x * Math.Log(x);

                labelL2NewtonError.Text = errorInL2.CalculateFuncError(a, b, func,
                    (double X) => interpolationByNewton.BackInterpolationNewtonMethod(X, eps, out numberIterNewtonMethod)).ToString();
                labelL2GaussError.Text = errorInL2.CalculateFuncError(a, b, func,
                    (double X) => interpolationByGauss.BackInterpolationGaussMethod(X, eps, out numberIterGaussMethod)).ToString();
                labelL2LeastSquaresError.Text = errorInL2.CalculateFuncError(a, b, func,
                    (double X) => leastSquaresMethod.GeneralPolynom(X, eps, out numberIterLeastSquaresMethod)).ToString();

                DrawNewtonGaussLeastSquareMethodPolinom(eps);
            }
        }
    }
}
