namespace WaitForms
{
    partial class AuthenticationUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationUI));
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlLoginPage = new DevExpress.XtraEditors.PanelControl();
            this.panelControlAuthenticatedMessage = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLoginPage)).BeginInit();
            this.panelControlLoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAuthenticatedMessage)).BeginInit();
            this.panelControlAuthenticatedMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(34, 12);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.NullText = "Username";
            this.textEditUsername.Size = new System.Drawing.Size(212, 36);
            this.textEditUsername.TabIndex = 0;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(34, 54);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.NullText = "Password";
            this.textEditPassword.Size = new System.Drawing.Size(212, 36);
            this.textEditPassword.TabIndex = 1;
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Location = new System.Drawing.Point(71, 96);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(119, 23);
            this.simpleButtonLogin.TabIndex = 2;
            this.simpleButtonLogin.Text = "Login";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // panelControlLoginPage
            // 
            this.panelControlLoginPage.Controls.Add(this.textEditUsername);
            this.panelControlLoginPage.Controls.Add(this.textEditPassword);
            this.panelControlLoginPage.Controls.Add(this.simpleButtonLogin);
            this.panelControlLoginPage.Location = new System.Drawing.Point(1, 2);
            this.panelControlLoginPage.Name = "panelControlLoginPage";
            this.panelControlLoginPage.Size = new System.Drawing.Size(273, 129);
            this.panelControlLoginPage.TabIndex = 3;
            // 
            // panelControlAuthenticatedMessage
            // 
            this.panelControlAuthenticatedMessage.Controls.Add(this.labelControl1);
            this.panelControlAuthenticatedMessage.Controls.Add(this.pictureEdit1);
            this.panelControlAuthenticatedMessage.Location = new System.Drawing.Point(1, 2);
            this.panelControlAuthenticatedMessage.Name = "panelControlAuthenticatedMessage";
            this.panelControlAuthenticatedMessage.Size = new System.Drawing.Size(273, 129);
            this.panelControlAuthenticatedMessage.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(37, 36);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(61, 60);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.AppearanceHovered.Options.UseBackColor = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(104, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "User Authenticated";
            // 
            // AuthenticationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 132);
            this.Controls.Add(this.panelControlAuthenticatedMessage);
            this.Controls.Add(this.panelControlLoginPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticationUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlLoginPage)).EndInit();
            this.panelControlLoginPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlAuthenticatedMessage)).EndInit();
            this.panelControlAuthenticatedMessage.ResumeLayout(false);
            this.panelControlAuthenticatedMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
        private DevExpress.XtraEditors.PanelControl panelControlLoginPage;
        private DevExpress.XtraEditors.PanelControl panelControlAuthenticatedMessage;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

