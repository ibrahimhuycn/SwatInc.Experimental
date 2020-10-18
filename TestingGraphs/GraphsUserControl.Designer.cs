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
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.checkEditEnableGraphLabels = new DevExpress.XtraEditors.CheckEdit();
            this.toggleSwitchResultsAndResultsWithDates = new DevExpress.XtraEditors.ToggleSwitch();
            this.rangeTrackBarControl1 = new DevExpress.XtraEditors.RangeTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEnableGraphLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchResultsAndResultsWithDates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // testHistoryChartControl
            // 
            this.testHistoryChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testHistoryChartControl.Legend.Name = "Default Legend";
            this.testHistoryChartControl.Location = new System.Drawing.Point(0, 0);
            this.testHistoryChartControl.Name = "testHistoryChartControl";
            this.testHistoryChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.testHistoryChartControl.Size = new System.Drawing.Size(470, 184);
            this.testHistoryChartControl.TabIndex = 1;
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Horizontal = false;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Panel1.Controls.Add(this.rangeTrackBarControl1);
            this.splitContainerControl.Panel1.Controls.Add(this.toggleSwitchResultsAndResultsWithDates);
            this.splitContainerControl.Panel1.Controls.Add(this.checkEditEnableGraphLabels);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.testHistoryChartControl);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(470, 284);
            this.splitContainerControl.SplitterPosition = 95;
            this.splitContainerControl.TabIndex = 2;
            // 
            // checkEditEnableGraphLabels
            // 
            this.checkEditEnableGraphLabels.EditValue = true;
            this.checkEditEnableGraphLabels.Location = new System.Drawing.Point(16, 67);
            this.checkEditEnableGraphLabels.Name = "checkEditEnableGraphLabels";
            this.checkEditEnableGraphLabels.Properties.Caption = "Enable Graph Labels";
            this.checkEditEnableGraphLabels.Size = new System.Drawing.Size(132, 19);
            this.checkEditEnableGraphLabels.TabIndex = 0;
            // 
            // toggleSwitchResultsAndResultsWithDates
            // 
            this.toggleSwitchResultsAndResultsWithDates.EditValue = true;
            this.toggleSwitchResultsAndResultsWithDates.Location = new System.Drawing.Point(154, 65);
            this.toggleSwitchResultsAndResultsWithDates.Name = "toggleSwitchResultsAndResultsWithDates";
            this.toggleSwitchResultsAndResultsWithDates.Properties.OffText = "Results";
            this.toggleSwitchResultsAndResultsWithDates.Properties.OnText = "Results with Result Dates";
            this.toggleSwitchResultsAndResultsWithDates.Size = new System.Drawing.Size(205, 24);
            this.toggleSwitchResultsAndResultsWithDates.TabIndex = 1;
            // 
            // rangeTrackBarControl1
            // 
            this.rangeTrackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rangeTrackBarControl1.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            this.rangeTrackBarControl1.Location = new System.Drawing.Point(16, 16);
            this.rangeTrackBarControl1.Name = "rangeTrackBarControl1";
            this.rangeTrackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.rangeTrackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rangeTrackBarControl1.Properties.ShowLabels = true;
            this.rangeTrackBarControl1.Size = new System.Drawing.Size(437, 45);
            this.rangeTrackBarControl1.TabIndex = 2;
            // 
            // GraphsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl);
            this.Name = "GraphsUserControl";
            this.Size = new System.Drawing.Size(470, 284);
            ((System.ComponentModel.ISupportInitialize)(this.testHistoryChartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEnableGraphLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchResultsAndResultsWithDates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeTrackBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl testHistoryChartControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitchResultsAndResultsWithDates;
        private DevExpress.XtraEditors.CheckEdit checkEditEnableGraphLabels;
        private DevExpress.XtraEditors.RangeTrackBarControl rangeTrackBarControl1;
    }
}
