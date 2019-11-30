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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartResponseTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblJitter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResponseTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(323, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(203, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(66, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(251, 20);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "www.google.com";
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
            this.dataGridView.Location = new System.Drawing.Point(12, 64);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(605, 285);
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
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MaximumAutoSize = 100F;
            chartArea3.AxisX.Title = "Responses Recieved";
            chartArea3.AxisY.MaximumAutoSize = 100F;
            chartArea3.AxisY.Title = "Response Time (ms)";
            chartArea3.Name = "ChartArea1";
            this.chartResponseTimes.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartResponseTimes.Legends.Add(legend3);
            this.chartResponseTimes.Location = new System.Drawing.Point(12, 403);
            this.chartResponseTimes.Name = "chartResponseTimes";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.Name = "Response Times";
            series3.YValuesPerPoint = 4;
            this.chartResponseTimes.Series.Add(series3);
            this.chartResponseTimes.Size = new System.Drawing.Size(605, 187);
            this.chartResponseTimes.TabIndex = 4;
            this.chartResponseTimes.Text = "Response Times";
            // 
            // numInterval
            // 
            this.numInterval.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(227, 38);
            this.numInterval.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(90, 20);
            this.numInterval.TabIndex = 5;
            this.numInterval.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numIterations
            // 
            this.numIterations.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIterations.Location = new System.Drawing.Point(66, 38);
            this.numIterations.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(90, 20);
            this.numIterations.TabIndex = 6;
            this.numIterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(532, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 46);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(323, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(203, 46);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(48, 13);
            this.lblIP.TabIndex = 9;
            this.lblIP.Text = "Address:";
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(12, 40);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(53, 13);
            this.lblIterations.TabIndex = 10;
            this.lblIterations.Text = "Iterations:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(162, 40);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(59, 13);
            this.lblInterval.TabIndex = 11;
            this.lblInterval.Text = "Delay (ms):";
            // 
            // lblMinimum
            // 
            this.lblMinimum.Location = new System.Drawing.Point(12, 358);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(180, 13);
            this.lblMinimum.TabIndex = 12;
            this.lblMinimum.Text = "Minimum: N/A";
            this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(224, 358);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(180, 13);
            this.lblAverage.TabIndex = 13;
            this.lblAverage.Text = "Average: N/A";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMaximum
            // 
            this.lblMaximum.Location = new System.Drawing.Point(437, 358);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(180, 13);
            this.lblMaximum.TabIndex = 14;
            this.lblMaximum.Text = "Maximum: N/A";
            // 
            // lblJitter
            // 
            this.lblJitter.Location = new System.Drawing.Point(224, 379);
            this.lblJitter.Name = "lblJitter";
            this.lblJitter.Size = new System.Drawing.Size(180, 13);
            this.lblJitter.TabIndex = 15;
            this.lblJitter.Text = "Jitter: N/A";
            this.lblJitter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 602);
            this.Controls.Add(this.lblJitter);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numIterations);
            this.Controls.Add(this.numInterval);
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
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.NumericUpDown numIterations;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblJitter;
    }
}

