namespace Jitter
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResponseTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numFrequency = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(44, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(44, 25);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(195, 20);
            this.txtIP.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDomain,
            this.colIP,
            this.colTime});
            this.dataGridView.Location = new System.Drawing.Point(12, 139);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(603, 181);
            this.dataGridView.TabIndex = 3;
            // 
            // colDomain
            // 
            this.colDomain.HeaderText = "Domain Name";
            this.colDomain.Name = "colDomain";
            this.colDomain.ReadOnly = true;
            this.colDomain.Width = 250;
            // 
            // colIP
            // 
            this.colIP.HeaderText = "IP Address (IPv4)";
            this.colIP.Name = "colIP";
            this.colIP.ReadOnly = true;
            this.colIP.Width = 180;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Response Time (ms)";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Width = 130;
            // 
            // chartResponseTimes
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Title = "Pings Performed";
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Title = "Response Time (ms)";
            chartArea1.Name = "ChartArea1";
            this.chartResponseTimes.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartResponseTimes.Legends.Add(legend1);
            this.chartResponseTimes.Location = new System.Drawing.Point(12, 326);
            this.chartResponseTimes.Name = "chartResponseTimes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.Legend = "Legend1";
            series1.Name = "Response Time";
            series1.YValuesPerPoint = 4;
            this.chartResponseTimes.Series.Add(series1);
            this.chartResponseTimes.Size = new System.Drawing.Size(603, 199);
            this.chartResponseTimes.TabIndex = 4;
            this.chartResponseTimes.Text = "Response Times";
            // 
            // numFrequency
            // 
            this.numFrequency.Location = new System.Drawing.Point(372, 51);
            this.numFrequency.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numFrequency.Name = "numFrequency";
            this.numFrequency.Size = new System.Drawing.Size(120, 20);
            this.numFrequency.TabIndex = 5;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(372, 25);
            this.numDuration.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 6;
            this.numDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 647);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.numFrequency);
            this.Controls.Add(this.chartResponseTimes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Jitter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResponseTimes;
        private System.Windows.Forms.NumericUpDown numFrequency;
        private System.Windows.Forms.NumericUpDown numDuration;
    }
}

