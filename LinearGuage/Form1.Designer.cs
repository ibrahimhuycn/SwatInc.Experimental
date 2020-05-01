namespace LinearGuage
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
            Syncfusion.Windows.Forms.Gauge.LinearRange linearRange1 = new Syncfusion.Windows.Forms.Gauge.LinearRange();
            this.linearGauge1 = new Syncfusion.Windows.Forms.Gauge.LinearGauge();
            this.SuspendLayout();
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundGradientEndColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.BackgroundGradientStartColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.ForeColor = System.Drawing.Color.Gray;
            this.linearGauge1.GaugelabelFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGauge1.InnerFrameGradientEndColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.InnerFrameGradientStartColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.LinearFrameType = Syncfusion.Windows.Forms.Gauge.LinearFrameType.Horizontal;
            this.linearGauge1.Location = new System.Drawing.Point(48, 36);
            this.linearGauge1.MajorTicksHeight = 5;
            this.linearGauge1.MinimumSize = new System.Drawing.Size(100, 50);
            this.linearGauge1.MinorTickCount = 5;
            this.linearGauge1.MinorTickHeight = 10;
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.OuterFrameGradientEndColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.OuterFrameGradientStartColor = System.Drawing.SystemColors.Control;
            this.linearGauge1.PointerPlacement = Syncfusion.Windows.Forms.Gauge.Placement.Center;
            linearRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            linearRange1.EndValue = 50F;
            linearRange1.Height = 5;
            linearRange1.InRange = false;
            linearRange1.Name = "GaugeRange1";
            linearRange1.RangePlacement = Syncfusion.Windows.Forms.Gauge.TickPlacement.Inside;
            linearRange1.StartValue = 0F;
            this.linearGauge1.Ranges.Add(linearRange1);
            this.linearGauge1.ScaleColor = System.Drawing.Color.Gray;
            this.linearGauge1.Size = new System.Drawing.Size(418, 50);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            this.linearGauge1.Value = 100F;
            this.linearGauge1.ValueIndicatorColor = System.Drawing.Color.Gray;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 214);
            this.Controls.Add(this.linearGauge1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
    }
}

