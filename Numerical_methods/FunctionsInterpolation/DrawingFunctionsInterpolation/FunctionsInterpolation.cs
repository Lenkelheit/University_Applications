using System;
using System.Windows.Forms;
using InterpolationByNewtonAndGaussMethod;

namespace DrawingFunctionsInterpolation
{
    public partial class FormFunctionsInterpolation : Form
    {
        // FIELDS
        private InterpolationByNewtonMethod interpolationByNewton;
        private InterpolationByGaussMethod interpolationByGauss;

        // CONSTRUCTOR
        public FormFunctionsInterpolation()
        {
            InitializeComponent();

            labelA.Text += InterpolationByNewtonMethod.a;
            labelB.Text += InterpolationByNewtonMethod.b;
            labelN.Text += InterpolationByNewtonMethod.N;

            interpolationByNewton = new InterpolationByNewtonMethod();
            interpolationByGauss = new InterpolationByGaussMethod();
        }

        // METHODS
        private void DrawNewtonAndGaussMethodPolinom(double eps)
        {
            for (int i = 0; i < chartInterpolation.Series.Count; ++i) 
            {
                chartInterpolation.Series[i].Points.Clear();
            }
            int numberIterN, numberIterG;
            for (double i = InterpolationByNewtonMethod.a; i <= InterpolationByNewtonMethod.b; i += 0.01)
            {
                chartInterpolation.Series[0].Points.AddXY(i, interpolationByNewton.BackInterpolationNewtonMethod(i, eps, out numberIterN));

                chartInterpolation.Series[1].Points.AddXY(i, interpolationByGauss.BackInterpolationGaussMethod(i, eps, out numberIterG));
            }

            for (int i = 0; i < interpolationByGauss.Nodes.Count; ++i) 
            {
                chartInterpolation.Series[2].Points.AddXY(interpolationByGauss.Nodes[i].Key, interpolationByGauss.Nodes[i].Value);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double x, eps;
            if (!double.TryParse(textBoxX.Text, out x))
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
                double originalValue = interpolationByNewton.XLnXFunction(x);
                labelFxValue.Text = originalValue.ToString();

                int numberIterNewtonMethod, numberIterGaussMethod;

                double newtonValue = interpolationByNewton.BackInterpolationNewtonMethod(x, eps, out numberIterNewtonMethod);
                labelInterpolationNewtonMethodFxValue.Text = newtonValue.ToString();
                labelNumberIterationNewtonMethodValue.Text = numberIterNewtonMethod.ToString();

                double gaussValue = interpolationByGauss.BackInterpolationGaussMethod(x, eps, out numberIterGaussMethod);
                labelInterpolationGaussMethodFxValue.Text = gaussValue.ToString();
                labelNumberIterationGaussMethodValue.Text = numberIterGaussMethod.ToString();

                labelNewtonDifferences.Text = numberIterNewtonMethod.ToString();
                labelGaussDifferences.Text = numberIterGaussMethod.ToString();

                labelNewtonError.Text = Math.Abs(originalValue - newtonValue).ToString();
                labelGaussError.Text = Math.Abs(originalValue - gaussValue).ToString();

                DrawNewtonAndGaussMethodPolinom(eps);
            }
        }
    }
}
