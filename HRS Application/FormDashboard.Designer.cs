
namespace HRS_Application
{
    partial class FormDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewcheckin = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxActive = new System.Windows.Forms.TextBox();
            this.textBoxAvailable = new System.Windows.Forms.TextBox();
            this.labelOutDate = new System.Windows.Forms.Label();
            this.dateTimePickerOutDate = new System.Windows.Forms.DateTimePicker();
            this.labelInDate = new System.Windows.Forms.Label();
            this.dateTimePickerInDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewpercat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpercat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcheckin
            // 
            this.dataGridViewcheckin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewcheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewcheckin.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewcheckin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewcheckin.Location = new System.Drawing.Point(16, 49);
            this.dataGridViewcheckin.Name = "dataGridViewcheckin";
            this.dataGridViewcheckin.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewcheckin.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewcheckin.RowTemplate.Height = 29;
            this.dataGridViewcheckin.Size = new System.Drawing.Size(721, 215);
            this.dataGridViewcheckin.TabIndex = 0;
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckOut.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(16, 308);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCheckOut.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCheckOut.RowTemplate.Height = 29;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(721, 224);
            this.dataGridViewCheckOut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Today\'s CheckIn Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(193, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Today\'s CheckOut Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(786, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Active Reservations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(802, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Rooms";
            // 
            // textBoxActive
            // 
            this.textBoxActive.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxActive.Location = new System.Drawing.Point(813, 59);
            this.textBoxActive.Name = "textBoxActive";
            this.textBoxActive.Size = new System.Drawing.Size(211, 27);
            this.textBoxActive.TabIndex = 8;
            this.textBoxActive.TextChanged += new System.EventHandler(this.textBoxActive_TextChanged);
            // 
            // textBoxAvailable
            // 
            this.textBoxAvailable.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAvailable.Location = new System.Drawing.Point(813, 267);
            this.textBoxAvailable.Name = "textBoxAvailable";
            this.textBoxAvailable.Size = new System.Drawing.Size(211, 27);
            this.textBoxAvailable.TabIndex = 9;
            // 
            // labelOutDate
            // 
            this.labelOutDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOutDate.AutoSize = true;
            this.labelOutDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOutDate.Location = new System.Drawing.Point(778, 159);
            this.labelOutDate.Name = "labelOutDate";
            this.labelOutDate.Size = new System.Drawing.Size(76, 21);
            this.labelOutDate.TabIndex = 93;
            this.labelOutDate.Text = "Out Date";
            // 
            // dateTimePickerOutDate
            // 
            this.dateTimePickerOutDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOutDate.Location = new System.Drawing.Point(876, 156);
            this.dateTimePickerOutDate.Name = "dateTimePickerOutDate";
            this.dateTimePickerOutDate.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerOutDate.TabIndex = 92;
            this.dateTimePickerOutDate.ValueChanged += new System.EventHandler(this.dateTimePickerOutDate_ValueChanged);
            // 
            // labelInDate
            // 
            this.labelInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInDate.AutoSize = true;
            this.labelInDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInDate.Location = new System.Drawing.Point(778, 110);
            this.labelInDate.Name = "labelInDate";
            this.labelInDate.Size = new System.Drawing.Size(64, 21);
            this.labelInDate.TabIndex = 91;
            this.labelInDate.Text = "In Date";
            // 
            // dateTimePickerInDate
            // 
            this.dateTimePickerInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerInDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerInDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerInDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerInDate.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerInDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePickerInDate.Location = new System.Drawing.Point(876, 107);
            this.dateTimePickerInDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerInDate.MinDate = new System.DateTime(2021, 1, 31, 0, 0, 0, 0);
            this.dateTimePickerInDate.Name = "dateTimePickerInDate";
            this.dateTimePickerInDate.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerInDate.TabIndex = 90;
            this.dateTimePickerInDate.ValueChanged += new System.EventHandler(this.dateTimePickerInDate_ValueChanged);
            // 
            // dataGridViewpercat
            // 
            this.dataGridViewpercat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewpercat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewpercat.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewpercat.Location = new System.Drawing.Point(756, 308);
            this.dataGridViewpercat.Name = "dataGridViewpercat";
            this.dataGridViewpercat.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewpercat.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewpercat.RowTemplate.Height = 29;
            this.dataGridViewpercat.Size = new System.Drawing.Size(322, 224);
            this.dataGridViewpercat.TabIndex = 95;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1090, 530);
            this.Controls.Add(this.dataGridViewpercat);
            this.Controls.Add(this.labelOutDate);
            this.Controls.Add(this.dateTimePickerOutDate);
            this.Controls.Add(this.labelInDate);
            this.Controls.Add(this.dateTimePickerInDate);
            this.Controls.Add(this.textBoxAvailable);
            this.Controls.Add(this.textBoxActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCheckOut);
            this.Controls.Add(this.dataGridViewcheckin);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormDashboard";
            this.Text = "Available Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpercat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcheckin;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxActive;
        private System.Windows.Forms.TextBox textBoxAvailable;
        private System.Windows.Forms.Label labelOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutDate;
        private System.Windows.Forms.Label labelInDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInDate;
        private System.Windows.Forms.DataGridView dataGridViewpercat;
    }
}