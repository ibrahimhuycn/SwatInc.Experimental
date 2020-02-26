namespace SmsUI
{
    partial class OnlineSMS
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
            this.textBoxSenderNumber = new System.Windows.Forms.TextBox();
            this.textBoxTextMessage = new System.Windows.Forms.TextBox();
            this.textBoxReceiverNumber = new System.Windows.Forms.TextBox();
            this.buttonSendSMS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSenderNumber
            // 
            this.textBoxSenderNumber.Location = new System.Drawing.Point(12, 29);
            this.textBoxSenderNumber.Name = "textBoxSenderNumber";
            this.textBoxSenderNumber.Size = new System.Drawing.Size(126, 20);
            this.textBoxSenderNumber.TabIndex = 0;
            // 
            // textBoxTextMessage
            // 
            this.textBoxTextMessage.Location = new System.Drawing.Point(12, 85);
            this.textBoxTextMessage.Multiline = true;
            this.textBoxTextMessage.Name = "textBoxTextMessage";
            this.textBoxTextMessage.Size = new System.Drawing.Size(262, 70);
            this.textBoxTextMessage.TabIndex = 1;
            // 
            // textBoxReceiverNumber
            // 
            this.textBoxReceiverNumber.Location = new System.Drawing.Point(148, 29);
            this.textBoxReceiverNumber.Name = "textBoxReceiverNumber";
            this.textBoxReceiverNumber.Size = new System.Drawing.Size(126, 20);
            this.textBoxReceiverNumber.TabIndex = 2;
            // 
            // buttonSendSMS
            // 
            this.buttonSendSMS.Location = new System.Drawing.Point(12, 176);
            this.buttonSendSMS.Name = "buttonSendSMS";
            this.buttonSendSMS.Size = new System.Drawing.Size(262, 23);
            this.buttonSendSMS.TabIndex = 3;
            this.buttonSendSMS.Text = "Send SMS";
            this.buttonSendSMS.UseVisualStyleBackColor = true;
            this.buttonSendSMS.Click += new System.EventHandler(this.buttonSendSMS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sender Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(145, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Receiver Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Text Message";
            // 
            // TwilioSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendSMS);
            this.Controls.Add(this.textBoxReceiverNumber);
            this.Controls.Add(this.textBoxTextMessage);
            this.Controls.Add(this.textBoxSenderNumber);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TwilioSMS";
            this.Text = "Twilio SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSenderNumber;
        private System.Windows.Forms.TextBox textBoxTextMessage;
        private System.Windows.Forms.TextBox textBoxReceiverNumber;
        private System.Windows.Forms.Button buttonSendSMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

