
namespace HRS_Application
{
    partial class LandingPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonCloseWin = new FontAwesome.Sharp.IconButton();
            this.buttonRestoreWin = new FontAwesome.Sharp.IconButton();
            this.buttonMinimizeWin = new FontAwesome.Sharp.IconButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLoginHeader = new System.Windows.Forms.Label();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelLogin.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogin.Controls.Add(this.panelTitleBar);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelForgotPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.labelLoginHeader);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1351, 658);
            this.panelLogin.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.buttonCloseWin);
            this.panelTitleBar.Controls.Add(this.buttonRestoreWin);
            this.panelTitleBar.Controls.Add(this.buttonMinimizeWin);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1351, 50);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonCloseWin
            // 
            this.buttonCloseWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseWin.FlatAppearance.BorderSize = 0;
            this.buttonCloseWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseWin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCloseWin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCloseWin.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonCloseWin.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonCloseWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCloseWin.IconSize = 30;
            this.buttonCloseWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCloseWin.Location = new System.Drawing.Point(1237, 0);
            this.buttonCloseWin.Name = "buttonCloseWin";
            this.buttonCloseWin.Size = new System.Drawing.Size(38, 50);
            this.buttonCloseWin.TabIndex = 7;
            this.buttonCloseWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCloseWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCloseWin.UseVisualStyleBackColor = true;
            this.buttonCloseWin.Click += new System.EventHandler(this.buttonCloseWin_Click);
            // 
            // buttonRestoreWin
            // 
            this.buttonRestoreWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRestoreWin.FlatAppearance.BorderSize = 0;
            this.buttonRestoreWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreWin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRestoreWin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestoreWin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonRestoreWin.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonRestoreWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRestoreWin.IconSize = 30;
            this.buttonRestoreWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestoreWin.Location = new System.Drawing.Point(1275, 0);
            this.buttonRestoreWin.Name = "buttonRestoreWin";
            this.buttonRestoreWin.Size = new System.Drawing.Size(38, 50);
            this.buttonRestoreWin.TabIndex = 6;
            this.buttonRestoreWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestoreWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestoreWin.UseVisualStyleBackColor = true;
            this.buttonRestoreWin.Click += new System.EventHandler(this.buttonRestoreWin_Click);
            // 
            // buttonMinimizeWin
            // 
            this.buttonMinimizeWin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizeWin.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeWin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimizeWin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMinimizeWin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimizeWin.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonMinimizeWin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMinimizeWin.IconSize = 30;
            this.buttonMinimizeWin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimizeWin.Location = new System.Drawing.Point(1313, 0);
            this.buttonMinimizeWin.Name = "buttonMinimizeWin";
            this.buttonMinimizeWin.Size = new System.Drawing.Size(38, 50);
            this.buttonMinimizeWin.TabIndex = 5;
            this.buttonMinimizeWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimizeWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimizeWin.UseVisualStyleBackColor = true;
            this.buttonMinimizeWin.Click += new System.EventHandler(this.buttonMinimizeWin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(551, 315);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "enter your password";
            this.textBoxPassword.Size = new System.Drawing.Size(371, 28);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.password_Validation);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(551, 243);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "enter your usename";
            this.textBoxUsername.Size = new System.Drawing.Size(371, 28);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.username_Validation);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForgotPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelForgotPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelForgotPassword.Location = new System.Drawing.Point(551, 445);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(177, 38);
            this.labelForgotPassword.TabIndex = 4;
            this.labelForgotPassword.Text = "Forgot Password?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(551, 395);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(210, 38);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.Location = new System.Drawing.Point(408, 312);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(118, 38);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.Font = new System.Drawing.Font("Bahnschrift SemiLight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(408, 240);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(118, 38);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelLoginHeader
            // 
            this.labelLoginHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoginHeader.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelLoginHeader.Location = new System.Drawing.Point(424, 162);
            this.labelLoginHeader.Name = "labelLoginHeader";
            this.labelLoginHeader.Size = new System.Drawing.Size(498, 40);
            this.labelLoginHeader.TabIndex = 0;
            this.labelLoginHeader.Text = "Welcome to Hotel Reservation System";
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // LandingPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1351, 658);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "LandingPageForm";
            this.Text = "Hotel Reservation System";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLoginHeader;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonCloseWin;
        private FontAwesome.Sharp.IconButton buttonRestoreWin;
        private FontAwesome.Sharp.IconButton buttonMinimizeWin;
    }
}

