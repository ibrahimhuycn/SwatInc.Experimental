namespace DetectCapsLockStatus
{
    partial class FormMain
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
            this.labelCapsLockStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCapsLockStatus
            // 
            this.labelCapsLockStatus.AutoSize = true;
            this.labelCapsLockStatus.Location = new System.Drawing.Point(52, 21);
            this.labelCapsLockStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCapsLockStatus.Name = "labelCapsLockStatus";
            this.labelCapsLockStatus.Size = new System.Drawing.Size(154, 25);
            this.labelCapsLockStatus.TabIndex = 0;
            this.labelCapsLockStatus.Text = "Caps Lock Status";
            this.labelCapsLockStatus.UseWaitCursor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 64);
            this.Controls.Add(this.labelCapsLockStatus);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Detect CAPS LOCK UI";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCapsLockStatus;
    }
}

