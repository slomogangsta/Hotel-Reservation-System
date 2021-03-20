
namespace HRS_Application
{
    partial class FormHistory
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonCloseWin = new FontAwesome.Sharp.IconButton();
            this.buttonRestoreWin = new FontAwesome.Sharp.IconButton();
            this.buttonMinimizeWin = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.buttonCloseWin);
            this.panelTitleBar.Controls.Add(this.buttonRestoreWin);
            this.panelTitleBar.Controls.Add(this.buttonMinimizeWin);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1327, 50);
            this.panelTitleBar.TabIndex = 8;
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
            this.buttonCloseWin.Location = new System.Drawing.Point(1213, 0);
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
            this.buttonRestoreWin.Location = new System.Drawing.Point(1251, 0);
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
            this.buttonMinimizeWin.Location = new System.Drawing.Point(1289, 0);
            this.buttonMinimizeWin.Name = "buttonMinimizeWin";
            this.buttonMinimizeWin.Size = new System.Drawing.Size(38, 50);
            this.buttonMinimizeWin.TabIndex = 5;
            this.buttonMinimizeWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMinimizeWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimizeWin.UseVisualStyleBackColor = true;
            this.buttonMinimizeWin.Click += new System.EventHandler(this.buttonMinimizeWin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 558);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1327, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "FormHistory";
            this.Text = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonCloseWin;
        private FontAwesome.Sharp.IconButton buttonRestoreWin;
        private FontAwesome.Sharp.IconButton buttonMinimizeWin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}