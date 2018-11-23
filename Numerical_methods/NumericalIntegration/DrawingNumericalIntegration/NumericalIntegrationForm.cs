using System;
using System.Windows.Forms;
using NumericalIntegration;

namespace DrawingNumericalIntegration
{
    public partial class NumericalIntegrationForm : Form
    {
        // FIELDS
        private double a;
        private double b;
        private IntegrationByRectangle integrationByRectangle;
        private IntegrationByTrapeze integrationByTrapeze;
        private IntegrationByParabola integrationByParabola;
        private IntegrationByGauss integrationByGauss;

        // CONSTRUCTOR
        public NumericalIntegrationForm()
        {
            InitializeComponent();

            a = 1;
            b = 2;
            labelA.Text += a.ToString();
            labelB.Text += b.ToString();
            integrationByRectangle = new IntegrationByRectangle(a, b);
            integrationByTrapeze = new IntegrationByTrapeze(a, b);
            integrationByParabola = new IntegrationByParabola(a, b);
            integrationByGauss = new IntegrationByGauss(a, b);
        }

        // METHODS
        private void DrawXLnXFunctionChart()
        {
            int numFuncCall = 0;
            chart.Series[0].Points.Clear();
            for (double i = a; i <= b; i += 0.001) 
            {
                chart.Series[0].Points.AddXY(i, integrationByRectangle.XLnXFunction(i, ref numFuncCall));
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double eps;
            if (!double.TryParse(textBoxEpsylon.Text, out eps))
            {
                textBoxEpsylon.Text = "";
                MessageBox.Show("Cannot convert eps to numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int numberIterRectangle, numberIterTrapeze, numberIterParabola, numberIterGauss,
                    numberFuncCallsRectangle, numberFuncCallsTrapeze, numberFuncCallsParabola, numberFuncCallsGauss;

                double integralRectangle = integrationByRectangle.CalculateIntegral(eps, out numberIterRectangle, out numberFuncCallsRectangle);
                labelIByRectangles.Text = integralRectangle.ToString();
                labelCallsRectangles.Text = numberFuncCallsRectangle.ToString();
                labelIterationRectangles.Text = numberIterRectangle.ToString();

                double integralTrapeze = integrationByTrapeze.CalculateIntegral(eps, out numberIterTrapeze, out numberFuncCallsTrapeze);
                labelIByTrapezes.Text = integralTrapeze.ToString();
                labelCallsTrapezes.Text = numberFuncCallsTrapeze.ToString();
                labelIterationTrapezes.Text = numberIterTrapeze.ToString();

                double integralParabola = integrationByParabola.CalculateIntegral(eps, out numberIterParabola, out numberFuncCallsParabola);
                labelIByParabolas.Text = integralParabola.ToString();
                labelCallsParabolas.Text = numberFuncCallsParabola.ToString();
                labelIterationParabolas.Text = numberIterParabola.ToString();

                double integralGaussPoints4 = integrationByGauss.CalculateIntegral(out numberIterGauss, out numberFuncCallsGauss, isPoints4: true);
                labelIByGaussPoints4.Text = integralGaussPoints4.ToString();
                labelCallsGaussPoints4.Text = numberFuncCallsGauss.ToString();
                labelIterationGaussPoints4.Text = numberIterGauss.ToString();

                double integralGaussPoints5 = integrationByGauss.CalculateIntegral(out numberIterGauss, out numberFuncCallsGauss, isPoints4: false);
                labelIByGaussPoints5.Text = integralGaussPoints5.ToString();
                labelCallsGaussPoints5.Text = numberFuncCallsGauss.ToString();
                labelIterationGaussPoints5.Text = numberIterGauss.ToString();

                DrawXLnXFunctionChart();
            }
        }
    }
}
