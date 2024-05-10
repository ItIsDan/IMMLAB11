
namespace Lab_11
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startBut = new System.Windows.Forms.Button();
            this.MeanNmd = new System.Windows.Forms.NumericUpDown();
            this.VarNmd = new System.Windows.Forms.NumericUpDown();
            this.SizeNmd = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverLabel = new System.Windows.Forms.Label();
            this.VarLabel = new System.Windows.Forms.Label();
            this.ChiLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MeanNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of experiments";
            // 
            // startBut
            // 
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startBut.Location = new System.Drawing.Point(24, 111);
            this.startBut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(121, 57);
            this.startBut.TabIndex = 3;
            this.startBut.Text = "Generate";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // MeanNmd
            // 
            this.MeanNmd.DecimalPlaces = 3;
            this.MeanNmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MeanNmd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MeanNmd.Location = new System.Drawing.Point(144, 24);
            this.MeanNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MeanNmd.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.MeanNmd.Name = "MeanNmd";
            this.MeanNmd.Size = new System.Drawing.Size(94, 20);
            this.MeanNmd.TabIndex = 4;
            this.MeanNmd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // VarNmd
            // 
            this.VarNmd.DecimalPlaces = 1;
            this.VarNmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VarNmd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.VarNmd.Location = new System.Drawing.Point(144, 50);
            this.VarNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VarNmd.Name = "VarNmd";
            this.VarNmd.Size = new System.Drawing.Size(94, 20);
            this.VarNmd.TabIndex = 5;
            this.VarNmd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeNmd
            // 
            this.SizeNmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SizeNmd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNmd.InterceptArrowKeys = false;
            this.SizeNmd.Location = new System.Drawing.Point(144, 76);
            this.SizeNmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SizeNmd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SizeNmd.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNmd.Name = "SizeNmd";
            this.SizeNmd.Size = new System.Drawing.Size(94, 20);
            this.SizeNmd.TabIndex = 6;
            this.SizeNmd.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea2.AxisY2.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(246, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(655, 439);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // AverLabel
            // 
            this.AverLabel.AutoSize = true;
            this.AverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AverLabel.Location = new System.Drawing.Point(107, 196);
            this.AverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverLabel.Name = "AverLabel";
            this.AverLabel.Size = new System.Drawing.Size(0, 13);
            this.AverLabel.TabIndex = 8;
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.VarLabel.Location = new System.Drawing.Point(107, 224);
            this.VarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(0, 13);
            this.VarLabel.TabIndex = 9;
            // 
            // ChiLabel
            // 
            this.ChiLabel.AutoSize = true;
            this.ChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ChiLabel.Location = new System.Drawing.Point(107, 253);
            this.ChiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChiLabel.Name = "ChiLabel";
            this.ChiLabel.Size = new System.Drawing.Size(0, 13);
            this.ChiLabel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(21, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Average is: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.Location = new System.Drawing.Point(21, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Variance is:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(21, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "ChiSquare is:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 475);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ChiLabel);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.AverLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.SizeNmd);
            this.Controls.Add(this.VarNmd);
            this.Controls.Add(this.MeanNmd);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MeanNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VarNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.NumericUpDown MeanNmd;
        private System.Windows.Forms.NumericUpDown VarNmd;
        private System.Windows.Forms.NumericUpDown SizeNmd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label AverLabel;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.Label ChiLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

