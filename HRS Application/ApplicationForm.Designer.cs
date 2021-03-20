
namespace HRS_Application
{
    partial class ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRoom = new FontAwesome.Sharp.IconButton();
            this.buttonCustomer = new FontAwesome.Sharp.IconButton();
            this.buttonPrice = new FontAwesome.Sharp.IconButton();
            this.buttonBilling = new FontAwesome.Sharp.IconButton();
            this.buttonReservation = new FontAwesome.Sharp.IconButton();
            this.buttonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonCloseWin = new FontAwesome.Sharp.IconButton();
            this.buttonRestoreWin = new FontAwesome.Sharp.IconButton();
            this.buttonMinimizeWin = new FontAwesome.Sharp.IconButton();
            this.labelCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelShadowLeft = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonRoom);
            this.panelMenu.Controls.Add(this.buttonCustomer);
            this.panelMenu.Controls.Add(this.buttonPrice);
            this.panelMenu.Controls.Add(this.buttonBilling);
            this.panelMenu.Controls.Add(this.buttonReservation);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 658);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonRoom
            // 
            this.buttonRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRoom.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.buttonRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(0, 491);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(238, 82);
            this.buttonRoom.TabIndex = 7;
            this.buttonRoom.Text = "Rooms";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.buttonCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(0, 409);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(238, 82);
            this.buttonCustomer.TabIndex = 6;
            this.buttonCustomer.Text = "Customer Info";
            this.buttonCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPrice.FlatAppearance.BorderSize = 0;
            this.buttonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrice.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPrice.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.buttonPrice.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrice.Location = new System.Drawing.Point(0, 327);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(238, 82);
            this.buttonPrice.TabIndex = 5;
            this.buttonPrice.Text = "Price Estimation";
            this.buttonPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonBilling
            // 
            this.buttonBilling.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBilling.FlatAppearance.BorderSize = 0;
            this.buttonBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBilling.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBilling.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBilling.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.buttonBilling.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonBilling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBilling.Location = new System.Drawing.Point(0, 245);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(238, 82);
            this.buttonBilling.TabIndex = 4;
            this.buttonBilling.Text = "Billing";
            this.buttonBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBilling.UseVisualStyleBackColor = true;
            this.buttonBilling.Click += new System.EventHandler(this.buttonBilling_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReservation.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.buttonReservation.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(0, 163);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(238, 82);
            this.buttonReservation.TabIndex = 2;
            this.buttonReservation.Text = "Reservations";
            this.buttonReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.buttonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 81);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(238, 82);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(238, 81);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(6, 6);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(226, 66);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 0;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.buttonCloseWin);
            this.panelTitleBar.Controls.Add(this.buttonRestoreWin);
            this.panelTitleBar.Controls.Add(this.buttonMinimizeWin);
            this.panelTitleBar.Controls.Add(this.labelCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(238, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1113, 50);
            this.panelTitleBar.TabIndex = 1;
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
            this.buttonCloseWin.Location = new System.Drawing.Point(999, 0);
            this.buttonCloseWin.Name = "buttonCloseWin";
            this.buttonCloseWin.Size = new System.Drawing.Size(38, 50);
            this.buttonCloseWin.TabIndex = 4;
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
            this.buttonRestoreWin.Location = new System.Drawing.Point(1037, 0);
            this.buttonRestoreWin.Name = "buttonRestoreWin";
            this.buttonRestoreWin.Size = new System.Drawing.Size(38, 50);
            this.buttonRestoreWin.TabIndex = 3;
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
            this.buttonMinimizeWin.Location = new System.Drawing.Point(1075, 0);
            this.buttonMinimizeWin.Name = "buttonMinimizeWin";
            this.buttonMinimizeWin.Size = new System.Drawing.Size(38, 50);
            this.buttonMinimizeWin.TabIndex = 2;
            this.buttonMinimizeWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimizeWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimizeWin.UseVisualStyleBackColor = true;
            this.buttonMinimizeWin.Click += new System.EventHandler(this.buttonMinimizeWin_Click);
            // 
            // labelCurrentChildForm
            // 
            this.labelCurrentChildForm.AutoSize = true;
            this.labelCurrentChildForm.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentChildForm.Location = new System.Drawing.Point(62, 9);
            this.labelCurrentChildForm.Name = "labelCurrentChildForm";
            this.labelCurrentChildForm.Size = new System.Drawing.Size(108, 24);
            this.labelCurrentChildForm.TabIndex = 1;
            this.labelCurrentChildForm.Text = "Dashboard";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 38;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 6);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 38);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Gainsboro;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(238, 50);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1113, 5);
            this.panelShadow.TabIndex = 2;
            // 
            // panelShadowLeft
            // 
            this.panelShadowLeft.AutoScroll = true;
            this.panelShadowLeft.BackColor = System.Drawing.Color.Gainsboro;
            this.panelShadowLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShadowLeft.Location = new System.Drawing.Point(238, 55);
            this.panelShadowLeft.Name = "panelShadowLeft";
            this.panelShadowLeft.Size = new System.Drawing.Size(5, 603);
            this.panelShadowLeft.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(243, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1108, 603);
            this.panelDesktop.TabIndex = 4;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1351, 658);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadowLeft);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ApplicationForm";
            this.Text = " Hotel Reservation System";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton buttonPrice;
        private FontAwesome.Sharp.IconButton buttonBilling;
        private FontAwesome.Sharp.IconButton buttonReservation;
        private FontAwesome.Sharp.IconButton buttonCustomer;
        private FontAwesome.Sharp.IconButton buttonRoom;
        private FontAwesome.Sharp.IconButton buttonDashboard;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelShadowLeft;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton buttonMinimizeWin;
        private FontAwesome.Sharp.IconButton buttonRestoreWin;
        private FontAwesome.Sharp.IconButton buttonCloseWin;
    }
}