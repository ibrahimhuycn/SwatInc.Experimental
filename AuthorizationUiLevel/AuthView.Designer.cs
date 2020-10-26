namespace AuthorizationUiLevel
{
    partial class AuthView
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
            this.buttonRevokeAllAccess = new System.Windows.Forms.Button();
            this.buttonGrantViewOneAccess = new System.Windows.Forms.Button();
            this.buttonGrantViewTwoAccess = new System.Windows.Forms.Button();
            this.buttonGrantButton1Access = new System.Windows.Forms.Button();
            this.buttonButton2Access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRevokeAllAccess
            // 
            this.buttonRevokeAllAccess.Location = new System.Drawing.Point(9, 9);
            this.buttonRevokeAllAccess.Name = "buttonRevokeAllAccess";
            this.buttonRevokeAllAccess.Size = new System.Drawing.Size(117, 23);
            this.buttonRevokeAllAccess.TabIndex = 0;
            this.buttonRevokeAllAccess.Text = "Revoke All Access";
            this.buttonRevokeAllAccess.UseVisualStyleBackColor = true;
            this.buttonRevokeAllAccess.Click += new System.EventHandler(this.buttonRevokeAllAccess_Click);
            // 
            // buttonGrantViewOneAccess
            // 
            this.buttonGrantViewOneAccess.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonGrantViewOneAccess.Location = new System.Drawing.Point(9, 38);
            this.buttonGrantViewOneAccess.Name = "buttonGrantViewOneAccess";
            this.buttonGrantViewOneAccess.Size = new System.Drawing.Size(117, 23);
            this.buttonGrantViewOneAccess.TabIndex = 1;
            this.buttonGrantViewOneAccess.Text = "Grant ViewOne Access";
            this.buttonGrantViewOneAccess.UseVisualStyleBackColor = true;
            this.buttonGrantViewOneAccess.Click += new System.EventHandler(this.buttonGrantViewOneAccess_Click);
            // 
            // buttonGrantViewTwoAccess
            // 
            this.buttonGrantViewTwoAccess.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonGrantViewTwoAccess.Location = new System.Drawing.Point(9, 67);
            this.buttonGrantViewTwoAccess.Name = "buttonGrantViewTwoAccess";
            this.buttonGrantViewTwoAccess.Size = new System.Drawing.Size(117, 23);
            this.buttonGrantViewTwoAccess.TabIndex = 2;
            this.buttonGrantViewTwoAccess.Text = "Grant ViewTwo Access";
            this.buttonGrantViewTwoAccess.UseVisualStyleBackColor = true;
            this.buttonGrantViewTwoAccess.Click += new System.EventHandler(this.buttonGrantViewTwoAccess_Click);
            // 
            // buttonGrantButton1Access
            // 
            this.buttonGrantButton1Access.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonGrantButton1Access.Location = new System.Drawing.Point(153, 38);
            this.buttonGrantButton1Access.Name = "buttonGrantButton1Access";
            this.buttonGrantButton1Access.Size = new System.Drawing.Size(154, 23);
            this.buttonGrantButton1Access.TabIndex = 3;
            this.buttonGrantButton1Access.Text = "Grant Button1 Access";
            this.buttonGrantButton1Access.UseVisualStyleBackColor = true;
            this.buttonGrantButton1Access.Click += new System.EventHandler(this.buttonGrantButton1Access_Click);
            // 
            // buttonButton2Access
            // 
            this.buttonButton2Access.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonButton2Access.Location = new System.Drawing.Point(153, 67);
            this.buttonButton2Access.Name = "buttonButton2Access";
            this.buttonButton2Access.Size = new System.Drawing.Size(154, 23);
            this.buttonButton2Access.TabIndex = 4;
            this.buttonButton2Access.Text = "Grant Button2 Access";
            this.buttonButton2Access.UseVisualStyleBackColor = true;
            this.buttonButton2Access.Click += new System.EventHandler(this.buttonButton2Access_Click);
            // 
            // AuthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 114);
            this.Controls.Add(this.buttonButton2Access);
            this.Controls.Add(this.buttonGrantButton1Access);
            this.Controls.Add(this.buttonGrantViewTwoAccess);
            this.Controls.Add(this.buttonGrantViewOneAccess);
            this.Controls.Add(this.buttonRevokeAllAccess);
            this.Name = "AuthView";
            this.Text = "AuthView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRevokeAllAccess;
        private System.Windows.Forms.Button buttonGrantViewOneAccess;
        private System.Windows.Forms.Button buttonGrantViewTwoAccess;
        private System.Windows.Forms.Button buttonGrantButton1Access;
        private System.Windows.Forms.Button buttonButton2Access;
    }
}