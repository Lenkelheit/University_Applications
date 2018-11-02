using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Statistics
{
    public partial class FormStatistics : Form
    {
        // CONST
        private const int ROWS_QUANTITY = 2;

        // FIELDS
        private Dictionary<double, int> frequencyTable;
        private Dictionary<double, int> copydiscretefrequencyTable;
        private List<double> variationSeries;

        // CONSTRUCTOR
        public FormStatistics()
        {
            InitializeComponent();

            frequencyTable = new Dictionary<double, int>();
            copydiscretefrequencyTable = new Dictionary<double, int>();
            variationSeries = new List<double>();
            labelMoment.Text = "\u03BC";
            labelAlpha.Text = "\u03B1";
        }

        // METHODS
        #region Numerical characteristics

        #region The central trend
        private double CalculateMedian()
        {
            int indexMedian = variationSeries.Count / 2;
            double median = 0;
            if (variationSeries.Count % 2 == 0)
            {
                median = (variationSeries[indexMedian - 1] + variationSeries[indexMedian]) / 2.0;
            }
            else
            {
                median = variationSeries[indexMedian];
            }
            return median;
        }

        private double[] CalculateModa()
        {
            int max = frequencyTable.Max(pair => pair.Value);
            return frequencyTable.Where(pair => pair.Value == max).Select(pair => pair.Key).ToArray();
        }

        private double CalculateAverageValue()
        {
            return variationSeries.Average();
        }

        #endregion

        #region Scattering statistics
        private double CalculateDeviation(double average)
        {
            return variationSeries.Sum(first => Math.Pow(first - average, 2));
        }

        private double CalculateVariance(double deviation)
        {
            return deviation / (variationSeries.Count - 1);
        }

        private double CalculateStandart(double variance)
        {
            return Math.Sqrt(variance);
        }

        private double CalculateSampleRange()
        {
            return variationSeries.Last() - variationSeries.First();
        }

        private double CalculateVariation(double standart, double average)
        {
            return standart / average;
        }
        #endregion

        #region Interquintilly latitude
        private double? CalculateQuantile(double order)
        {
            int maxPercent = 100;
            double remainder = order * variationSeries.Count % maxPercent;
            return (remainder == 0) ?
                (double?)variationSeries[(int)(order * variationSeries.Count / maxPercent - 1)] : null;
        }
        #endregion

        #region Moments
        private double CalculateMoment(double a, int order)
        {
            return variationSeries.Sum(elem => Math.Pow(elem - a, order)) / variationSeries.Count;
        }
        #endregion

        #region Forms statistics
        private double CalculateAsymmetry(double centralM3, double centralM2)
        {
            return centralM3 / Math.Pow(centralM2, 1.5);
        }
        private double CalculateExcess(double centralM4, double centralM2)
        {
            return centralM4 / Math.Pow(centralM2, 2) - 3;
        }
        #endregion

        #endregion

        private void CreateFrequencyTable()
        {
            foreach (int elem in variationSeries)
            {
                if (!frequencyTable.ContainsKey(elem))
                {
                    frequencyTable.Add(elem, 1);
                }
                else
                {
                    ++frequencyTable[elem];
                }
            }
        }

        private void DrawFrequencyTable()
        {
            var listFrequency = frequencyTable.ToList();
            dataGridViewFrequencyTable.Columns.Clear();
            for (int i = 0; i < listFrequency.Count + 2; ++i)
            {
                dataGridViewFrequencyTable.Columns.Add(i.ToString(), i.ToString());
            }

            dataGridViewFrequencyTable.Rows.Add(ROWS_QUANTITY);
            for (int i = 0; i < listFrequency.Count + 1; ++i)
            {
                dataGridViewFrequencyTable.Rows[0].Cells[i].Value = i == 0 ? "x" : listFrequency[i - 1].Key.ToString();
                dataGridViewFrequencyTable.Rows[1].Cells[i].Value = i == 0 ? "n" : listFrequency[i - 1].Value.ToString();
            }

            // sum symbol 
            dataGridViewFrequencyTable.Rows[0].Cells[listFrequency.Count + 1].Value = (char)8721;
            dataGridViewFrequencyTable.Rows[1].Cells[listFrequency.Count + 1].Value = variationSeries.Count;
        }

        private string GetFilePathForSaving()
        {
            string filePath = "";
            using (saveFileDialog)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                }
            }
            return filePath;
        }

        private void UpdateTextBoxWithVariationSeries()
        {
            textBoxVariationSeries.Text = "";

            foreach (var elem in variationSeries)
            {
                textBoxVariationSeries.Text += elem + " ";
            }
        }

        private void buttonGenerateSample_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathForSaving();
            if (filePath != "")
            {
                variationSeries.Clear();
                frequencyTable.Clear();
                textBoxSample.Text = "";
                textBoxVariationSeries.Text = "";
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    Random rand = new Random();
                    for (int i = 0; i < numericSampleSize.Value; ++i)
                    {
                        int sampleElem = rand.Next((int)numericStartInterval.Value, (int)numericFinishInterval.Value + 1);
                        streamWriter.Write($"{sampleElem} ");
                        variationSeries.Add(sampleElem);
                        textBoxSample.Text += sampleElem + " ";
                    }
                }
                UpdateAllDiscrete();
            }
        }

        private void textBoxSample_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSample.Text == "")
            {
                buttonUpdateSample.Enabled = false;
            }
            else
            {
                buttonUpdateSample.Enabled = true;
            }
        }

        private void UpdateAllDiscrete()
        {
            variationSeries.Sort();
            UpdateTextBoxWithVariationSeries();
            CreateFrequencyTable();
            DrawFrequencyTable();
            UpdateNumericalCharacteristics();
            DrawFrequencyHistogramAndRangeAndDistributionFunction(isDiscrete: true);
        }

        private void LoadSampleFromLine(string line, bool isChangesTextBox)
        {
            variationSeries.Clear();
            frequencyTable.Clear();

            string[] series = line.Trim().Split();
            double elem = 0;
            for (int i = 0; i < series.Length; ++i)
            {
                elem = double.Parse(series[i]);
                variationSeries.Add(elem);
                if (isChangesTextBox)
                {
                    textBoxSample.Text += elem + " ";
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            using (openFileDialog)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
            if (filePath != "")
            {
                textBoxSample.Text = "";
                string line = "";
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    line = streamReader.ReadToEnd();
                }
                LoadSampleFromLine(line, isChangesTextBox: true);
            }
        }

        private void numericStartInterval_ValueChanged(object sender, EventArgs e)
        {
            if (numericStartInterval.Value > numericFinishInterval.Value)
            {
                numericFinishInterval.Value = numericStartInterval.Value;
            }
        }

        private void numericFinishInterval_ValueChanged(object sender, EventArgs e)
        {
            if (numericStartInterval.Value > numericFinishInterval.Value)
            {
                numericStartInterval.Value = numericFinishInterval.Value;
            }
        }

        private double LoadUninterruptedSample(ref Dictionary<double, int> someFrequencyTable)
        {
            LoadSampleFromLine(textBoxSample.Text, isChangesTextBox: false);
            variationSeries.Sort();
            CreateFrequencyTable();

            int classesQuantity = (int)Math.Ceiling(Math.Log(variationSeries.Count, 2));
            double sampleRange = variationSeries.Last() - variationSeries.First();
            double step = sampleRange / classesQuantity;

            int elemCount = variationSeries.Count;
            Dictionary<double, int> uninterruptedFrequencyTable = new Dictionary<double, int>();

            var listFrequency = frequencyTable.ToList();
            double elemStartRange = listFrequency.First().Key, elemEndRange = listFrequency.First().Key + step;
            int elemQuantity = 0;
            for (int i = 0; i < listFrequency.Count; ++i) 
            {
                if (elemEndRange <= listFrequency[i].Key || i == listFrequency.Count - 1) 
                {
                    if (i == listFrequency.Count - 1)
                    {
                        elemQuantity += listFrequency[i].Value;
                        ++i;
                    }
                    uninterruptedFrequencyTable.Add((elemStartRange + elemEndRange) / 2, elemQuantity);
                    elemStartRange = elemEndRange;
                    elemEndRange += step;
                    elemQuantity = 0;
                    --i;
                }
                else
                {
                    elemQuantity += listFrequency[i].Value;
                }
            }
            someFrequencyTable = uninterruptedFrequencyTable;
            return step;
        }

        private void UpdateVariationSeries(double step)
        {
            variationSeries.Clear();
            foreach (var elem in frequencyTable)
            {
                for (int i = 0; i < elem.Value; ++i)
                {
                    variationSeries.Add(elem.Key);
                }
            }

            textBoxVariationSeries.Text = "";
            UpdateAllUninterrupted(step);
        }

        void UpdateAllUninterrupted(double step)
        {
            UpdateTextBoxWithVariationSeries();
            DrawFrequencyTable();
            UpdateNumericalCharacteristics();
            DrawFrequencyHistogramAndRangeAndDistributionFunction(isDiscrete: false, step: step);
        }

        private void buttonUpdateSample_Click(object sender, EventArgs e)
        {
            if (textBoxSample.Text != "")
            {
                if (radioButtonDiscrete.Checked) 
                {
                    LoadSampleFromLine(textBoxSample.Text, isChangesTextBox: false);
                    UpdateAllDiscrete();
                }
                else
                {
                    double step = LoadUninterruptedSample(ref frequencyTable);
                    UpdateVariationSeries(step);
                }
            }
        }

        private void DrawFrequencyHistogram(bool isDiscrete, double step = 0)
        {
            if (!isDiscrete)
            {
                chartFrequencyHistogram.ChartAreas[0].AxisX.Minimum = frequencyTable.First().Key - step / 2;
                chartFrequencyHistogram.ChartAreas[0].AxisX.Maximum = frequencyTable.Last().Key + step / 2;
                chartFrequencyHistogram.ChartAreas[0].AxisX.Interval = step;
                chartFrequencyHistogram.ChartAreas[0].AxisX.IntervalOffset = 0;
            }
            else
            {
                chartFrequencyHistogram.ChartAreas[0].AxisX.Minimum = double.NaN;
                chartFrequencyHistogram.ChartAreas[0].AxisX.Maximum = double.NaN;
                chartFrequencyHistogram.ChartAreas[0].AxisX.Interval = double.NaN;
                chartFrequencyHistogram.ChartAreas[0].AxisX.IntervalOffset = double.NaN;
            }
            foreach (var elem in frequencyTable)
            {
                chartFrequencyHistogram.Series[0].Points.AddXY(elem.Key, elem.Value);
            }
        }

        private void DrawFrequencyHistogramAndRangeAndDistributionFunction(bool isDiscrete, double step = 0)
        {
            chartFrequencyHistogram.Series[0].Points.Clear();
            chartFrequencyRange.Series[0].Points.Clear();
            chartDistributionFunction.Series[0].Points.Clear();

            double k = 0.1;
            chartDistributionFunction.ChartAreas[0].AxisY.Minimum = -k;
            chartDistributionFunction.ChartAreas[0].AxisY.Maximum = 1 + k;

            double min = frequencyTable.First().Key - 3;
            chartDistributionFunction.ChartAreas[0].AxisX.Minimum = min;
            chartDistributionFunction.Series[0].Points.AddXY(min, 0);

            DrawFrequencyHistogram(isDiscrete, step);

            int value = 0;
            foreach (var elem in frequencyTable)
            {
                chartFrequencyRange.Series[0].Points.AddXY(elem.Key, elem.Value);

                value += elem.Value;
                chartDistributionFunction.Series[0].Points.AddXY(elem.Key, (double)value / variationSeries.Count);
            }
            double max = frequencyTable.Last().Key + 3;
            chartDistributionFunction.ChartAreas[0].AxisX.Maximum = max;
            chartDistributionFunction.Series[0].Points.AddXY(max, 1);
        }

        private void UpdateNumericalCharacteristics()
        {
            labelMedianValue.Text = CalculateMedian().ToString();

            labelModaValue.Text = "";
            double[] modas = CalculateModa();
            foreach (double elem in modas)
            {
                labelModaValue.Text += elem + " ";
            }

            double average = CalculateAverageValue();
            labelAverageValue.Text = average.ToString();

            double deviation = CalculateDeviation(average);
            labelDeviationValue.Text = deviation.ToString();

            double variance = CalculateVariance(deviation);
            labelVarianceValue.Text = variance.ToString();

            double standart = CalculateStandart(variance);
            labelStandartValue.Text = standart.ToString();

            labelSampleRangeValue.Text = CalculateSampleRange().ToString();

            labelVariationValue.Text = CalculateVariation(standart, average).ToString();

            double a = 0;
            UpdatePrimaryMoments(a);

            a = average;
            UpdateCentralMoments(a);

            double centralM3 = double.Parse(labelCentralM3Value.Text);
            double centralM2 = double.Parse(labelCentralM2Value.Text);
            labelAsymmetryValue.Text = CalculateAsymmetry(centralM3, centralM2).ToString();

            double centralM4 = double.Parse(labelCentralM4Value.Text);
            labelExcessValue.Text = CalculateExcess(centralM4, centralM2).ToString();
        }
        private void UpdateLabelWithInterquintillyLatitude(Label label, double order)
        {
            double? quantileOfOrder = CalculateQuantile(order);
            if (quantileOfOrder.HasValue)
            {
                label.Text = quantileOfOrder.ToString();
            }
            else
            {
                label.Text = "\u2204";
            }
        }

        private void UpdateLabelByTextBox(TextBox textBox, Label label, double maxQuantile, double step)
        {
            if (textBox.Text != "")
            {
                double order = double.Parse(textBox.Text) * step;
                if (order > 0 && order <= maxQuantile)
                {
                    UpdateLabelWithInterquintillyLatitude(label, order);
                }
                else
                {
                    label.Text = "\u2204";
                }
            }
            else
            {
                label.Text = "\u2204";
            }
        }
        private void textBoxQuantile_TextChanged(object sender, EventArgs e)
        {
            int maxQuantile = 100, step = 1;
            UpdateLabelByTextBox(textBoxQuantile, labelQuantileValue, maxQuantile, step);
        }

        private void textBoxQuartile_TextChanged(object sender, EventArgs e)
        {
            int maxQuartile = 75, step = 25;
            UpdateLabelByTextBox(textBoxQuartile, labelQuartileValue, maxQuartile, step);
        }

        private void textBoxOctile_TextChanged(object sender, EventArgs e)
        {
            double maxOctile = 87.5, step = 12.5;
            UpdateLabelByTextBox(textBoxOctile, labelOctileValue, maxOctile, step);
        }

        private void textBoxDecile_TextChanged(object sender, EventArgs e)
        {
            int maxDecile = 90, step = 10;
            UpdateLabelByTextBox(textBoxDecile, labelDecileValue, maxDecile, step);
        }

        private void textBoxCentile_TextChanged(object sender, EventArgs e)
        {
            double maxCentile = 99, step = 1;
            UpdateLabelByTextBox(textBoxCentile, labelCentileValue, maxCentile, step);
        }

        private void textBoxMilile_TextChanged(object sender, EventArgs e)
        {
            double maxMilile = 99.9, step = 0.1;
            UpdateLabelByTextBox(textBoxMilile, labelMilileValue, maxMilile, step);
        }

        private void buttonCalculateMoment_Click(object sender, EventArgs e)
        {
            if (textBoxA.Text != "" && textBoxH.Text != "")
            {
                double a = double.Parse(textBoxA.Text);
                int h = int.Parse(textBoxH.Text);
                labelMomentValue.Text = CalculateMoment(a, h).ToString();
            }
        }

        private void UpdatePrimaryMoments(double a)
        {
            Label[] labelsMoment = new Label[]
            {
                       labelPrimaryM1Value, labelPrimaryM2Value,
                       labelPrimaryM3Value, labelPrimaryM4Value
            };
            for (int i = 0; i < labelsMoment.Length; ++i)
            {
                labelsMoment[i].Text = CalculateMoment(a, i + 1).ToString();
            }
        }

        private void UpdateCentralMoments(double a)
        {
            Label[] labelsMoment = new Label[]
            {
                       labelCentralM1Value, labelCentralM2Value,
                       labelCentralM3Value, labelCentralM4Value
            };
            labelsMoment[0].Text = "0";
            for (int i = 1; i < labelsMoment.Length; ++i) 
            {
                labelsMoment[i].Text = CalculateMoment(a, i + 1).ToString();
            }
        }

        private double CalculatePearsonCriterion(int classesQuantity)
        {
            double step = 0;
            List<KeyValuePair<double, int>> listFrequencyTable;

            Dictionary<double, int> uninterruptedFrequencyTable = new Dictionary<double, int>();
            step = LoadUninterruptedSample(ref uninterruptedFrequencyTable);
            listFrequencyTable = uninterruptedFrequencyTable.ToList();

            int j = 0;
            while (j != listFrequencyTable.Count)
            {
                if (listFrequencyTable[j].Value < 10)
                {
                    if (j != listFrequencyTable.Count - 1)
                    {
                        listFrequencyTable[j + 1] = new KeyValuePair<double, int>(((listFrequencyTable[j + 1].Key + listFrequencyTable[j].Key) / 2),
                            listFrequencyTable[j + 1].Value + listFrequencyTable[j].Value);
                        listFrequencyTable.RemoveAt(j);
                    }
                    else
                    {
                        listFrequencyTable[j - 1] = new KeyValuePair<double, int>(((listFrequencyTable[j - 1].Key + listFrequencyTable[j].Key) / 2),
                            listFrequencyTable[j - 1].Value + listFrequencyTable[j].Value);
                        listFrequencyTable.RemoveAt(j);
                    }
                    --j;
                }
                ++j;
            }
            int count = variationSeries.Count;
            double result = 0, probability = 0, elem = 0;
            for (int i = 0; i < listFrequencyTable.Count; ++i)  
            {
                elem = listFrequencyTable[i].Key;
                probability = CalculateProbability(elem, elem - step / 2, elem + step / 2);
                result += Math.Pow((listFrequencyTable[i].Value - count * probability), 2) / count * probability;
            }
            return result;
        }

        private double CalculateProbability(double elem, double a, double b)
        {
            if (elem >= a && elem <= b)
            {
                return 1 / (b - a);
            }
            else
            {
                return 0;
            }
        }

        private void buttonCalculatePearsonCriterion_Click(object sender, EventArgs e)
        {
            if (textBoxAlpha.Text != "")
            {
                if (variationSeries.Count >= 5) 
                {
                    double alpha = double.Parse(textBoxAlpha.Text);
                    int classesQuantity = (int)Math.Ceiling(Math.Log(variationSeries.Count, 2));
                    labelRValue.Text = (classesQuantity - 1).ToString();

                    double empiricX = CalculatePearsonCriterion(classesQuantity);
                    labelEmpiricXValue.Text = empiricX.ToString();

                    double criticalX = MathNet.Numerics.Distributions.ChiSquared.InvCDF(classesQuantity - 1, 1 - alpha);
                    labelCriticalXValue.Text = criticalX.ToString();

                    if (empiricX < criticalX)
                    {
                        labelIsAccepted.Text = "Так";
                    }
                    else
                    {
                        labelIsAccepted.Text = "Ні";
                    }
                }
                else
                {
                    MessageBox.Show("N < 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                labelIsAccepted.Text = "__";
            }

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string filePath = GetFilePathForSaving();
            if (filePath != "")
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.Write(textBoxSample.Text);
                }
            }
        }
    }
}
