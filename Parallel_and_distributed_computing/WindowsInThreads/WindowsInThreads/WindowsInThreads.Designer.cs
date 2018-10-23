namespace WindowsInThreads
{
    partial class WindowsInThreads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsInThreads));
            this.firstPictureBox = new System.Windows.Forms.PictureBox();
            this.firstButtonStartThread = new System.Windows.Forms.Button();
            this.firstButtonStopThread = new System.Windows.Forms.Button();
            this.secondButtonStopThread = new System.Windows.Forms.Button();
            this.secondButtonStartThread = new System.Windows.Forms.Button();
            this.secondPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdButtonStopThread = new System.Windows.Forms.Button();
            this.thirdButtonStartThread = new System.Windows.Forms.Button();
            this.thirdPictureBox = new System.Windows.Forms.PictureBox();
            this.fourthButtonStopThread = new System.Windows.Forms.Button();
            this.fourthButtonStartThread = new System.Windows.Forms.Button();
            this.fourthPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstPictureBox
            // 
            this.firstPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.firstPictureBox.Location = new System.Drawing.Point(12, 12);
            this.firstPictureBox.Name = "firstPictureBox";
            this.firstPictureBox.Size = new System.Drawing.Size(250, 163);
            this.firstPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.firstPictureBox.TabIndex = 1;
            this.firstPictureBox.TabStop = false;
            // 
            // firstButtonStartThread
            // 
            this.firstButtonStartThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(212)))), ((int)(((byte)(51)))));
            this.firstButtonStartThread.Enabled = false;
            this.firstButtonStartThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstButtonStartThread.Location = new System.Drawing.Point(12, 181);
            this.firstButtonStartThread.Name = "firstButtonStartThread";
            this.firstButtonStartThread.Size = new System.Drawing.Size(112, 57);
            this.firstButtonStartThread.TabIndex = 2;
            this.firstButtonStartThread.Text = "Start in thread";
            this.firstButtonStartThread.UseVisualStyleBackColor = false;
            this.firstButtonStartThread.Click += new System.EventHandler(this.firstButtonStartThread_Click);
            // 
            // firstButtonStopThread
            // 
            this.firstButtonStopThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.firstButtonStopThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstButtonStopThread.Location = new System.Drawing.Point(150, 181);
            this.firstButtonStopThread.Name = "firstButtonStopThread";
            this.firstButtonStopThread.Size = new System.Drawing.Size(112, 57);
            this.firstButtonStopThread.TabIndex = 3;
            this.firstButtonStopThread.Text = "Stop thread";
            this.firstButtonStopThread.UseVisualStyleBackColor = false;
            this.firstButtonStopThread.Click += new System.EventHandler(this.firstButtonStopThread_Click);
            // 
            // secondButtonStopThread
            // 
            this.secondButtonStopThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.secondButtonStopThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondButtonStopThread.Location = new System.Drawing.Point(439, 181);
            this.secondButtonStopThread.Name = "secondButtonStopThread";
            this.secondButtonStopThread.Size = new System.Drawing.Size(112, 57);
            this.secondButtonStopThread.TabIndex = 6;
            this.secondButtonStopThread.Text = "Stop thread";
            this.secondButtonStopThread.UseVisualStyleBackColor = false;
            this.secondButtonStopThread.Click += new System.EventHandler(this.secondButtonStopThread_Click);
            // 
            // secondButtonStartThread
            // 
            this.secondButtonStartThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(212)))), ((int)(((byte)(51)))));
            this.secondButtonStartThread.Enabled = false;
            this.secondButtonStartThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondButtonStartThread.Location = new System.Drawing.Point(301, 181);
            this.secondButtonStartThread.Name = "secondButtonStartThread";
            this.secondButtonStartThread.Size = new System.Drawing.Size(112, 57);
            this.secondButtonStartThread.TabIndex = 5;
            this.secondButtonStartThread.Text = "Start in thread";
            this.secondButtonStartThread.UseVisualStyleBackColor = false;
            this.secondButtonStartThread.Click += new System.EventHandler(this.secondButtonStartThread_Click);
            // 
            // secondPictureBox
            // 
            this.secondPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.secondPictureBox.Location = new System.Drawing.Point(301, 12);
            this.secondPictureBox.Name = "secondPictureBox";
            this.secondPictureBox.Size = new System.Drawing.Size(250, 163);
            this.secondPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secondPictureBox.TabIndex = 4;
            this.secondPictureBox.TabStop = false;
            // 
            // thirdButtonStopThread
            // 
            this.thirdButtonStopThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.thirdButtonStopThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdButtonStopThread.Location = new System.Drawing.Point(150, 430);
            this.thirdButtonStopThread.Name = "thirdButtonStopThread";
            this.thirdButtonStopThread.Size = new System.Drawing.Size(112, 57);
            this.thirdButtonStopThread.TabIndex = 9;
            this.thirdButtonStopThread.Text = "Stop thread";
            this.thirdButtonStopThread.UseVisualStyleBackColor = false;
            this.thirdButtonStopThread.Click += new System.EventHandler(this.thirdButtonStopThread_Click);
            // 
            // thirdButtonStartThread
            // 
            this.thirdButtonStartThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(212)))), ((int)(((byte)(51)))));
            this.thirdButtonStartThread.Enabled = false;
            this.thirdButtonStartThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdButtonStartThread.Location = new System.Drawing.Point(12, 430);
            this.thirdButtonStartThread.Name = "thirdButtonStartThread";
            this.thirdButtonStartThread.Size = new System.Drawing.Size(112, 57);
            this.thirdButtonStartThread.TabIndex = 8;
            this.thirdButtonStartThread.Text = "Start in thread";
            this.thirdButtonStartThread.UseVisualStyleBackColor = false;
            this.thirdButtonStartThread.Click += new System.EventHandler(this.thirdButtonStartThread_Click);
            // 
            // thirdPictureBox
            // 
            this.thirdPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.thirdPictureBox.Location = new System.Drawing.Point(12, 261);
            this.thirdPictureBox.Name = "thirdPictureBox";
            this.thirdPictureBox.Size = new System.Drawing.Size(250, 163);
            this.thirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.thirdPictureBox.TabIndex = 7;
            this.thirdPictureBox.TabStop = false;
            // 
            // fourthButtonStopThread
            // 
            this.fourthButtonStopThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(63)))), ((int)(((byte)(44)))));
            this.fourthButtonStopThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthButtonStopThread.Location = new System.Drawing.Point(439, 430);
            this.fourthButtonStopThread.Name = "fourthButtonStopThread";
            this.fourthButtonStopThread.Size = new System.Drawing.Size(112, 57);
            this.fourthButtonStopThread.TabIndex = 12;
            this.fourthButtonStopThread.Text = "Stop thread";
            this.fourthButtonStopThread.UseVisualStyleBackColor = false;
            this.fourthButtonStopThread.Click += new System.EventHandler(this.fourthButtonStopThread_Click);
            // 
            // fourthButtonStartThread
            // 
            this.fourthButtonStartThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(212)))), ((int)(((byte)(51)))));
            this.fourthButtonStartThread.Enabled = false;
            this.fourthButtonStartThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthButtonStartThread.Location = new System.Drawing.Point(301, 430);
            this.fourthButtonStartThread.Name = "fourthButtonStartThread";
            this.fourthButtonStartThread.Size = new System.Drawing.Size(112, 57);
            this.fourthButtonStartThread.TabIndex = 11;
            this.fourthButtonStartThread.Text = "Start in thread";
            this.fourthButtonStartThread.UseVisualStyleBackColor = false;
            this.fourthButtonStartThread.Click += new System.EventHandler(this.fourthButtonStartThread_Click);
            // 
            // fourthPictureBox
            // 
            this.fourthPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fourthPictureBox.Location = new System.Drawing.Point(301, 261);
            this.fourthPictureBox.Name = "fourthPictureBox";
            this.fourthPictureBox.Size = new System.Drawing.Size(250, 163);
            this.fourthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fourthPictureBox.TabIndex = 10;
            this.fourthPictureBox.TabStop = false;
            // 
            // WindowsInThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(565, 496);
            this.Controls.Add(this.fourthButtonStopThread);
            this.Controls.Add(this.fourthButtonStartThread);
            this.Controls.Add(this.fourthPictureBox);
            this.Controls.Add(this.thirdButtonStopThread);
            this.Controls.Add(this.thirdButtonStartThread);
            this.Controls.Add(this.thirdPictureBox);
            this.Controls.Add(this.secondButtonStopThread);
            this.Controls.Add(this.secondButtonStartThread);
            this.Controls.Add(this.secondPictureBox);
            this.Controls.Add(this.firstButtonStopThread);
            this.Controls.Add(this.firstButtonStartThread);
            this.Controls.Add(this.firstPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(581, 535);
            this.MinimumSize = new System.Drawing.Size(581, 535);
            this.Name = "WindowsInThreads";
            this.Text = "Windows in threads";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowsInThreads_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.firstPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox firstPictureBox;
        private System.Windows.Forms.Button firstButtonStartThread;
        private System.Windows.Forms.Button firstButtonStopThread;
        private System.Windows.Forms.Button secondButtonStopThread;
        private System.Windows.Forms.Button secondButtonStartThread;
        private System.Windows.Forms.PictureBox secondPictureBox;
        private System.Windows.Forms.Button thirdButtonStopThread;
        private System.Windows.Forms.Button thirdButtonStartThread;
        private System.Windows.Forms.PictureBox thirdPictureBox;
        private System.Windows.Forms.Button fourthButtonStopThread;
        private System.Windows.Forms.Button fourthButtonStartThread;
        private System.Windows.Forms.PictureBox fourthPictureBox;
    }
}

