using System.Collections.Generic;
using InterpolationOfBicubicSurface;

namespace BicubicSurfaceDrawing
{
    public partial class BicubicSurfaceForm : System.Windows.Forms.Form
    {
        // CONST
        private const int FOUR_DIMENSION = 4;

        // FIELDS
        private BicubicSurface bicubicSurface;
        private Projection projection;

        // CONSTRUCTORS
        public BicubicSurfaceForm()
        {
            InitializeComponent();
            for (int i = 0; i < FOUR_DIMENSION; ++i)
            {
                vertixesDgv.Rows.Add();
                uVectorsDgv.Rows.Add();
                wVectorsDgv.Rows.Add();
                vectorsOfCurvatureDgv.Rows.Add();
            }
            vertixesDgv.Rows[0].Cells[0].Value = -100;
            vertixesDgv.Rows[0].Cells[1].Value = 0;
            vertixesDgv.Rows[0].Cells[2].Value = 100;
            vertixesDgv.Rows[1].Cells[0].Value = -100;
            vertixesDgv.Rows[1].Cells[1].Value = -100;
            vertixesDgv.Rows[1].Cells[2].Value = -100;
            vertixesDgv.Rows[2].Cells[0].Value = 100;
            vertixesDgv.Rows[2].Cells[1].Value = -100;
            vertixesDgv.Rows[2].Cells[2].Value = 100;
            vertixesDgv.Rows[3].Cells[0].Value = 100;
            vertixesDgv.Rows[3].Cells[1].Value = 0;
            vertixesDgv.Rows[3].Cells[2].Value = -100;

            uVectorsDgv.Rows[0].Cells[0].Value = 100;
            uVectorsDgv.Rows[0].Cells[1].Value = 100;
            uVectorsDgv.Rows[0].Cells[2].Value = 0;
            uVectorsDgv.Rows[1].Cells[0].Value = 1;
            uVectorsDgv.Rows[1].Cells[1].Value = 1;
            uVectorsDgv.Rows[1].Cells[2].Value = 0;
            uVectorsDgv.Rows[2].Cells[0].Value = 1;
            uVectorsDgv.Rows[2].Cells[1].Value = -1;
            uVectorsDgv.Rows[2].Cells[2].Value = 0;
            uVectorsDgv.Rows[3].Cells[0].Value = 1;
            uVectorsDgv.Rows[3].Cells[1].Value = -1;
            uVectorsDgv.Rows[3].Cells[2].Value = 0;

            wVectorsDgv.Rows[0].Cells[0].Value = 0;
            wVectorsDgv.Rows[0].Cells[1].Value = 10;
            wVectorsDgv.Rows[0].Cells[2].Value = -10;
            wVectorsDgv.Rows[1].Cells[0].Value = 0;
            wVectorsDgv.Rows[1].Cells[1].Value = -1;
            wVectorsDgv.Rows[1].Cells[2].Value = -1;
            wVectorsDgv.Rows[2].Cells[0].Value = 0;
            wVectorsDgv.Rows[2].Cells[1].Value = 1;
            wVectorsDgv.Rows[2].Cells[2].Value = -1;
            wVectorsDgv.Rows[3].Cells[0].Value = 0;
            wVectorsDgv.Rows[3].Cells[1].Value = -1;
            wVectorsDgv.Rows[3].Cells[2].Value = -1;

            vectorsOfCurvatureDgv.Rows[0].Cells[0].Value = 0;
            vectorsOfCurvatureDgv.Rows[0].Cells[1].Value = 0;
            vectorsOfCurvatureDgv.Rows[0].Cells[2].Value = 0;
            vectorsOfCurvatureDgv.Rows[1].Cells[0].Value = 0.1;
            vectorsOfCurvatureDgv.Rows[1].Cells[1].Value = 0.1;
            vectorsOfCurvatureDgv.Rows[1].Cells[2].Value = 0.1;
            vectorsOfCurvatureDgv.Rows[2].Cells[0].Value = 0.1;
            vectorsOfCurvatureDgv.Rows[2].Cells[1].Value = -0.1;
            vectorsOfCurvatureDgv.Rows[2].Cells[2].Value = -0.1;
            vectorsOfCurvatureDgv.Rows[3].Cells[0].Value = 0;
            vectorsOfCurvatureDgv.Rows[3].Cells[1].Value = 0;
            vectorsOfCurvatureDgv.Rows[3].Cells[2].Value = 0;

            double size = 800, interval = 50;
            chartBicubicSurface.ChartAreas[0].AxisX.Interval = interval;
            chartBicubicSurface.ChartAreas[0].AxisY.Interval = interval;

            chartBicubicSurface.ChartAreas[0].AxisX.Maximum = size;
            chartBicubicSurface.ChartAreas[0].AxisX.Minimum = -size;

            chartBicubicSurface.ChartAreas[0].AxisY.Maximum = size;
            chartBicubicSurface.ChartAreas[0].AxisY.Minimum = -size;
        }

        // METHODS
        private Matrix CreateMatrixP()
        {
            Matrix P = new Matrix(FOUR_DIMENSION, 3 * FOUR_DIMENSION);

            int k = 0;
            for (int i = 0; i < P.Rows / 2; ++i)
            {
                int m = 0;
                for (int j = 0; j < P.Columns / 2; ++j)
                {
                    if (m == vertixesDgv.ColumnCount)
                    {
                        m = 0;
                        ++k;
                    }
                    P[i, j] = double.Parse(vertixesDgv.Rows[k].Cells[m++].Value.ToString());
                }
                ++k;
            }

            k = 0;
            for (int i = 0; i < P.Rows / 2; ++i)
            {
                int m = 0;
                for (int j = P.Columns / 2; j < P.Columns; ++j)
                {
                    if (m == wVectorsDgv.ColumnCount)
                    {
                        m = 0;
                        ++k;
                    }
                    P[i, j] = double.Parse(wVectorsDgv.Rows[k].Cells[m++].Value.ToString());
                }
                ++k;
            }

            k = 0;
            for (int i = P.Rows / 2; i < P.Rows; ++i)
            {
                int m = 0;
                for (int j = 0; j < P.Columns / 2; ++j)
                {
                    if (m == uVectorsDgv.ColumnCount)
                    {
                        m = 0;
                        ++k;
                    }
                    P[i, j] = double.Parse(uVectorsDgv.Rows[k].Cells[m++].Value.ToString());
                }
                ++k;
            }

            k = 0;
            for (int i = P.Rows / 2; i < P.Rows; ++i)
            {
                int m = 0;
                for (int j = P.Columns / 2; j < P.Columns; ++j)
                {
                    if (m == vectorsOfCurvatureDgv.ColumnCount)
                    {
                        m = 0;
                        ++k;
                    }
                    P[i, j] = double.Parse(vectorsOfCurvatureDgv.Rows[k].Cells[m++].Value.ToString());
                }
                ++k;
            }
            return P;
        }

        private void DrawLine(List<Matrix> verticesLine)
        {
            chartBicubicSurface.Series.Add(chartBicubicSurface.Series.NextUniqueName());
            int seriesCount = chartBicubicSurface.Series.Count - 1;
            chartBicubicSurface.Series[seriesCount].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < verticesLine.Count; ++i) 
            {
                if (xIsNullBtn.Checked)
                {
                    chartBicubicSurface.Series[seriesCount].Points.AddXY(verticesLine[i][0, 1], verticesLine[i][0, 2]);
                }
                else if (yIsNullBtn.Checked)
                {
                    chartBicubicSurface.Series[seriesCount].Points.AddXY(verticesLine[i][0, 0], verticesLine[i][0, 2]);
                }
                else
                {
                    chartBicubicSurface.Series[seriesCount].Points.AddXY(verticesLine[i][0, 0], verticesLine[i][0, 1]);
                }
            }
        }

        private void DrawBicubicSurface()
        {
            List<Matrix> verticesVerticalLine = new List<Matrix>();
            List<Matrix> verticesHorizontalLine = new List<Matrix>();

            double step = 0.04;
            for (double i = 0; i < 1; i += step)
            {
                verticesVerticalLine.Clear();
                verticesHorizontalLine.Clear();
                for (double j = 0; j < 1; j += step)
                {
                    bicubicSurface.SetUAndW(i, j);
                    verticesVerticalLine.Add(bicubicSurface.CalculateCoordinate() * projection.MatrixOfProjection);

                    bicubicSurface.SetUAndW(j, i);
                    verticesHorizontalLine.Add(bicubicSurface.CalculateCoordinate() * projection.MatrixOfProjection);
                }
                DrawLine(verticesVerticalLine);
                DrawLine(verticesHorizontalLine);
            }
        }

        private void CalculateBtn_Click(object sender, System.EventArgs e)
        {
            Matrix p = CreateMatrixP();

            bicubicSurface = new BicubicSurface(p);
            projection = new Projection();

            if (xIsNullBtn.Checked)
            {
                projection.CreateMatrixOfProjectionOnXEqualsNull(-30, 25);
            }
            else if (yIsNullBtn.Checked)
            {
                projection.CreateMatrixOfProjectionOnYEqualsNull(-30, 25);
            }
            else
            {
                projection.CreateMatrixOfProjectionOnZEqualsNull(-30, 25);
            }
            chartBicubicSurface.Series.Clear();
            DrawBicubicSurface();
        }
    }
}
