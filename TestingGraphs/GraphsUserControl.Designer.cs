namespace TestingGraphs
{
    partial class GraphsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testHistoryChartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryChartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.testHistoryChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testHistoryChartControl.Legend.Name = "Default Legend";
            this.testHistoryChartControl.Location = new System.Drawing.Point(0, 0);
            this.testHistoryChartControl.Name = "TestHistory";
            this.testHistoryChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.testHistoryChartControl.Size = new System.Drawing.Size(470, 284);
            this.testHistoryChartControl.TabIndex = 1;
            // 
            // GraphsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testHistoryChartControl);
            this.Name = "GraphsUserControl";
            this.Size = new System.Drawing.Size(470, 284);
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryChartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl testHistoryChartControl;
    }
}
