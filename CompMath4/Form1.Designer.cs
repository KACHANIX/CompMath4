namespace CompMath3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FirstX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Precision = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Func = new System.Windows.Forms.DomainUpDown();
            this.Build = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.LastX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FirstX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastX)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstX
            // 
            this.FirstX.Location = new System.Drawing.Point(12, 96);
            this.FirstX.Name = "FirstX";
            this.FirstX.Size = new System.Drawing.Size(55, 20);
            this.FirstX.TabIndex = 0;
            this.FirstX.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstY
            // 
            this.FirstY.Location = new System.Drawing.Point(93, 96);
            this.FirstY.Name = "FirstY";
            this.FirstY.Size = new System.Drawing.Size(55, 20);
            this.FirstY.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Точность";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Precision
            // 
            this.Precision.Location = new System.Drawing.Point(55, 221);
            this.Precision.Name = "Precision";
            this.Precision.Size = new System.Drawing.Size(49, 20);
            this.Precision.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Функция";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Func
            // 
            this.Func.Location = new System.Drawing.Point(12, 37);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(79, 20);
            this.Func.TabIndex = 7;
            this.Func.SelectedItemChanged += new System.EventHandler(this.Func_SelectedItemChanged);
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(21, 292);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(105, 23);
            this.Build.TabIndex = 8;
            this.Build.Text = "Построить";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Interpolate_Click);
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(192, -1);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(1221, 810);
            this.Chart.TabIndex = 9;
            this.Chart.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "xFinal";
            // 
            // LastX
            // 
            this.LastX.Location = new System.Drawing.Point(55, 153);
            this.LastX.Name = "LastX";
            this.LastX.Size = new System.Drawing.Size(55, 20);
            this.LastX.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 810);
            this.Controls.Add(this.LastX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Func);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Precision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FirstX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Precision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        public System.Windows.Forms.NumericUpDown FirstX;
        public System.Windows.Forms.NumericUpDown FirstY;
        public System.Windows.Forms.NumericUpDown Precision;
        public System.Windows.Forms.DomainUpDown Func;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LastX;
    }
}

