namespace DrawingNumericalIntegration
{
    partial class NumericalIntegrationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelIByGaussPoints4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIByParabolas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIByTrapezes = new System.Windows.Forms.Label();
            this.labelInterpolationGaussMethodFx = new System.Windows.Forms.Label();
            this.labelIByRectangles = new System.Windows.Forms.Label();
            this.labelInterpolationNewtonMethodFx = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCallsGaussPoints4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCallsParabolas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCallsTrapezes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCallsRectangles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelIterationGaussPoints4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelIterationParabolas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelIterationTrapezes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelIterationRectangles = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelInputEpsylon = new System.Windows.Forms.Label();
            this.textBoxEpsylon = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelIterationGaussPoints5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCallsGaussPoints5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelIByGaussPoints5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.chart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 576);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "y = x*ln(x)";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(757, 570);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.labelInputEpsylon);
            this.panel1.Controls.Add(this.textBoxEpsylon);
            this.panel1.Controls.Add(this.CalculateBtn);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(766, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 576);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 132);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 321);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelIByGaussPoints5);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.labelIByGaussPoints4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.labelIByParabolas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelIByTrapezes);
            this.tabPage1.Controls.Add(this.labelInterpolationGaussMethodFx);
            this.tabPage1.Controls.Add(this.labelIByRectangles);
            this.tabPage1.Controls.Add(this.labelInterpolationNewtonMethodFx);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Integrals";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelIByGaussPoints4
            // 
            this.labelIByGaussPoints4.AutoEllipsis = true;
            this.labelIByGaussPoints4.AutoSize = true;
            this.labelIByGaussPoints4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIByGaussPoints4.Location = new System.Drawing.Point(149, 164);
            this.labelIByGaussPoints4.Name = "labelIByGaussPoints4";
            this.labelIByGaussPoints4.Size = new System.Drawing.Size(15, 16);
            this.labelIByGaussPoints4.TabIndex = 67;
            this.labelIByGaussPoints4.Text = "0";
            this.labelIByGaussPoints4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 55);
            this.label4.TabIndex = 66;
            this.label4.Text = "Integral by Gauss (4 points)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIByParabolas
            // 
            this.labelIByParabolas.AutoEllipsis = true;
            this.labelIByParabolas.AutoSize = true;
            this.labelIByParabolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIByParabolas.Location = new System.Drawing.Point(149, 124);
            this.labelIByParabolas.Name = "labelIByParabolas";
            this.labelIByParabolas.Size = new System.Drawing.Size(15, 16);
            this.labelIByParabolas.TabIndex = 65;
            this.labelIByParabolas.Text = "0";
            this.labelIByParabolas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 58);
            this.label3.TabIndex = 64;
            this.label3.Text = "Integral by parabolas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIByTrapezes
            // 
            this.labelIByTrapezes.AutoEllipsis = true;
            this.labelIByTrapezes.AutoSize = true;
            this.labelIByTrapezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIByTrapezes.Location = new System.Drawing.Point(150, 83);
            this.labelIByTrapezes.Name = "labelIByTrapezes";
            this.labelIByTrapezes.Size = new System.Drawing.Size(15, 16);
            this.labelIByTrapezes.TabIndex = 63;
            this.labelIByTrapezes.Text = "0";
            this.labelIByTrapezes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInterpolationGaussMethodFx
            // 
            this.labelInterpolationGaussMethodFx.AutoEllipsis = true;
            this.labelInterpolationGaussMethodFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationGaussMethodFx.Location = new System.Drawing.Point(0, 62);
            this.labelInterpolationGaussMethodFx.Name = "labelInterpolationGaussMethodFx";
            this.labelInterpolationGaussMethodFx.Size = new System.Drawing.Size(143, 58);
            this.labelInterpolationGaussMethodFx.TabIndex = 62;
            this.labelInterpolationGaussMethodFx.Text = "Integral by trapezes";
            this.labelInterpolationGaussMethodFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIByRectangles
            // 
            this.labelIByRectangles.AutoEllipsis = true;
            this.labelIByRectangles.AutoSize = true;
            this.labelIByRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIByRectangles.Location = new System.Drawing.Point(149, 45);
            this.labelIByRectangles.Name = "labelIByRectangles";
            this.labelIByRectangles.Size = new System.Drawing.Size(15, 16);
            this.labelIByRectangles.TabIndex = 61;
            this.labelIByRectangles.Text = "0";
            this.labelIByRectangles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInterpolationNewtonMethodFx
            // 
            this.labelInterpolationNewtonMethodFx.AutoEllipsis = true;
            this.labelInterpolationNewtonMethodFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationNewtonMethodFx.Location = new System.Drawing.Point(-1, 24);
            this.labelInterpolationNewtonMethodFx.Name = "labelInterpolationNewtonMethodFx";
            this.labelInterpolationNewtonMethodFx.Size = new System.Drawing.Size(143, 59);
            this.labelInterpolationNewtonMethodFx.TabIndex = 60;
            this.labelInterpolationNewtonMethodFx.Text = "Integral by rectangles";
            this.labelInterpolationNewtonMethodFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelCallsGaussPoints5);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.labelCallsGaussPoints4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.labelCallsParabolas);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.labelCallsTrapezes);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.labelCallsRectangles);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Number of function calls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCallsGaussPoints4
            // 
            this.labelCallsGaussPoints4.AutoEllipsis = true;
            this.labelCallsGaussPoints4.AutoSize = true;
            this.labelCallsGaussPoints4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCallsGaussPoints4.Location = new System.Drawing.Point(148, 160);
            this.labelCallsGaussPoints4.Name = "labelCallsGaussPoints4";
            this.labelCallsGaussPoints4.Size = new System.Drawing.Size(15, 16);
            this.labelCallsGaussPoints4.TabIndex = 75;
            this.labelCallsGaussPoints4.Text = "0";
            this.labelCallsGaussPoints4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 62);
            this.label2.TabIndex = 74;
            this.label2.Text = "Calls in Gauss (4 points)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCallsParabolas
            // 
            this.labelCallsParabolas.AutoEllipsis = true;
            this.labelCallsParabolas.AutoSize = true;
            this.labelCallsParabolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCallsParabolas.Location = new System.Drawing.Point(148, 120);
            this.labelCallsParabolas.Name = "labelCallsParabolas";
            this.labelCallsParabolas.Size = new System.Drawing.Size(15, 16);
            this.labelCallsParabolas.TabIndex = 73;
            this.labelCallsParabolas.Text = "0";
            this.labelCallsParabolas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 58);
            this.label6.TabIndex = 72;
            this.label6.Text = "Calls in parabolas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCallsTrapezes
            // 
            this.labelCallsTrapezes.AutoEllipsis = true;
            this.labelCallsTrapezes.AutoSize = true;
            this.labelCallsTrapezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCallsTrapezes.Location = new System.Drawing.Point(149, 79);
            this.labelCallsTrapezes.Name = "labelCallsTrapezes";
            this.labelCallsTrapezes.Size = new System.Drawing.Size(15, 16);
            this.labelCallsTrapezes.TabIndex = 71;
            this.labelCallsTrapezes.Text = "0";
            this.labelCallsTrapezes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(-1, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 58);
            this.label8.TabIndex = 70;
            this.label8.Text = "Calls in trapezes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCallsRectangles
            // 
            this.labelCallsRectangles.AutoEllipsis = true;
            this.labelCallsRectangles.AutoSize = true;
            this.labelCallsRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCallsRectangles.Location = new System.Drawing.Point(148, 41);
            this.labelCallsRectangles.Name = "labelCallsRectangles";
            this.labelCallsRectangles.Size = new System.Drawing.Size(15, 16);
            this.labelCallsRectangles.TabIndex = 69;
            this.labelCallsRectangles.Text = "0";
            this.labelCallsRectangles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(-2, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 59);
            this.label10.TabIndex = 68;
            this.label10.Text = "Calls in rectangles";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelIterationGaussPoints5);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.labelIterationGaussPoints4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.labelIterationParabolas);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.labelIterationTrapezes);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.labelIterationRectangles);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(284, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Number of iteration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelIterationGaussPoints4
            // 
            this.labelIterationGaussPoints4.AutoEllipsis = true;
            this.labelIterationGaussPoints4.AutoSize = true;
            this.labelIterationGaussPoints4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterationGaussPoints4.Location = new System.Drawing.Point(143, 165);
            this.labelIterationGaussPoints4.Name = "labelIterationGaussPoints4";
            this.labelIterationGaussPoints4.Size = new System.Drawing.Size(15, 16);
            this.labelIterationGaussPoints4.TabIndex = 83;
            this.labelIterationGaussPoints4.Text = "0";
            this.labelIterationGaussPoints4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 64);
            this.label5.TabIndex = 82;
            this.label5.Text = "Iteration in Gauss (4 points)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIterationParabolas
            // 
            this.labelIterationParabolas.AutoEllipsis = true;
            this.labelIterationParabolas.AutoSize = true;
            this.labelIterationParabolas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterationParabolas.Location = new System.Drawing.Point(143, 125);
            this.labelIterationParabolas.Name = "labelIterationParabolas";
            this.labelIterationParabolas.Size = new System.Drawing.Size(15, 16);
            this.labelIterationParabolas.TabIndex = 81;
            this.labelIterationParabolas.Text = "0";
            this.labelIterationParabolas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(-3, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 58);
            this.label9.TabIndex = 80;
            this.label9.Text = "Iteration in parabolas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIterationTrapezes
            // 
            this.labelIterationTrapezes.AutoEllipsis = true;
            this.labelIterationTrapezes.AutoSize = true;
            this.labelIterationTrapezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterationTrapezes.Location = new System.Drawing.Point(144, 84);
            this.labelIterationTrapezes.Name = "labelIterationTrapezes";
            this.labelIterationTrapezes.Size = new System.Drawing.Size(15, 16);
            this.labelIterationTrapezes.TabIndex = 79;
            this.labelIterationTrapezes.Text = "0";
            this.labelIterationTrapezes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(-6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 58);
            this.label12.TabIndex = 78;
            this.label12.Text = "Iteration in trapezes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIterationRectangles
            // 
            this.labelIterationRectangles.AutoEllipsis = true;
            this.labelIterationRectangles.AutoSize = true;
            this.labelIterationRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterationRectangles.Location = new System.Drawing.Point(143, 46);
            this.labelIterationRectangles.Name = "labelIterationRectangles";
            this.labelIterationRectangles.Size = new System.Drawing.Size(15, 16);
            this.labelIterationRectangles.TabIndex = 77;
            this.labelIterationRectangles.Text = "0";
            this.labelIterationRectangles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(-7, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 59);
            this.label14.TabIndex = 76;
            this.label14.Text = "Iteration in rectangles";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInputEpsylon
            // 
            this.labelInputEpsylon.AutoEllipsis = true;
            this.labelInputEpsylon.AutoSize = true;
            this.labelInputEpsylon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputEpsylon.Location = new System.Drawing.Point(16, 50);
            this.labelInputEpsylon.Name = "labelInputEpsylon";
            this.labelInputEpsylon.Size = new System.Drawing.Size(90, 16);
            this.labelInputEpsylon.TabIndex = 40;
            this.labelInputEpsylon.Text = "Input epsylon:";
            this.labelInputEpsylon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEpsylon
            // 
            this.textBoxEpsylon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEpsylon.Location = new System.Drawing.Point(139, 50);
            this.textBoxEpsylon.Name = "textBoxEpsylon";
            this.textBoxEpsylon.Size = new System.Drawing.Size(100, 26);
            this.textBoxEpsylon.TabIndex = 38;
            this.textBoxEpsylon.Text = "1e-3";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(55, 82);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(150, 34);
            this.CalculateBtn.TabIndex = 39;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(138, 19);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(56, 31);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b = ";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(33, 19);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 31);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a = ";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIterationGaussPoints5
            // 
            this.labelIterationGaussPoints5.AutoEllipsis = true;
            this.labelIterationGaussPoints5.AutoSize = true;
            this.labelIterationGaussPoints5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterationGaussPoints5.Location = new System.Drawing.Point(144, 216);
            this.labelIterationGaussPoints5.Name = "labelIterationGaussPoints5";
            this.labelIterationGaussPoints5.Size = new System.Drawing.Size(15, 16);
            this.labelIterationGaussPoints5.TabIndex = 85;
            this.labelIterationGaussPoints5.Text = "0";
            this.labelIterationGaussPoints5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-1, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 51);
            this.label7.TabIndex = 84;
            this.label7.Text = "Iteration in Gauss (5 points)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCallsGaussPoints5
            // 
            this.labelCallsGaussPoints5.AutoEllipsis = true;
            this.labelCallsGaussPoints5.AutoSize = true;
            this.labelCallsGaussPoints5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCallsGaussPoints5.Location = new System.Drawing.Point(148, 204);
            this.labelCallsGaussPoints5.Name = "labelCallsGaussPoints5";
            this.labelCallsGaussPoints5.Size = new System.Drawing.Size(15, 16);
            this.labelCallsGaussPoints5.TabIndex = 77;
            this.labelCallsGaussPoints5.Text = "0";
            this.labelCallsGaussPoints5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 39);
            this.label11.TabIndex = 76;
            this.label11.Text = "Calls in Gauss (5 points)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIByGaussPoints5
            // 
            this.labelIByGaussPoints5.AutoEllipsis = true;
            this.labelIByGaussPoints5.AutoSize = true;
            this.labelIByGaussPoints5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIByGaussPoints5.Location = new System.Drawing.Point(149, 210);
            this.labelIByGaussPoints5.Name = "labelIByGaussPoints5";
            this.labelIByGaussPoints5.Size = new System.Drawing.Size(15, 16);
            this.labelIByGaussPoints5.TabIndex = 69;
            this.labelIByGaussPoints5.Text = "0";
            this.labelIByGaussPoints5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 36);
            this.label13.TabIndex = 68;
            this.label13.Text = "Integral by Gauss (5 points)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericalIntegrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1075, 617);
            this.Name = "NumericalIntegrationForm";
            this.Text = "Numerical Integration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInputEpsylon;
        private System.Windows.Forms.TextBox textBoxEpsylon;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelIByGaussPoints4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIByParabolas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIByTrapezes;
        private System.Windows.Forms.Label labelInterpolationGaussMethodFx;
        private System.Windows.Forms.Label labelIByRectangles;
        private System.Windows.Forms.Label labelInterpolationNewtonMethodFx;
        private System.Windows.Forms.Label labelCallsGaussPoints4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCallsParabolas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCallsTrapezes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCallsRectangles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelIterationGaussPoints4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelIterationParabolas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelIterationTrapezes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelIterationRectangles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelIterationGaussPoints5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIByGaussPoints5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelCallsGaussPoints5;
        private System.Windows.Forms.Label label11;
    }
}

