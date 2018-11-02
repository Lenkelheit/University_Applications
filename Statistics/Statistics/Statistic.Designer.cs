namespace Statistics
{
    partial class FormStatistics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            this.dataGridViewFrequencyTable = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGenerateSample = new System.Windows.Forms.Button();
            this.numericSampleSize = new System.Windows.Forms.NumericUpDown();
            this.numericFinishInterval = new System.Windows.Forms.NumericUpDown();
            this.numericStartInterval = new System.Windows.Forms.NumericUpDown();
            this.labelStartInterval = new System.Windows.Forms.Label();
            this.labelFinishInterval = new System.Windows.Forms.Label();
            this.labelSampleSize = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.buttonUpdateSample = new System.Windows.Forms.Button();
            this.textBoxVariationSeries = new System.Windows.Forms.TextBox();
            this.chartFrequencyHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFrequencyRange = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistributionFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMedian = new System.Windows.Forms.Label();
            this.labelMedianValue = new System.Windows.Forms.Label();
            this.labelModaValue = new System.Windows.Forms.Label();
            this.labelModa = new System.Windows.Forms.Label();
            this.labelAverageValue = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelDeviationValue = new System.Windows.Forms.Label();
            this.labelDeviation = new System.Windows.Forms.Label();
            this.labelVarianceValue = new System.Windows.Forms.Label();
            this.labelVariance = new System.Windows.Forms.Label();
            this.labelStandartValue = new System.Windows.Forms.Label();
            this.labelStandart = new System.Windows.Forms.Label();
            this.labelSampleRangeValue = new System.Windows.Forms.Label();
            this.labelSampleRange = new System.Windows.Forms.Label();
            this.labelVariationValue = new System.Windows.Forms.Label();
            this.labelVariation = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTheCentralTrendStatistics = new System.Windows.Forms.TabPage();
            this.tabPageScatteringStatistics = new System.Windows.Forms.TabPage();
            this.tabPageInterquantileLatitude = new System.Windows.Forms.TabPage();
            this.textBoxMilile = new System.Windows.Forms.TextBox();
            this.labelMilileValue = new System.Windows.Forms.Label();
            this.labelMilile = new System.Windows.Forms.Label();
            this.textBoxCentile = new System.Windows.Forms.TextBox();
            this.labelCentileValue = new System.Windows.Forms.Label();
            this.labelCentile = new System.Windows.Forms.Label();
            this.textBoxOctile = new System.Windows.Forms.TextBox();
            this.labelOctileValue = new System.Windows.Forms.Label();
            this.labelOctile = new System.Windows.Forms.Label();
            this.textBoxDecile = new System.Windows.Forms.TextBox();
            this.labelDecileValue = new System.Windows.Forms.Label();
            this.labelDecile = new System.Windows.Forms.Label();
            this.textBoxQuartile = new System.Windows.Forms.TextBox();
            this.labelQuartileValue = new System.Windows.Forms.Label();
            this.labelQuartile = new System.Windows.Forms.Label();
            this.textBoxQuantile = new System.Windows.Forms.TextBox();
            this.labelQuantileValue = new System.Windows.Forms.Label();
            this.labelQuantile = new System.Windows.Forms.Label();
            this.tabPageMoment = new System.Windows.Forms.TabPage();
            this.labelCentralM3Value = new System.Windows.Forms.Label();
            this.labelCentralM3 = new System.Windows.Forms.Label();
            this.labelCentralM4Value = new System.Windows.Forms.Label();
            this.labelCentralM4 = new System.Windows.Forms.Label();
            this.labelCentralM2Value = new System.Windows.Forms.Label();
            this.labelCentralM2 = new System.Windows.Forms.Label();
            this.labelCentralM1Value = new System.Windows.Forms.Label();
            this.labelCentralM1 = new System.Windows.Forms.Label();
            this.labelPrimaryM3Value = new System.Windows.Forms.Label();
            this.labelPrimaryM3 = new System.Windows.Forms.Label();
            this.labelPrimaryM4Value = new System.Windows.Forms.Label();
            this.labelPrimaryM4 = new System.Windows.Forms.Label();
            this.labelPrimaryM2Value = new System.Windows.Forms.Label();
            this.labelPrimaryM2 = new System.Windows.Forms.Label();
            this.labelPrimaryM1Value = new System.Windows.Forms.Label();
            this.labelPrimaryM1 = new System.Windows.Forms.Label();
            this.labelMomentValue = new System.Windows.Forms.Label();
            this.buttonCalculateMoment = new System.Windows.Forms.Button();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelMoment = new System.Windows.Forms.Label();
            this.tabPageForm = new System.Windows.Forms.TabPage();
            this.labelExcessValue = new System.Windows.Forms.Label();
            this.labelAsymmetry = new System.Windows.Forms.Label();
            this.labelExcess = new System.Windows.Forms.Label();
            this.labelAsymmetryValue = new System.Windows.Forms.Label();
            this.labelPearsonCriterion = new System.Windows.Forms.Label();
            this.radioButtonDiscrete = new System.Windows.Forms.RadioButton();
            this.groupBoxVariableType = new System.Windows.Forms.GroupBox();
            this.radioButtonUninterrupted = new System.Windows.Forms.RadioButton();
            this.labelEmpiricX = new System.Windows.Forms.Label();
            this.labelEmpiricXValue = new System.Windows.Forms.Label();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelRValue = new System.Windows.Forms.Label();
            this.labelCriticalX = new System.Windows.Forms.Label();
            this.labelCriticalXValue = new System.Windows.Forms.Label();
            this.labelHypothesis = new System.Windows.Forms.Label();
            this.labelIsAccepted = new System.Windows.Forms.Label();
            this.buttonCalculatePearsonCriterion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrequencyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinishInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistributionFunction)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTheCentralTrendStatistics.SuspendLayout();
            this.tabPageScatteringStatistics.SuspendLayout();
            this.tabPageInterquantileLatitude.SuspendLayout();
            this.tabPageMoment.SuspendLayout();
            this.tabPageForm.SuspendLayout();
            this.groupBoxVariableType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFrequencyTable
            // 
            this.dataGridViewFrequencyTable.AllowUserToAddRows = false;
            this.dataGridViewFrequencyTable.AllowUserToDeleteRows = false;
            this.dataGridViewFrequencyTable.AllowUserToResizeColumns = false;
            this.dataGridViewFrequencyTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewFrequencyTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewFrequencyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFrequencyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFrequencyTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFrequencyTable.ColumnHeadersHeight = 25;
            this.dataGridViewFrequencyTable.ColumnHeadersVisible = false;
            this.dataGridViewFrequencyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title});
            this.dataGridViewFrequencyTable.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewFrequencyTable.Name = "dataGridViewFrequencyTable";
            this.dataGridViewFrequencyTable.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFrequencyTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewFrequencyTable.RowHeadersVisible = false;
            this.dataGridViewFrequencyTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewFrequencyTable.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewFrequencyTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewFrequencyTable.RowTemplate.Height = 23;
            this.dataGridViewFrequencyTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewFrequencyTable.Size = new System.Drawing.Size(667, 73);
            this.dataGridViewFrequencyTable.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.DefaultCellStyle = dataGridViewCellStyle22;
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonGenerateSample
            // 
            this.buttonGenerateSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateSample.Location = new System.Drawing.Point(831, 118);
            this.buttonGenerateSample.Name = "buttonGenerateSample";
            this.buttonGenerateSample.Size = new System.Drawing.Size(126, 43);
            this.buttonGenerateSample.TabIndex = 1;
            this.buttonGenerateSample.Text = "Згенерувати вибірку";
            this.buttonGenerateSample.UseVisualStyleBackColor = true;
            this.buttonGenerateSample.Click += new System.EventHandler(this.buttonGenerateSample_Click);
            // 
            // numericSampleSize
            // 
            this.numericSampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericSampleSize.Location = new System.Drawing.Point(869, 81);
            this.numericSampleSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericSampleSize.Name = "numericSampleSize";
            this.numericSampleSize.Size = new System.Drawing.Size(68, 26);
            this.numericSampleSize.TabIndex = 3;
            this.numericSampleSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericFinishInterval
            // 
            this.numericFinishInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericFinishInterval.Location = new System.Drawing.Point(780, 81);
            this.numericFinishInterval.Name = "numericFinishInterval";
            this.numericFinishInterval.Size = new System.Drawing.Size(68, 26);
            this.numericFinishInterval.TabIndex = 2;
            this.numericFinishInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFinishInterval.ValueChanged += new System.EventHandler(this.numericFinishInterval_ValueChanged);
            // 
            // numericStartInterval
            // 
            this.numericStartInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericStartInterval.Location = new System.Drawing.Point(692, 81);
            this.numericStartInterval.Name = "numericStartInterval";
            this.numericStartInterval.Size = new System.Drawing.Size(68, 26);
            this.numericStartInterval.TabIndex = 1;
            this.numericStartInterval.ValueChanged += new System.EventHandler(this.numericStartInterval_ValueChanged);
            // 
            // labelStartInterval
            // 
            this.labelStartInterval.AutoEllipsis = true;
            this.labelStartInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartInterval.Location = new System.Drawing.Point(689, 28);
            this.labelStartInterval.Name = "labelStartInterval";
            this.labelStartInterval.Size = new System.Drawing.Size(82, 40);
            this.labelStartInterval.TabIndex = 5;
            this.labelStartInterval.Text = "Початок інтервалу";
            this.labelStartInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFinishInterval
            // 
            this.labelFinishInterval.AutoEllipsis = true;
            this.labelFinishInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinishInterval.Location = new System.Drawing.Point(777, 28);
            this.labelFinishInterval.Name = "labelFinishInterval";
            this.labelFinishInterval.Size = new System.Drawing.Size(83, 42);
            this.labelFinishInterval.TabIndex = 6;
            this.labelFinishInterval.Text = "Кінець інтервалу";
            this.labelFinishInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSampleSize
            // 
            this.labelSampleSize.AutoEllipsis = true;
            this.labelSampleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleSize.Location = new System.Drawing.Point(866, 35);
            this.labelSampleSize.Name = "labelSampleSize";
            this.labelSampleSize.Size = new System.Drawing.Size(100, 26);
            this.labelSampleSize.TabIndex = 7;
            this.labelSampleSize.Text = "Об\'єм вибірки";
            this.labelSampleSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "file";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open file";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Save file";
            // 
            // textBoxSample
            // 
            this.textBoxSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSample.Location = new System.Drawing.Point(12, 27);
            this.textBoxSample.Multiline = true;
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxSample.Size = new System.Drawing.Size(667, 42);
            this.textBoxSample.TabIndex = 9;
            this.textBoxSample.Text = "Вибірка";
            this.textBoxSample.WordWrap = false;
            this.textBoxSample.TextChanged += new System.EventHandler(this.textBoxSample_TextChanged);
            // 
            // buttonUpdateSample
            // 
            this.buttonUpdateSample.Enabled = false;
            this.buttonUpdateSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateSample.Location = new System.Drawing.Point(692, 118);
            this.buttonUpdateSample.Name = "buttonUpdateSample";
            this.buttonUpdateSample.Size = new System.Drawing.Size(128, 43);
            this.buttonUpdateSample.TabIndex = 10;
            this.buttonUpdateSample.Text = "Оновити вибірку";
            this.buttonUpdateSample.UseVisualStyleBackColor = true;
            this.buttonUpdateSample.Click += new System.EventHandler(this.buttonUpdateSample_Click);
            // 
            // textBoxVariationSeries
            // 
            this.textBoxVariationSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVariationSeries.Location = new System.Drawing.Point(12, 75);
            this.textBoxVariationSeries.Multiline = true;
            this.textBoxVariationSeries.Name = "textBoxVariationSeries";
            this.textBoxVariationSeries.ReadOnly = true;
            this.textBoxVariationSeries.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxVariationSeries.Size = new System.Drawing.Size(667, 42);
            this.textBoxVariationSeries.TabIndex = 12;
            this.textBoxVariationSeries.Text = "Варіаційний ряд";
            this.textBoxVariationSeries.WordWrap = false;
            // 
            // chartFrequencyHistogram
            // 
            this.chartFrequencyHistogram.BorderlineColor = System.Drawing.Color.Black;
            this.chartFrequencyHistogram.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea16.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea16.AxisX.MaximumAutoSize = 65F;
            chartArea16.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea16.AxisX.ScaleBreakStyle.LineWidth = 5;
            chartArea16.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea16.AxisX.ScaleView.Size = 7D;
            chartArea16.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea16.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea16.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea16.AxisX.ScrollBar.Size = 20D;
            chartArea16.Name = "ChartAreaFrequencyHistogram";
            this.chartFrequencyHistogram.ChartAreas.Add(chartArea16);
            this.chartFrequencyHistogram.Location = new System.Drawing.Point(12, 200);
            this.chartFrequencyHistogram.Name = "chartFrequencyHistogram";
            series16.ChartArea = "ChartAreaFrequencyHistogram";
            series16.Name = "Frequency histogram";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series16.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFrequencyHistogram.Series.Add(series16);
            this.chartFrequencyHistogram.Size = new System.Drawing.Size(245, 259);
            this.chartFrequencyHistogram.TabIndex = 13;
            this.chartFrequencyHistogram.Text = "chartFrequencyHistogram";
            title16.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title16.Name = "titleFrequencyHistogram";
            title16.Text = "Гістограма";
            this.chartFrequencyHistogram.Titles.Add(title16);
            // 
            // chartFrequencyRange
            // 
            this.chartFrequencyRange.BorderlineColor = System.Drawing.Color.Black;
            this.chartFrequencyRange.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea17.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea17.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea17.AxisX.ScaleBreakStyle.LineWidth = 5;
            chartArea17.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea17.AxisX.ScaleView.Size = 7D;
            chartArea17.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea17.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea17.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea17.AxisX.ScrollBar.Size = 20D;
            chartArea17.Name = "ChartAreaFrequencyRange";
            this.chartFrequencyRange.ChartAreas.Add(chartArea17);
            this.chartFrequencyRange.Location = new System.Drawing.Point(263, 200);
            this.chartFrequencyRange.Name = "chartFrequencyRange";
            this.chartFrequencyRange.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartFrequencyRange.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series17.BorderWidth = 5;
            series17.ChartArea = "ChartAreaFrequencyRange";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Name = "Frequency range";
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series17.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFrequencyRange.Series.Add(series17);
            this.chartFrequencyRange.Size = new System.Drawing.Size(245, 259);
            this.chartFrequencyRange.TabIndex = 14;
            this.chartFrequencyRange.Text = "chartFrequencyRange";
            title17.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title17.Name = "titleFrequencyRange";
            title17.Text = "Полігон";
            this.chartFrequencyRange.Titles.Add(title17);
            // 
            // chartDistributionFunction
            // 
            this.chartDistributionFunction.BorderlineColor = System.Drawing.Color.Black;
            this.chartDistributionFunction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea18.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea18.AxisX.MajorGrid.Enabled = false;
            chartArea18.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea18.AxisX.ScaleBreakStyle.LineWidth = 5;
            chartArea18.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea18.AxisX.ScaleView.Size = 7D;
            chartArea18.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea18.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea18.AxisX.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea18.AxisX.ScrollBar.Size = 20D;
            chartArea18.AxisY.MajorGrid.Enabled = false;
            chartArea18.Name = "ChartAreaDistributionFunction";
            this.chartDistributionFunction.ChartAreas.Add(chartArea18);
            this.chartDistributionFunction.Location = new System.Drawing.Point(514, 200);
            this.chartDistributionFunction.Name = "chartDistributionFunction";
            this.chartDistributionFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartDistributionFunction.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green};
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartAreaDistributionFunction";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series18.Name = "Distribution function";
            series18.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series18.YValuesPerPoint = 6;
            series18.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDistributionFunction.Series.Add(series18);
            this.chartDistributionFunction.Size = new System.Drawing.Size(245, 259);
            this.chartDistributionFunction.TabIndex = 15;
            this.chartDistributionFunction.Text = "chartDistributionFunction";
            title18.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title18.Name = "titleDistributionFunction";
            title18.Text = "Емпірична функція розподілу";
            this.chartDistributionFunction.Titles.Add(title18);
            // 
            // labelMedian
            // 
            this.labelMedian.AutoSize = true;
            this.labelMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedian.Location = new System.Drawing.Point(17, 27);
            this.labelMedian.Name = "labelMedian";
            this.labelMedian.Size = new System.Drawing.Size(68, 16);
            this.labelMedian.TabIndex = 17;
            this.labelMedian.Text = "Медіана: ";
            // 
            // labelMedianValue
            // 
            this.labelMedianValue.AutoSize = true;
            this.labelMedianValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedianValue.Location = new System.Drawing.Point(102, 27);
            this.labelMedianValue.Name = "labelMedianValue";
            this.labelMedianValue.Size = new System.Drawing.Size(15, 16);
            this.labelMedianValue.TabIndex = 18;
            this.labelMedianValue.Text = "0";
            // 
            // labelModaValue
            // 
            this.labelModaValue.AutoSize = true;
            this.labelModaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModaValue.Location = new System.Drawing.Point(102, 59);
            this.labelModaValue.Name = "labelModaValue";
            this.labelModaValue.Size = new System.Drawing.Size(15, 16);
            this.labelModaValue.TabIndex = 20;
            this.labelModaValue.Text = "0";
            // 
            // labelModa
            // 
            this.labelModa.AutoSize = true;
            this.labelModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModa.Location = new System.Drawing.Point(17, 59);
            this.labelModa.Name = "labelModa";
            this.labelModa.Size = new System.Drawing.Size(46, 16);
            this.labelModa.TabIndex = 19;
            this.labelModa.Text = "Мода:";
            // 
            // labelAverageValue
            // 
            this.labelAverageValue.AutoSize = true;
            this.labelAverageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverageValue.Location = new System.Drawing.Point(185, 95);
            this.labelAverageValue.Name = "labelAverageValue";
            this.labelAverageValue.Size = new System.Drawing.Size(15, 16);
            this.labelAverageValue.TabIndex = 22;
            this.labelAverageValue.Text = "0";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAverage.Location = new System.Drawing.Point(17, 95);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(162, 16);
            this.labelAverage.TabIndex = 21;
            this.labelAverage.Text = "Середнє арифметичне:";
            // 
            // labelDeviationValue
            // 
            this.labelDeviationValue.AutoSize = true;
            this.labelDeviationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeviationValue.Location = new System.Drawing.Point(102, 32);
            this.labelDeviationValue.Name = "labelDeviationValue";
            this.labelDeviationValue.Size = new System.Drawing.Size(15, 16);
            this.labelDeviationValue.TabIndex = 24;
            this.labelDeviationValue.Text = "0";
            // 
            // labelDeviation
            // 
            this.labelDeviation.AutoSize = true;
            this.labelDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeviation.Location = new System.Drawing.Point(17, 32);
            this.labelDeviation.Name = "labelDeviation";
            this.labelDeviation.Size = new System.Drawing.Size(65, 16);
            this.labelDeviation.TabIndex = 23;
            this.labelDeviation.Text = "Девіація:";
            // 
            // labelVarianceValue
            // 
            this.labelVarianceValue.AutoSize = true;
            this.labelVarianceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVarianceValue.Location = new System.Drawing.Point(102, 77);
            this.labelVarianceValue.Name = "labelVarianceValue";
            this.labelVarianceValue.Size = new System.Drawing.Size(15, 16);
            this.labelVarianceValue.TabIndex = 27;
            this.labelVarianceValue.Text = "0";
            // 
            // labelVariance
            // 
            this.labelVariance.AutoSize = true;
            this.labelVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariance.Location = new System.Drawing.Point(17, 77);
            this.labelVariance.Name = "labelVariance";
            this.labelVariance.Size = new System.Drawing.Size(70, 16);
            this.labelVariance.TabIndex = 26;
            this.labelVariance.Text = "Варіанса:";
            // 
            // labelStandartValue
            // 
            this.labelStandartValue.AutoSize = true;
            this.labelStandartValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStandartValue.Location = new System.Drawing.Point(102, 123);
            this.labelStandartValue.Name = "labelStandartValue";
            this.labelStandartValue.Size = new System.Drawing.Size(15, 16);
            this.labelStandartValue.TabIndex = 29;
            this.labelStandartValue.Text = "0";
            // 
            // labelStandart
            // 
            this.labelStandart.AutoSize = true;
            this.labelStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStandart.Location = new System.Drawing.Point(17, 123);
            this.labelStandart.Name = "labelStandart";
            this.labelStandart.Size = new System.Drawing.Size(74, 16);
            this.labelStandart.TabIndex = 28;
            this.labelStandart.Text = "Стандарт:";
            // 
            // labelSampleRangeValue
            // 
            this.labelSampleRangeValue.AutoSize = true;
            this.labelSampleRangeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleRangeValue.Location = new System.Drawing.Point(312, 32);
            this.labelSampleRangeValue.Name = "labelSampleRangeValue";
            this.labelSampleRangeValue.Size = new System.Drawing.Size(15, 16);
            this.labelSampleRangeValue.TabIndex = 31;
            this.labelSampleRangeValue.Text = "0";
            // 
            // labelSampleRange
            // 
            this.labelSampleRange.AutoSize = true;
            this.labelSampleRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSampleRange.Location = new System.Drawing.Point(227, 32);
            this.labelSampleRange.Name = "labelSampleRange";
            this.labelSampleRange.Size = new System.Drawing.Size(59, 16);
            this.labelSampleRange.TabIndex = 30;
            this.labelSampleRange.Text = "Розмах:";
            // 
            // labelVariationValue
            // 
            this.labelVariationValue.AutoSize = true;
            this.labelVariationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariationValue.Location = new System.Drawing.Point(312, 77);
            this.labelVariationValue.Name = "labelVariationValue";
            this.labelVariationValue.Size = new System.Drawing.Size(15, 16);
            this.labelVariationValue.TabIndex = 33;
            this.labelVariationValue.Text = "0";
            // 
            // labelVariation
            // 
            this.labelVariation.AutoSize = true;
            this.labelVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariation.Location = new System.Drawing.Point(227, 77);
            this.labelVariation.Name = "labelVariation";
            this.labelVariation.Size = new System.Drawing.Size(65, 16);
            this.labelVariation.TabIndex = 32;
            this.labelVariation.Text = "Варіація:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(968, 24);
            this.menuStrip.TabIndex = 34;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPageTheCentralTrendStatistics);
            this.tabControl.Controls.Add(this.tabPageScatteringStatistics);
            this.tabControl.Controls.Add(this.tabPageInterquantileLatitude);
            this.tabControl.Controls.Add(this.tabPageMoment);
            this.tabControl.Controls.Add(this.tabPageForm);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(12, 475);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(460, 231);
            this.tabControl.TabIndex = 35;
            // 
            // tabPageTheCentralTrendStatistics
            // 
            this.tabPageTheCentralTrendStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelModa);
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelMedian);
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelMedianValue);
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelModaValue);
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelAverage);
            this.tabPageTheCentralTrendStatistics.Controls.Add(this.labelAverageValue);
            this.tabPageTheCentralTrendStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageTheCentralTrendStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPageTheCentralTrendStatistics.Name = "tabPageTheCentralTrendStatistics";
            this.tabPageTheCentralTrendStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheCentralTrendStatistics.Size = new System.Drawing.Size(452, 202);
            this.tabPageTheCentralTrendStatistics.TabIndex = 0;
            this.tabPageTheCentralTrendStatistics.Text = "Центральна тенденція";
            // 
            // tabPageScatteringStatistics
            // 
            this.tabPageScatteringStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageScatteringStatistics.Controls.Add(this.labelStandart);
            this.tabPageScatteringStatistics.Controls.Add(this.labelVariationValue);
            this.tabPageScatteringStatistics.Controls.Add(this.labelDeviation);
            this.tabPageScatteringStatistics.Controls.Add(this.labelVariation);
            this.tabPageScatteringStatistics.Controls.Add(this.labelDeviationValue);
            this.tabPageScatteringStatistics.Controls.Add(this.labelSampleRangeValue);
            this.tabPageScatteringStatistics.Controls.Add(this.labelVariance);
            this.tabPageScatteringStatistics.Controls.Add(this.labelSampleRange);
            this.tabPageScatteringStatistics.Controls.Add(this.labelVarianceValue);
            this.tabPageScatteringStatistics.Controls.Add(this.labelStandartValue);
            this.tabPageScatteringStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageScatteringStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPageScatteringStatistics.Name = "tabPageScatteringStatistics";
            this.tabPageScatteringStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScatteringStatistics.Size = new System.Drawing.Size(452, 202);
            this.tabPageScatteringStatistics.TabIndex = 1;
            this.tabPageScatteringStatistics.Text = "Розсіювання";
            // 
            // tabPageInterquantileLatitude
            // 
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxMilile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelMilileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelMilile);
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxCentile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelCentileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelCentile);
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxOctile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelOctileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelOctile);
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxDecile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelDecileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelDecile);
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxQuartile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelQuartileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelQuartile);
            this.tabPageInterquantileLatitude.Controls.Add(this.textBoxQuantile);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelQuantileValue);
            this.tabPageInterquantileLatitude.Controls.Add(this.labelQuantile);
            this.tabPageInterquantileLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageInterquantileLatitude.Location = new System.Drawing.Point(4, 25);
            this.tabPageInterquantileLatitude.Name = "tabPageInterquantileLatitude";
            this.tabPageInterquantileLatitude.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterquantileLatitude.Size = new System.Drawing.Size(452, 202);
            this.tabPageInterquantileLatitude.TabIndex = 2;
            this.tabPageInterquantileLatitude.Text = "Інтерквантильні широти";
            this.tabPageInterquantileLatitude.UseVisualStyleBackColor = true;
            // 
            // textBoxMilile
            // 
            this.textBoxMilile.Location = new System.Drawing.Point(301, 118);
            this.textBoxMilile.Name = "textBoxMilile";
            this.textBoxMilile.Size = new System.Drawing.Size(63, 21);
            this.textBoxMilile.TabIndex = 53;
            this.textBoxMilile.TextChanged += new System.EventHandler(this.textBoxMilile_TextChanged);
            // 
            // labelMilileValue
            // 
            this.labelMilileValue.AutoSize = true;
            this.labelMilileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMilileValue.Location = new System.Drawing.Point(381, 114);
            this.labelMilileValue.Name = "labelMilileValue";
            this.labelMilileValue.Size = new System.Drawing.Size(24, 25);
            this.labelMilileValue.TabIndex = 52;
            this.labelMilileValue.Text = "0";
            // 
            // labelMilile
            // 
            this.labelMilile.AutoSize = true;
            this.labelMilile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMilile.Location = new System.Drawing.Point(222, 121);
            this.labelMilile.Name = "labelMilile";
            this.labelMilile.Size = new System.Drawing.Size(51, 16);
            this.labelMilile.TabIndex = 51;
            this.labelMilile.Text = "Міліль:";
            // 
            // textBoxCentile
            // 
            this.textBoxCentile.Location = new System.Drawing.Point(301, 72);
            this.textBoxCentile.Name = "textBoxCentile";
            this.textBoxCentile.Size = new System.Drawing.Size(63, 21);
            this.textBoxCentile.TabIndex = 50;
            this.textBoxCentile.TextChanged += new System.EventHandler(this.textBoxCentile_TextChanged);
            // 
            // labelCentileValue
            // 
            this.labelCentileValue.AutoSize = true;
            this.labelCentileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentileValue.Location = new System.Drawing.Point(381, 68);
            this.labelCentileValue.Name = "labelCentileValue";
            this.labelCentileValue.Size = new System.Drawing.Size(24, 25);
            this.labelCentileValue.TabIndex = 49;
            this.labelCentileValue.Text = "0";
            // 
            // labelCentile
            // 
            this.labelCentile.AutoSize = true;
            this.labelCentile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentile.Location = new System.Drawing.Point(222, 75);
            this.labelCentile.Name = "labelCentile";
            this.labelCentile.Size = new System.Drawing.Size(66, 16);
            this.labelCentile.TabIndex = 48;
            this.labelCentile.Text = "Центиль:";
            // 
            // textBoxOctile
            // 
            this.textBoxOctile.Location = new System.Drawing.Point(95, 116);
            this.textBoxOctile.Name = "textBoxOctile";
            this.textBoxOctile.Size = new System.Drawing.Size(63, 21);
            this.textBoxOctile.TabIndex = 47;
            this.textBoxOctile.TextChanged += new System.EventHandler(this.textBoxOctile_TextChanged);
            // 
            // labelOctileValue
            // 
            this.labelOctileValue.AutoSize = true;
            this.labelOctileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOctileValue.Location = new System.Drawing.Point(175, 112);
            this.labelOctileValue.Name = "labelOctileValue";
            this.labelOctileValue.Size = new System.Drawing.Size(24, 25);
            this.labelOctileValue.TabIndex = 46;
            this.labelOctileValue.Text = "0";
            // 
            // labelOctile
            // 
            this.labelOctile.AutoSize = true;
            this.labelOctile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOctile.Location = new System.Drawing.Point(16, 119);
            this.labelOctile.Name = "labelOctile";
            this.labelOctile.Size = new System.Drawing.Size(58, 16);
            this.labelOctile.TabIndex = 45;
            this.labelOctile.Text = "Октиль:";
            // 
            // textBoxDecile
            // 
            this.textBoxDecile.Location = new System.Drawing.Point(301, 22);
            this.textBoxDecile.Name = "textBoxDecile";
            this.textBoxDecile.Size = new System.Drawing.Size(63, 21);
            this.textBoxDecile.TabIndex = 44;
            this.textBoxDecile.TextChanged += new System.EventHandler(this.textBoxDecile_TextChanged);
            // 
            // labelDecileValue
            // 
            this.labelDecileValue.AutoSize = true;
            this.labelDecileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecileValue.Location = new System.Drawing.Point(381, 18);
            this.labelDecileValue.Name = "labelDecileValue";
            this.labelDecileValue.Size = new System.Drawing.Size(24, 25);
            this.labelDecileValue.TabIndex = 43;
            this.labelDecileValue.Text = "0";
            // 
            // labelDecile
            // 
            this.labelDecile.AutoSize = true;
            this.labelDecile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecile.Location = new System.Drawing.Point(222, 25);
            this.labelDecile.Name = "labelDecile";
            this.labelDecile.Size = new System.Drawing.Size(59, 16);
            this.labelDecile.TabIndex = 42;
            this.labelDecile.Text = "Дециль:";
            // 
            // textBoxQuartile
            // 
            this.textBoxQuartile.Location = new System.Drawing.Point(95, 72);
            this.textBoxQuartile.Name = "textBoxQuartile";
            this.textBoxQuartile.Size = new System.Drawing.Size(63, 21);
            this.textBoxQuartile.TabIndex = 41;
            this.textBoxQuartile.TextChanged += new System.EventHandler(this.textBoxQuartile_TextChanged);
            // 
            // labelQuartileValue
            // 
            this.labelQuartileValue.AutoSize = true;
            this.labelQuartileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuartileValue.Location = new System.Drawing.Point(175, 68);
            this.labelQuartileValue.Name = "labelQuartileValue";
            this.labelQuartileValue.Size = new System.Drawing.Size(24, 25);
            this.labelQuartileValue.TabIndex = 40;
            this.labelQuartileValue.Text = "0";
            // 
            // labelQuartile
            // 
            this.labelQuartile.AutoSize = true;
            this.labelQuartile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuartile.Location = new System.Drawing.Point(16, 75);
            this.labelQuartile.Name = "labelQuartile";
            this.labelQuartile.Size = new System.Drawing.Size(73, 16);
            this.labelQuartile.TabIndex = 39;
            this.labelQuartile.Text = "Квартиль:";
            // 
            // textBoxQuantile
            // 
            this.textBoxQuantile.Location = new System.Drawing.Point(95, 25);
            this.textBoxQuantile.Name = "textBoxQuantile";
            this.textBoxQuantile.Size = new System.Drawing.Size(63, 21);
            this.textBoxQuantile.TabIndex = 38;
            this.textBoxQuantile.TextChanged += new System.EventHandler(this.textBoxQuantile_TextChanged);
            // 
            // labelQuantileValue
            // 
            this.labelQuantileValue.AutoSize = true;
            this.labelQuantileValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantileValue.Location = new System.Drawing.Point(175, 21);
            this.labelQuantileValue.Name = "labelQuantileValue";
            this.labelQuantileValue.Size = new System.Drawing.Size(24, 25);
            this.labelQuantileValue.TabIndex = 37;
            this.labelQuantileValue.Text = "0";
            // 
            // labelQuantile
            // 
            this.labelQuantile.AutoSize = true;
            this.labelQuantile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantile.Location = new System.Drawing.Point(16, 28);
            this.labelQuantile.Name = "labelQuantile";
            this.labelQuantile.Size = new System.Drawing.Size(73, 16);
            this.labelQuantile.TabIndex = 36;
            this.labelQuantile.Text = "Квантиль:";
            // 
            // tabPageMoment
            // 
            this.tabPageMoment.Controls.Add(this.labelCentralM3Value);
            this.tabPageMoment.Controls.Add(this.labelCentralM3);
            this.tabPageMoment.Controls.Add(this.labelCentralM4Value);
            this.tabPageMoment.Controls.Add(this.labelCentralM4);
            this.tabPageMoment.Controls.Add(this.labelCentralM2Value);
            this.tabPageMoment.Controls.Add(this.labelCentralM2);
            this.tabPageMoment.Controls.Add(this.labelCentralM1Value);
            this.tabPageMoment.Controls.Add(this.labelCentralM1);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM3Value);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM3);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM4Value);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM4);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM2Value);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM2);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM1Value);
            this.tabPageMoment.Controls.Add(this.labelPrimaryM1);
            this.tabPageMoment.Controls.Add(this.labelMomentValue);
            this.tabPageMoment.Controls.Add(this.buttonCalculateMoment);
            this.tabPageMoment.Controls.Add(this.textBoxH);
            this.tabPageMoment.Controls.Add(this.labelH);
            this.tabPageMoment.Controls.Add(this.textBoxA);
            this.tabPageMoment.Controls.Add(this.labelA);
            this.tabPageMoment.Controls.Add(this.labelMoment);
            this.tabPageMoment.Location = new System.Drawing.Point(4, 25);
            this.tabPageMoment.Name = "tabPageMoment";
            this.tabPageMoment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMoment.Size = new System.Drawing.Size(452, 202);
            this.tabPageMoment.TabIndex = 3;
            this.tabPageMoment.Text = "Моменти";
            this.tabPageMoment.UseVisualStyleBackColor = true;
            // 
            // labelCentralM3Value
            // 
            this.labelCentralM3Value.AutoSize = true;
            this.labelCentralM3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM3Value.Location = new System.Drawing.Point(299, 110);
            this.labelCentralM3Value.Name = "labelCentralM3Value";
            this.labelCentralM3Value.Size = new System.Drawing.Size(18, 20);
            this.labelCentralM3Value.TabIndex = 59;
            this.labelCentralM3Value.Text = "0";
            // 
            // labelCentralM3
            // 
            this.labelCentralM3.AutoSize = true;
            this.labelCentralM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM3.Location = new System.Drawing.Point(243, 110);
            this.labelCentralM3.Name = "labelCentralM3";
            this.labelCentralM3.Size = new System.Drawing.Size(35, 20);
            this.labelCentralM3.TabIndex = 58;
            this.labelCentralM3.Text = "M3:";
            // 
            // labelCentralM4Value
            // 
            this.labelCentralM4Value.AutoSize = true;
            this.labelCentralM4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM4Value.Location = new System.Drawing.Point(299, 139);
            this.labelCentralM4Value.Name = "labelCentralM4Value";
            this.labelCentralM4Value.Size = new System.Drawing.Size(18, 20);
            this.labelCentralM4Value.TabIndex = 57;
            this.labelCentralM4Value.Text = "0";
            // 
            // labelCentralM4
            // 
            this.labelCentralM4.AutoSize = true;
            this.labelCentralM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM4.Location = new System.Drawing.Point(243, 139);
            this.labelCentralM4.Name = "labelCentralM4";
            this.labelCentralM4.Size = new System.Drawing.Size(35, 20);
            this.labelCentralM4.TabIndex = 56;
            this.labelCentralM4.Text = "M4:";
            // 
            // labelCentralM2Value
            // 
            this.labelCentralM2Value.AutoSize = true;
            this.labelCentralM2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM2Value.Location = new System.Drawing.Point(299, 81);
            this.labelCentralM2Value.Name = "labelCentralM2Value";
            this.labelCentralM2Value.Size = new System.Drawing.Size(18, 20);
            this.labelCentralM2Value.TabIndex = 55;
            this.labelCentralM2Value.Text = "0";
            // 
            // labelCentralM2
            // 
            this.labelCentralM2.AutoSize = true;
            this.labelCentralM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM2.Location = new System.Drawing.Point(243, 81);
            this.labelCentralM2.Name = "labelCentralM2";
            this.labelCentralM2.Size = new System.Drawing.Size(35, 20);
            this.labelCentralM2.TabIndex = 54;
            this.labelCentralM2.Text = "M2:";
            // 
            // labelCentralM1Value
            // 
            this.labelCentralM1Value.AutoSize = true;
            this.labelCentralM1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM1Value.Location = new System.Drawing.Point(299, 52);
            this.labelCentralM1Value.Name = "labelCentralM1Value";
            this.labelCentralM1Value.Size = new System.Drawing.Size(18, 20);
            this.labelCentralM1Value.TabIndex = 53;
            this.labelCentralM1Value.Text = "0";
            // 
            // labelCentralM1
            // 
            this.labelCentralM1.AutoSize = true;
            this.labelCentralM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCentralM1.Location = new System.Drawing.Point(243, 52);
            this.labelCentralM1.Name = "labelCentralM1";
            this.labelCentralM1.Size = new System.Drawing.Size(35, 20);
            this.labelCentralM1.TabIndex = 52;
            this.labelCentralM1.Text = "M1:";
            // 
            // labelPrimaryM3Value
            // 
            this.labelPrimaryM3Value.AutoSize = true;
            this.labelPrimaryM3Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM3Value.Location = new System.Drawing.Point(89, 110);
            this.labelPrimaryM3Value.Name = "labelPrimaryM3Value";
            this.labelPrimaryM3Value.Size = new System.Drawing.Size(18, 20);
            this.labelPrimaryM3Value.TabIndex = 51;
            this.labelPrimaryM3Value.Text = "0";
            // 
            // labelPrimaryM3
            // 
            this.labelPrimaryM3.AutoSize = true;
            this.labelPrimaryM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM3.Location = new System.Drawing.Point(33, 110);
            this.labelPrimaryM3.Name = "labelPrimaryM3";
            this.labelPrimaryM3.Size = new System.Drawing.Size(35, 20);
            this.labelPrimaryM3.TabIndex = 50;
            this.labelPrimaryM3.Text = "m3:";
            // 
            // labelPrimaryM4Value
            // 
            this.labelPrimaryM4Value.AutoSize = true;
            this.labelPrimaryM4Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM4Value.Location = new System.Drawing.Point(89, 139);
            this.labelPrimaryM4Value.Name = "labelPrimaryM4Value";
            this.labelPrimaryM4Value.Size = new System.Drawing.Size(18, 20);
            this.labelPrimaryM4Value.TabIndex = 49;
            this.labelPrimaryM4Value.Text = "0";
            // 
            // labelPrimaryM4
            // 
            this.labelPrimaryM4.AutoSize = true;
            this.labelPrimaryM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM4.Location = new System.Drawing.Point(33, 139);
            this.labelPrimaryM4.Name = "labelPrimaryM4";
            this.labelPrimaryM4.Size = new System.Drawing.Size(35, 20);
            this.labelPrimaryM4.TabIndex = 48;
            this.labelPrimaryM4.Text = "m4:";
            // 
            // labelPrimaryM2Value
            // 
            this.labelPrimaryM2Value.AutoSize = true;
            this.labelPrimaryM2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM2Value.Location = new System.Drawing.Point(89, 81);
            this.labelPrimaryM2Value.Name = "labelPrimaryM2Value";
            this.labelPrimaryM2Value.Size = new System.Drawing.Size(18, 20);
            this.labelPrimaryM2Value.TabIndex = 47;
            this.labelPrimaryM2Value.Text = "0";
            // 
            // labelPrimaryM2
            // 
            this.labelPrimaryM2.AutoSize = true;
            this.labelPrimaryM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM2.Location = new System.Drawing.Point(33, 81);
            this.labelPrimaryM2.Name = "labelPrimaryM2";
            this.labelPrimaryM2.Size = new System.Drawing.Size(35, 20);
            this.labelPrimaryM2.TabIndex = 46;
            this.labelPrimaryM2.Text = "m2:";
            // 
            // labelPrimaryM1Value
            // 
            this.labelPrimaryM1Value.AutoSize = true;
            this.labelPrimaryM1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM1Value.Location = new System.Drawing.Point(89, 52);
            this.labelPrimaryM1Value.Name = "labelPrimaryM1Value";
            this.labelPrimaryM1Value.Size = new System.Drawing.Size(18, 20);
            this.labelPrimaryM1Value.TabIndex = 45;
            this.labelPrimaryM1Value.Text = "0";
            // 
            // labelPrimaryM1
            // 
            this.labelPrimaryM1.AutoSize = true;
            this.labelPrimaryM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimaryM1.Location = new System.Drawing.Point(33, 52);
            this.labelPrimaryM1.Name = "labelPrimaryM1";
            this.labelPrimaryM1.Size = new System.Drawing.Size(35, 20);
            this.labelPrimaryM1.TabIndex = 44;
            this.labelPrimaryM1.Text = "m1:";
            // 
            // labelMomentValue
            // 
            this.labelMomentValue.AutoSize = true;
            this.labelMomentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMomentValue.Location = new System.Drawing.Point(304, 20);
            this.labelMomentValue.Name = "labelMomentValue";
            this.labelMomentValue.Size = new System.Drawing.Size(18, 20);
            this.labelMomentValue.TabIndex = 43;
            this.labelMomentValue.Text = "0";
            // 
            // buttonCalculateMoment
            // 
            this.buttonCalculateMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculateMoment.Location = new System.Drawing.Point(261, 20);
            this.buttonCalculateMoment.Name = "buttonCalculateMoment";
            this.buttonCalculateMoment.Size = new System.Drawing.Size(28, 23);
            this.buttonCalculateMoment.TabIndex = 42;
            this.buttonCalculateMoment.Text = "=";
            this.buttonCalculateMoment.UseVisualStyleBackColor = true;
            this.buttonCalculateMoment.Click += new System.EventHandler(this.buttonCalculateMoment_Click);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(226, 20);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(29, 20);
            this.textBoxH.TabIndex = 41;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelH.Location = new System.Drawing.Point(202, 20);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(21, 20);
            this.labelH.TabIndex = 40;
            this.labelH.Text = "H";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(167, 20);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(29, 20);
            this.textBoxA.TabIndex = 39;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(143, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 20);
            this.labelA.TabIndex = 38;
            this.labelA.Text = "a";
            // 
            // labelMoment
            // 
            this.labelMoment.AutoSize = true;
            this.labelMoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoment.Location = new System.Drawing.Point(64, 20);
            this.labelMoment.Name = "labelMoment";
            this.labelMoment.Size = new System.Drawing.Size(73, 20);
            this.labelMoment.TabIndex = 37;
            this.labelMoment.Text = "Момент:";
            // 
            // tabPageForm
            // 
            this.tabPageForm.Controls.Add(this.labelExcessValue);
            this.tabPageForm.Controls.Add(this.labelAsymmetry);
            this.tabPageForm.Controls.Add(this.labelExcess);
            this.tabPageForm.Controls.Add(this.labelAsymmetryValue);
            this.tabPageForm.Location = new System.Drawing.Point(4, 25);
            this.tabPageForm.Name = "tabPageForm";
            this.tabPageForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForm.Size = new System.Drawing.Size(452, 202);
            this.tabPageForm.TabIndex = 4;
            this.tabPageForm.Text = "Форма";
            this.tabPageForm.UseVisualStyleBackColor = true;
            // 
            // labelExcessValue
            // 
            this.labelExcessValue.AutoSize = true;
            this.labelExcessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExcessValue.Location = new System.Drawing.Point(146, 99);
            this.labelExcessValue.Name = "labelExcessValue";
            this.labelExcessValue.Size = new System.Drawing.Size(18, 20);
            this.labelExcessValue.TabIndex = 51;
            this.labelExcessValue.Text = "0";
            // 
            // labelAsymmetry
            // 
            this.labelAsymmetry.AutoSize = true;
            this.labelAsymmetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAsymmetry.Location = new System.Drawing.Point(29, 36);
            this.labelAsymmetry.Name = "labelAsymmetry";
            this.labelAsymmetry.Size = new System.Drawing.Size(91, 20);
            this.labelAsymmetry.TabIndex = 48;
            this.labelAsymmetry.Text = "Асиметрія:";
            // 
            // labelExcess
            // 
            this.labelExcess.AutoSize = true;
            this.labelExcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExcess.Location = new System.Drawing.Point(29, 99);
            this.labelExcess.Name = "labelExcess";
            this.labelExcess.Size = new System.Drawing.Size(66, 20);
            this.labelExcess.TabIndex = 50;
            this.labelExcess.Text = "Ексцес:";
            // 
            // labelAsymmetryValue
            // 
            this.labelAsymmetryValue.AutoSize = true;
            this.labelAsymmetryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAsymmetryValue.Location = new System.Drawing.Point(146, 36);
            this.labelAsymmetryValue.Name = "labelAsymmetryValue";
            this.labelAsymmetryValue.Size = new System.Drawing.Size(18, 20);
            this.labelAsymmetryValue.TabIndex = 49;
            this.labelAsymmetryValue.Text = "0";
            // 
            // labelPearsonCriterion
            // 
            this.labelPearsonCriterion.AutoSize = true;
            this.labelPearsonCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPearsonCriterion.Location = new System.Drawing.Point(573, 475);
            this.labelPearsonCriterion.Name = "labelPearsonCriterion";
            this.labelPearsonCriterion.Size = new System.Drawing.Size(139, 20);
            this.labelPearsonCriterion.TabIndex = 52;
            this.labelPearsonCriterion.Text = "Критерій Пірсона";
            // 
            // radioButtonDiscrete
            // 
            this.radioButtonDiscrete.AutoSize = true;
            this.radioButtonDiscrete.Checked = true;
            this.radioButtonDiscrete.Location = new System.Drawing.Point(15, 30);
            this.radioButtonDiscrete.Name = "radioButtonDiscrete";
            this.radioButtonDiscrete.Size = new System.Drawing.Size(95, 20);
            this.radioButtonDiscrete.TabIndex = 53;
            this.radioButtonDiscrete.TabStop = true;
            this.radioButtonDiscrete.Text = "дискретна";
            this.radioButtonDiscrete.UseVisualStyleBackColor = true;
            // 
            // groupBoxVariableType
            // 
            this.groupBoxVariableType.Controls.Add(this.radioButtonUninterrupted);
            this.groupBoxVariableType.Controls.Add(this.radioButtonDiscrete);
            this.groupBoxVariableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxVariableType.Location = new System.Drawing.Point(765, 275);
            this.groupBoxVariableType.Name = "groupBoxVariableType";
            this.groupBoxVariableType.Size = new System.Drawing.Size(192, 100);
            this.groupBoxVariableType.TabIndex = 54;
            this.groupBoxVariableType.TabStop = false;
            this.groupBoxVariableType.Text = "Статистична змінна";
            // 
            // radioButtonUninterrupted
            // 
            this.radioButtonUninterrupted.AutoSize = true;
            this.radioButtonUninterrupted.Location = new System.Drawing.Point(15, 65);
            this.radioButtonUninterrupted.Name = "radioButtonUninterrupted";
            this.radioButtonUninterrupted.Size = new System.Drawing.Size(106, 20);
            this.radioButtonUninterrupted.TabIndex = 55;
            this.radioButtonUninterrupted.Text = "неперервна";
            this.radioButtonUninterrupted.UseVisualStyleBackColor = true;
            // 
            // labelEmpiricX
            // 
            this.labelEmpiricX.AutoSize = true;
            this.labelEmpiricX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpiricX.Location = new System.Drawing.Point(496, 600);
            this.labelEmpiricX.Name = "labelEmpiricX";
            this.labelEmpiricX.Size = new System.Drawing.Size(53, 20);
            this.labelEmpiricX.TabIndex = 55;
            this.labelEmpiricX.Text = "X емп";
            // 
            // labelEmpiricXValue
            // 
            this.labelEmpiricXValue.AutoSize = true;
            this.labelEmpiricXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmpiricXValue.Location = new System.Drawing.Point(564, 600);
            this.labelEmpiricXValue.Name = "labelEmpiricXValue";
            this.labelEmpiricXValue.Size = new System.Drawing.Size(18, 20);
            this.labelEmpiricXValue.TabIndex = 56;
            this.labelEmpiricXValue.Text = "0";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(568, 542);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(58, 20);
            this.textBoxAlpha.TabIndex = 58;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlpha.Location = new System.Drawing.Point(524, 542);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(48, 20);
            this.labelAlpha.TabIndex = 57;
            this.labelAlpha.Text = "alpha";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(653, 540);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(14, 20);
            this.labelR.TabIndex = 59;
            this.labelR.Text = "r";
            // 
            // labelRValue
            // 
            this.labelRValue.AutoSize = true;
            this.labelRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRValue.Location = new System.Drawing.Point(707, 540);
            this.labelRValue.Name = "labelRValue";
            this.labelRValue.Size = new System.Drawing.Size(18, 20);
            this.labelRValue.TabIndex = 60;
            this.labelRValue.Text = "0";
            // 
            // labelCriticalX
            // 
            this.labelCriticalX.AutoSize = true;
            this.labelCriticalX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCriticalX.Location = new System.Drawing.Point(707, 600);
            this.labelCriticalX.Name = "labelCriticalX";
            this.labelCriticalX.Size = new System.Drawing.Size(41, 20);
            this.labelCriticalX.TabIndex = 61;
            this.labelCriticalX.Text = "X кр";
            // 
            // labelCriticalXValue
            // 
            this.labelCriticalXValue.AutoSize = true;
            this.labelCriticalXValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCriticalXValue.Location = new System.Drawing.Point(764, 600);
            this.labelCriticalXValue.Name = "labelCriticalXValue";
            this.labelCriticalXValue.Size = new System.Drawing.Size(18, 20);
            this.labelCriticalXValue.TabIndex = 62;
            this.labelCriticalXValue.Text = "0";
            // 
            // labelHypothesis
            // 
            this.labelHypothesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHypothesis.Location = new System.Drawing.Point(791, 453);
            this.labelHypothesis.Name = "labelHypothesis";
            this.labelHypothesis.Size = new System.Drawing.Size(146, 65);
            this.labelHypothesis.TabIndex = 63;
            this.labelHypothesis.Text = "H: F(x) - функція рівномірного розподілу";
            this.labelHypothesis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIsAccepted
            // 
            this.labelIsAccepted.AutoSize = true;
            this.labelIsAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsAccepted.Location = new System.Drawing.Point(859, 540);
            this.labelIsAccepted.Name = "labelIsAccepted";
            this.labelIsAccepted.Size = new System.Drawing.Size(27, 20);
            this.labelIsAccepted.TabIndex = 64;
            this.labelIsAccepted.Text = "__";
            // 
            // buttonCalculatePearsonCriterion
            // 
            this.buttonCalculatePearsonCriterion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculatePearsonCriterion.Location = new System.Drawing.Point(780, 540);
            this.buttonCalculatePearsonCriterion.Name = "buttonCalculatePearsonCriterion";
            this.buttonCalculatePearsonCriterion.Size = new System.Drawing.Size(28, 23);
            this.buttonCalculatePearsonCriterion.TabIndex = 65;
            this.buttonCalculatePearsonCriterion.Text = "=";
            this.buttonCalculatePearsonCriterion.UseVisualStyleBackColor = true;
            this.buttonCalculatePearsonCriterion.Click += new System.EventHandler(this.buttonCalculatePearsonCriterion_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 713);
            this.Controls.Add(this.buttonCalculatePearsonCriterion);
            this.Controls.Add(this.labelIsAccepted);
            this.Controls.Add(this.labelHypothesis);
            this.Controls.Add(this.labelCriticalX);
            this.Controls.Add(this.labelCriticalXValue);
            this.Controls.Add(this.labelRValue);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.labelEmpiricX);
            this.Controls.Add(this.labelEmpiricXValue);
            this.Controls.Add(this.groupBoxVariableType);
            this.Controls.Add(this.labelPearsonCriterion);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.chartDistributionFunction);
            this.Controls.Add(this.chartFrequencyRange);
            this.Controls.Add(this.chartFrequencyHistogram);
            this.Controls.Add(this.textBoxVariationSeries);
            this.Controls.Add(this.buttonUpdateSample);
            this.Controls.Add(this.textBoxSample);
            this.Controls.Add(this.labelSampleSize);
            this.Controls.Add(this.labelFinishInterval);
            this.Controls.Add(this.labelStartInterval);
            this.Controls.Add(this.numericStartInterval);
            this.Controls.Add(this.numericFinishInterval);
            this.Controls.Add(this.numericSampleSize);
            this.Controls.Add(this.buttonGenerateSample);
            this.Controls.Add(this.dataGridViewFrequencyTable);
            this.Controls.Add(this.menuStrip);
            this.MaximumSize = new System.Drawing.Size(984, 752);
            this.MinimumSize = new System.Drawing.Size(984, 752);
            this.Name = "FormStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrequencyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSampleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinishInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistributionFunction)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageTheCentralTrendStatistics.ResumeLayout(false);
            this.tabPageTheCentralTrendStatistics.PerformLayout();
            this.tabPageScatteringStatistics.ResumeLayout(false);
            this.tabPageScatteringStatistics.PerformLayout();
            this.tabPageInterquantileLatitude.ResumeLayout(false);
            this.tabPageInterquantileLatitude.PerformLayout();
            this.tabPageMoment.ResumeLayout(false);
            this.tabPageMoment.PerformLayout();
            this.tabPageForm.ResumeLayout(false);
            this.tabPageForm.PerformLayout();
            this.groupBoxVariableType.ResumeLayout(false);
            this.groupBoxVariableType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFrequencyTable;
        private System.Windows.Forms.Button buttonGenerateSample;
        private System.Windows.Forms.NumericUpDown numericSampleSize;
        private System.Windows.Forms.NumericUpDown numericFinishInterval;
        private System.Windows.Forms.NumericUpDown numericStartInterval;
        private System.Windows.Forms.Label labelStartInterval;
        private System.Windows.Forms.Label labelFinishInterval;
        private System.Windows.Forms.Label labelSampleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBoxSample;
        private System.Windows.Forms.Button buttonUpdateSample;
        private System.Windows.Forms.TextBox textBoxVariationSeries;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequencyHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequencyRange;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistributionFunction;
        private System.Windows.Forms.Label labelMedian;
        private System.Windows.Forms.Label labelMedianValue;
        private System.Windows.Forms.Label labelModaValue;
        private System.Windows.Forms.Label labelModa;
        private System.Windows.Forms.Label labelAverageValue;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelDeviationValue;
        private System.Windows.Forms.Label labelDeviation;
        private System.Windows.Forms.Label labelVarianceValue;
        private System.Windows.Forms.Label labelVariance;
        private System.Windows.Forms.Label labelStandartValue;
        private System.Windows.Forms.Label labelStandart;
        private System.Windows.Forms.Label labelSampleRangeValue;
        private System.Windows.Forms.Label labelSampleRange;
        private System.Windows.Forms.Label labelVariationValue;
        private System.Windows.Forms.Label labelVariation;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTheCentralTrendStatistics;
        private System.Windows.Forms.TabPage tabPageScatteringStatistics;
        private System.Windows.Forms.TabPage tabPageInterquantileLatitude;
        private System.Windows.Forms.Label labelQuantileValue;
        private System.Windows.Forms.Label labelQuantile;
        private System.Windows.Forms.TextBox textBoxQuantile;
        private System.Windows.Forms.TextBox textBoxQuartile;
        private System.Windows.Forms.Label labelQuartileValue;
        private System.Windows.Forms.Label labelQuartile;
        private System.Windows.Forms.TextBox textBoxDecile;
        private System.Windows.Forms.Label labelDecileValue;
        private System.Windows.Forms.Label labelDecile;
        private System.Windows.Forms.TextBox textBoxOctile;
        private System.Windows.Forms.Label labelOctileValue;
        private System.Windows.Forms.Label labelOctile;
        private System.Windows.Forms.TextBox textBoxCentile;
        private System.Windows.Forms.Label labelCentileValue;
        private System.Windows.Forms.Label labelCentile;
        private System.Windows.Forms.TextBox textBoxMilile;
        private System.Windows.Forms.Label labelMilileValue;
        private System.Windows.Forms.Label labelMilile;
        private System.Windows.Forms.TabPage tabPageMoment;
        private System.Windows.Forms.Label labelMoment;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonCalculateMoment;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelMomentValue;
        private System.Windows.Forms.Label labelCentralM3Value;
        private System.Windows.Forms.Label labelCentralM3;
        private System.Windows.Forms.Label labelCentralM4Value;
        private System.Windows.Forms.Label labelCentralM4;
        private System.Windows.Forms.Label labelCentralM2Value;
        private System.Windows.Forms.Label labelCentralM2;
        private System.Windows.Forms.Label labelCentralM1Value;
        private System.Windows.Forms.Label labelCentralM1;
        private System.Windows.Forms.Label labelPrimaryM3Value;
        private System.Windows.Forms.Label labelPrimaryM3;
        private System.Windows.Forms.Label labelPrimaryM4Value;
        private System.Windows.Forms.Label labelPrimaryM4;
        private System.Windows.Forms.Label labelPrimaryM2Value;
        private System.Windows.Forms.Label labelPrimaryM2;
        private System.Windows.Forms.Label labelPrimaryM1Value;
        private System.Windows.Forms.Label labelPrimaryM1;
        private System.Windows.Forms.TabPage tabPageForm;
        private System.Windows.Forms.Label labelExcessValue;
        private System.Windows.Forms.Label labelAsymmetry;
        private System.Windows.Forms.Label labelExcess;
        private System.Windows.Forms.Label labelAsymmetryValue;
        private System.Windows.Forms.Label labelPearsonCriterion;
        private System.Windows.Forms.RadioButton radioButtonDiscrete;
        private System.Windows.Forms.GroupBox groupBoxVariableType;
        private System.Windows.Forms.RadioButton radioButtonUninterrupted;
        private System.Windows.Forms.Label labelEmpiricX;
        private System.Windows.Forms.Label labelEmpiricXValue;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelRValue;
        private System.Windows.Forms.Label labelCriticalX;
        private System.Windows.Forms.Label labelCriticalXValue;
        private System.Windows.Forms.Label labelHypothesis;
        private System.Windows.Forms.Label labelIsAccepted;
        private System.Windows.Forms.Button buttonCalculatePearsonCriterion;
    }
}

