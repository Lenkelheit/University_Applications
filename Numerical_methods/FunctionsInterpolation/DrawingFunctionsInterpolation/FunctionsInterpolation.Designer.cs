namespace DrawingFunctionsInterpolation
{
    partial class FormFunctionsInterpolation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGaussError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNewtonError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGaussDifferences = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNewtonDifferences = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberIterationNewtonMethodValue = new System.Windows.Forms.Label();
            this.labelNumberIterationGaussMethodValue = new System.Windows.Forms.Label();
            this.labelNumberIterationGaussMethod = new System.Windows.Forms.Label();
            this.labelNumberIterationNewtonMethod = new System.Windows.Forms.Label();
            this.labelInterpolationGaussMethodFxValue = new System.Windows.Forms.Label();
            this.labelInterpolationGaussMethodFx = new System.Windows.Forms.Label();
            this.labelInputEpsylon = new System.Windows.Forms.Label();
            this.textBoxEpsylon = new System.Windows.Forms.TextBox();
            this.labelFxValue = new System.Windows.Forms.Label();
            this.labelInterpolationNewtonMethodFxValue = new System.Windows.Forms.Label();
            this.labelFx = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelInterpolationNewtonMethodFx = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelInputX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.chartInterpolation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInterpolation)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartInterpolation, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(645, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 643);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelGaussError);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelNewtonError);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelGaussDifferences);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNewtonDifferences);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelNumberIterationNewtonMethodValue);
            this.panel1.Controls.Add(this.labelNumberIterationGaussMethodValue);
            this.panel1.Controls.Add(this.labelNumberIterationGaussMethod);
            this.panel1.Controls.Add(this.labelNumberIterationNewtonMethod);
            this.panel1.Controls.Add(this.labelInterpolationGaussMethodFxValue);
            this.panel1.Controls.Add(this.labelInterpolationGaussMethodFx);
            this.panel1.Controls.Add(this.labelInputEpsylon);
            this.panel1.Controls.Add(this.textBoxEpsylon);
            this.panel1.Controls.Add(this.labelFxValue);
            this.panel1.Controls.Add(this.labelInterpolationNewtonMethodFxValue);
            this.panel1.Controls.Add(this.labelFx);
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.labelInterpolationNewtonMethodFx);
            this.panel1.Controls.Add(this.labelN);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelA);
            this.panel1.Controls.Add(this.labelInputX);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 637);
            this.panel1.TabIndex = 0;
            // 
            // labelGaussError
            // 
            this.labelGaussError.AutoEllipsis = true;
            this.labelGaussError.AutoSize = true;
            this.labelGaussError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGaussError.Location = new System.Drawing.Point(197, 600);
            this.labelGaussError.Name = "labelGaussError";
            this.labelGaussError.Size = new System.Drawing.Size(15, 16);
            this.labelGaussError.TabIndex = 51;
            this.labelGaussError.Text = "0";
            this.labelGaussError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 43);
            this.label4.TabIndex = 50;
            this.label4.Text = "Error in Gauss Method ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewtonError
            // 
            this.labelNewtonError.AutoEllipsis = true;
            this.labelNewtonError.AutoSize = true;
            this.labelNewtonError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewtonError.Location = new System.Drawing.Point(197, 550);
            this.labelNewtonError.Name = "labelNewtonError";
            this.labelNewtonError.Size = new System.Drawing.Size(15, 16);
            this.labelNewtonError.TabIndex = 49;
            this.labelNewtonError.Text = "0";
            this.labelNewtonError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 46);
            this.label6.TabIndex = 48;
            this.label6.Text = "Error in Newton Method ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGaussDifferences
            // 
            this.labelGaussDifferences.AutoEllipsis = true;
            this.labelGaussDifferences.AutoSize = true;
            this.labelGaussDifferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGaussDifferences.Location = new System.Drawing.Point(197, 495);
            this.labelGaussDifferences.Name = "labelGaussDifferences";
            this.labelGaussDifferences.Size = new System.Drawing.Size(15, 16);
            this.labelGaussDifferences.TabIndex = 47;
            this.labelGaussDifferences.Text = "0";
            this.labelGaussDifferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 59);
            this.label3.TabIndex = 46;
            this.label3.Text = "Order of differences by Gauss Method ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewtonDifferences
            // 
            this.labelNewtonDifferences.AutoEllipsis = true;
            this.labelNewtonDifferences.AutoSize = true;
            this.labelNewtonDifferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNewtonDifferences.Location = new System.Drawing.Point(197, 436);
            this.labelNewtonDifferences.Name = "labelNewtonDifferences";
            this.labelNewtonDifferences.Size = new System.Drawing.Size(15, 16);
            this.labelNewtonDifferences.TabIndex = 45;
            this.labelNewtonDifferences.Text = "0";
            this.labelNewtonDifferences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 59);
            this.label2.TabIndex = 44;
            this.label2.Text = "Order of differences by Newton Method ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberIterationNewtonMethodValue
            // 
            this.labelNumberIterationNewtonMethodValue.AutoEllipsis = true;
            this.labelNumberIterationNewtonMethodValue.AutoSize = true;
            this.labelNumberIterationNewtonMethodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberIterationNewtonMethodValue.Location = new System.Drawing.Point(197, 320);
            this.labelNumberIterationNewtonMethodValue.Name = "labelNumberIterationNewtonMethodValue";
            this.labelNumberIterationNewtonMethodValue.Size = new System.Drawing.Size(15, 16);
            this.labelNumberIterationNewtonMethodValue.TabIndex = 43;
            this.labelNumberIterationNewtonMethodValue.Text = "0";
            this.labelNumberIterationNewtonMethodValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberIterationGaussMethodValue
            // 
            this.labelNumberIterationGaussMethodValue.AutoEllipsis = true;
            this.labelNumberIterationGaussMethodValue.AutoSize = true;
            this.labelNumberIterationGaussMethodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberIterationGaussMethodValue.Location = new System.Drawing.Point(197, 377);
            this.labelNumberIterationGaussMethodValue.Name = "labelNumberIterationGaussMethodValue";
            this.labelNumberIterationGaussMethodValue.Size = new System.Drawing.Size(15, 16);
            this.labelNumberIterationGaussMethodValue.TabIndex = 42;
            this.labelNumberIterationGaussMethodValue.Text = "0";
            this.labelNumberIterationGaussMethodValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberIterationGaussMethod
            // 
            this.labelNumberIterationGaussMethod.AutoEllipsis = true;
            this.labelNumberIterationGaussMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberIterationGaussMethod.Location = new System.Drawing.Point(8, 358);
            this.labelNumberIterationGaussMethod.Name = "labelNumberIterationGaussMethod";
            this.labelNumberIterationGaussMethod.Size = new System.Drawing.Size(171, 59);
            this.labelNumberIterationGaussMethod.TabIndex = 41;
            this.labelNumberIterationGaussMethod.Text = "Number elements  by Gauss Method:";
            this.labelNumberIterationGaussMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberIterationNewtonMethod
            // 
            this.labelNumberIterationNewtonMethod.AutoEllipsis = true;
            this.labelNumberIterationNewtonMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberIterationNewtonMethod.Location = new System.Drawing.Point(10, 301);
            this.labelNumberIterationNewtonMethod.Name = "labelNumberIterationNewtonMethod";
            this.labelNumberIterationNewtonMethod.Size = new System.Drawing.Size(171, 59);
            this.labelNumberIterationNewtonMethod.TabIndex = 40;
            this.labelNumberIterationNewtonMethod.Text = "Number elements by Newton Method:";
            this.labelNumberIterationNewtonMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInterpolationGaussMethodFxValue
            // 
            this.labelInterpolationGaussMethodFxValue.AutoEllipsis = true;
            this.labelInterpolationGaussMethodFxValue.AutoSize = true;
            this.labelInterpolationGaussMethodFxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationGaussMethodFxValue.Location = new System.Drawing.Point(197, 242);
            this.labelInterpolationGaussMethodFxValue.Name = "labelInterpolationGaussMethodFxValue";
            this.labelInterpolationGaussMethodFxValue.Size = new System.Drawing.Size(15, 16);
            this.labelInterpolationGaussMethodFxValue.TabIndex = 39;
            this.labelInterpolationGaussMethodFxValue.Text = "0";
            this.labelInterpolationGaussMethodFxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInterpolationGaussMethodFx
            // 
            this.labelInterpolationGaussMethodFx.AutoEllipsis = true;
            this.labelInterpolationGaussMethodFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationGaussMethodFx.Location = new System.Drawing.Point(20, 223);
            this.labelInterpolationGaussMethodFx.Name = "labelInterpolationGaussMethodFx";
            this.labelInterpolationGaussMethodFx.Size = new System.Drawing.Size(161, 58);
            this.labelInterpolationGaussMethodFx.TabIndex = 38;
            this.labelInterpolationGaussMethodFx.Text = "Interpolation by Gauss Method f(x) = ";
            this.labelInterpolationGaussMethodFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInputEpsylon
            // 
            this.labelInputEpsylon.AutoEllipsis = true;
            this.labelInputEpsylon.AutoSize = true;
            this.labelInputEpsylon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputEpsylon.Location = new System.Drawing.Point(66, 95);
            this.labelInputEpsylon.Name = "labelInputEpsylon";
            this.labelInputEpsylon.Size = new System.Drawing.Size(90, 16);
            this.labelInputEpsylon.TabIndex = 37;
            this.labelInputEpsylon.Text = "Input epsylon:";
            this.labelInputEpsylon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEpsylon
            // 
            this.textBoxEpsylon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEpsylon.Location = new System.Drawing.Point(189, 95);
            this.textBoxEpsylon.Name = "textBoxEpsylon";
            this.textBoxEpsylon.Size = new System.Drawing.Size(100, 26);
            this.textBoxEpsylon.TabIndex = 27;
            this.textBoxEpsylon.Text = "1e-3";
            // 
            // labelFxValue
            // 
            this.labelFxValue.AutoEllipsis = true;
            this.labelFxValue.AutoSize = true;
            this.labelFxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFxValue.Location = new System.Drawing.Point(197, 281);
            this.labelFxValue.Name = "labelFxValue";
            this.labelFxValue.Size = new System.Drawing.Size(15, 16);
            this.labelFxValue.TabIndex = 36;
            this.labelFxValue.Text = "0";
            this.labelFxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInterpolationNewtonMethodFxValue
            // 
            this.labelInterpolationNewtonMethodFxValue.AutoEllipsis = true;
            this.labelInterpolationNewtonMethodFxValue.AutoSize = true;
            this.labelInterpolationNewtonMethodFxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationNewtonMethodFxValue.Location = new System.Drawing.Point(197, 183);
            this.labelInterpolationNewtonMethodFxValue.Name = "labelInterpolationNewtonMethodFxValue";
            this.labelInterpolationNewtonMethodFxValue.Size = new System.Drawing.Size(15, 16);
            this.labelInterpolationNewtonMethodFxValue.TabIndex = 35;
            this.labelInterpolationNewtonMethodFxValue.Text = "0";
            this.labelInterpolationNewtonMethodFxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFx
            // 
            this.labelFx.AutoEllipsis = true;
            this.labelFx.AutoSize = true;
            this.labelFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFx.Location = new System.Drawing.Point(131, 281);
            this.labelFx.Name = "labelFx";
            this.labelFx.Size = new System.Drawing.Size(38, 16);
            this.labelFx.TabIndex = 34;
            this.labelFx.Text = "f(x) = ";
            this.labelFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(105, 127);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 34);
            this.buttonCalculate.TabIndex = 29;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelInterpolationNewtonMethodFx
            // 
            this.labelInterpolationNewtonMethodFx.AutoEllipsis = true;
            this.labelInterpolationNewtonMethodFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInterpolationNewtonMethodFx.Location = new System.Drawing.Point(20, 164);
            this.labelInterpolationNewtonMethodFx.Name = "labelInterpolationNewtonMethodFx";
            this.labelInterpolationNewtonMethodFx.Size = new System.Drawing.Size(171, 59);
            this.labelInterpolationNewtonMethodFx.TabIndex = 33;
            this.labelInterpolationNewtonMethodFx.Text = "Interpolation by Newton Method f(x) = ";
            this.labelInterpolationNewtonMethodFx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelN
            // 
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(232, 9);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(83, 34);
            this.labelN.TabIndex = 32;
            this.labelN.Text = "N = ";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(132, 9);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(83, 34);
            this.labelB.TabIndex = 31;
            this.labelB.Text = "b = ";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(43, 9);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(83, 34);
            this.labelA.TabIndex = 30;
            this.labelA.Text = "a = ";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInputX
            // 
            this.labelInputX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputX.Location = new System.Drawing.Point(73, 43);
            this.labelInputX.Name = "labelInputX";
            this.labelInputX.Size = new System.Drawing.Size(83, 34);
            this.labelInputX.TabIndex = 28;
            this.labelInputX.Text = "Input x:";
            this.labelInputX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(189, 47);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 26);
            this.textBoxX.TabIndex = 26;
            this.textBoxX.Text = "1,5";
            // 
            // chartInterpolation
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInterpolation.ChartAreas.Add(chartArea1);
            this.chartInterpolation.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend4";
            this.chartInterpolation.Legends.Add(legend1);
            this.chartInterpolation.Location = new System.Drawing.Point(3, 3);
            this.chartInterpolation.Name = "chartInterpolation";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend4";
            series1.Name = "Newton interpolation";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend4";
            series2.Name = "Gauss interpolation";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend4";
            series3.MarkerSize = 15;
            series3.Name = "Nodes";
            this.chartInterpolation.Series.Add(series1);
            this.chartInterpolation.Series.Add(series2);
            this.chartInterpolation.Series.Add(series3);
            this.chartInterpolation.Size = new System.Drawing.Size(639, 637);
            this.chartInterpolation.TabIndex = 1;
            this.chartInterpolation.Text = "chart1";
            // 
            // FormFunctionsInterpolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1021, 681);
            this.Name = "FormFunctionsInterpolation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolation of functions";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInterpolation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGaussError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNewtonError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGaussDifferences;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNewtonDifferences;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumberIterationNewtonMethodValue;
        private System.Windows.Forms.Label labelNumberIterationGaussMethodValue;
        private System.Windows.Forms.Label labelNumberIterationGaussMethod;
        private System.Windows.Forms.Label labelNumberIterationNewtonMethod;
        private System.Windows.Forms.Label labelInterpolationGaussMethodFxValue;
        private System.Windows.Forms.Label labelInterpolationGaussMethodFx;
        private System.Windows.Forms.Label labelInputEpsylon;
        private System.Windows.Forms.TextBox textBoxEpsylon;
        private System.Windows.Forms.Label labelFxValue;
        private System.Windows.Forms.Label labelInterpolationNewtonMethodFxValue;
        private System.Windows.Forms.Label labelFx;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelInterpolationNewtonMethodFx;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelInputX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInterpolation;
    }
}

