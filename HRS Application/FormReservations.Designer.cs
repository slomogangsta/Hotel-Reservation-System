
namespace HRS_Application
{
    partial class FormReservations
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
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.buttonSearchRooms = new System.Windows.Forms.Button();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.labelSearchCustomer = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.dateTimePickerInDate = new System.Windows.Forms.DateTimePicker();
            this.labelInDate = new System.Windows.Forms.Label();
            this.labelOutDate = new System.Windows.Forms.Label();
            this.dateTimePickerOutDate = new System.Windows.Forms.DateTimePicker();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewResvRooms = new System.Windows.Forms.DataGridView();
            this.labelResvNo = new System.Windows.Forms.Label();
            this.textBoxResvNo = new System.Windows.Forms.TextBox();
            this.buttonViewHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 2);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 29;
            this.dataGridViewRooms.Size = new System.Drawing.Size(362, 162);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellClick);
            this.dataGridViewRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRooms_CellContentClick);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(390, 2);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.RowTemplate.Height = 29;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(692, 162);
            this.dataGridViewCustomers.TabIndex = 1;
            this.dataGridViewCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellClick);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.AutoCompleteCustomSource.AddRange(new string[] {
            "Comfort Single Room",
            "Comfort Double Room",
            "Luxury Single Room",
            "Luxury Double Room",
            "Club Suite Room"});
            this.comboBoxRoomType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxRoomType.CausesValidation = false;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRoomType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Comfort Single Room",
            "Comfort Double Room",
            "Luxury Single Room",
            "Luxury Double Room",
            "Club Suite Room"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(111, 179);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(231, 29);
            this.comboBoxRoomType.TabIndex = 25;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomType.Location = new System.Drawing.Point(13, 185);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(92, 21);
            this.labelRoomType.TabIndex = 24;
            this.labelRoomType.Text = "Room Type";
            // 
            // buttonSearchRooms
            // 
            this.buttonSearchRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchRooms.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchRooms.Location = new System.Drawing.Point(390, 175);
            this.buttonSearchRooms.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchRooms.Name = "buttonSearchRooms";
            this.buttonSearchRooms.Size = new System.Drawing.Size(154, 35);
            this.buttonSearchRooms.TabIndex = 64;
            this.buttonSearchRooms.Text = "Search";
            this.buttonSearchRooms.UseVisualStyleBackColor = true;
            this.buttonSearchRooms.Click += new System.EventHandler(this.buttonSearchRooms_Click);
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearchCustomer.CausesValidation = false;
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(624, 179);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(253, 27);
            this.textBoxSearchCustomer.TabIndex = 84;
            // 
            // labelSearchCustomer
            // 
            this.labelSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearchCustomer.AutoSize = true;
            this.labelSearchCustomer.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearchCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSearchCustomer.Location = new System.Drawing.Point(553, 181);
            this.labelSearchCustomer.Name = "labelSearchCustomer";
            this.labelSearchCustomer.Size = new System.Drawing.Size(62, 21);
            this.labelSearchCustomer.TabIndex = 83;
            this.labelSearchCustomer.Text = "Search";
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearchCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSearchCustomer.Location = new System.Drawing.Point(927, 173);
            this.buttonSearchCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(154, 37);
            this.buttonSearchCustomer.TabIndex = 85;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // dateTimePickerInDate
            // 
            this.dateTimePickerInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerInDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerInDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerInDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dateTimePickerInDate.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerInDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePickerInDate.Location = new System.Drawing.Point(111, 229);
            this.dateTimePickerInDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerInDate.MinDate = new System.DateTime(2021, 1, 31, 0, 0, 0, 0);
            this.dateTimePickerInDate.Name = "dateTimePickerInDate";
            this.dateTimePickerInDate.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerInDate.TabIndex = 86;
            this.dateTimePickerInDate.ValueChanged += new System.EventHandler(this.dateTimePickerInDate_ValueChanged);
            // 
            // labelInDate
            // 
            this.labelInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInDate.AutoSize = true;
            this.labelInDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelInDate.Location = new System.Drawing.Point(13, 232);
            this.labelInDate.Name = "labelInDate";
            this.labelInDate.Size = new System.Drawing.Size(64, 21);
            this.labelInDate.TabIndex = 87;
            this.labelInDate.Text = "In Date";
            this.labelInDate.Click += new System.EventHandler(this.labelInDate_Click);
            // 
            // labelOutDate
            // 
            this.labelOutDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOutDate.AutoSize = true;
            this.labelOutDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOutDate.Location = new System.Drawing.Point(313, 231);
            this.labelOutDate.Name = "labelOutDate";
            this.labelOutDate.Size = new System.Drawing.Size(76, 21);
            this.labelOutDate.TabIndex = 89;
            this.labelOutDate.Text = "Out Date";
            this.labelOutDate.Click += new System.EventHandler(this.labelOutDate_Click);
            // 
            // dateTimePickerOutDate
            // 
            this.dateTimePickerOutDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerOutDate.Location = new System.Drawing.Point(411, 228);
            this.dateTimePickerOutDate.Name = "dateTimePickerOutDate";
            this.dateTimePickerOutDate.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerOutDate.TabIndex = 88;
            this.dateTimePickerOutDate.ValueChanged += new System.EventHandler(this.dateTimePickerOutDate_ValueChanged);
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomNo.Location = new System.Drawing.Point(610, 229);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(80, 21);
            this.labelRoomNo.TabIndex = 90;
            this.labelRoomNo.Text = "Room No";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRoomNo.CausesValidation = false;
            this.textBoxRoomNo.Location = new System.Drawing.Point(696, 228);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.ReadOnly = true;
            this.textBoxRoomNo.Size = new System.Drawing.Size(117, 27);
            this.textBoxRoomNo.TabIndex = 91;
            this.textBoxRoomNo.Text = "0";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCustomerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCustomerID.CausesValidation = false;
            this.textBoxCustomerID.Location = new System.Drawing.Point(956, 226);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(117, 27);
            this.textBoxCustomerID.TabIndex = 93;
            this.textBoxCustomerID.Text = "0";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCustomerID.Location = new System.Drawing.Point(844, 228);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(106, 21);
            this.labelCustomerID.TabIndex = 92;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdate.Location = new System.Drawing.Point(723, 387);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(154, 45);
            this.buttonUpdate.TabIndex = 98;
            this.buttonUpdate.Text = "Update Rooms";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRefresh.Location = new System.Drawing.Point(917, 387);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(154, 45);
            this.buttonRefresh.TabIndex = 97;
            this.buttonRefresh.Text = "Refresh Data";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReset.Location = new System.Drawing.Point(723, 447);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(154, 45);
            this.buttonReset.TabIndex = 96;
            this.buttonReset.Text = "Reset Fields";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.Location = new System.Drawing.Point(917, 327);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(154, 45);
            this.buttonDelete.TabIndex = 95;
            this.buttonDelete.Text = "Remove Rooms";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInsert.Location = new System.Drawing.Point(723, 327);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(154, 45);
            this.buttonInsert.TabIndex = 94;
            this.buttonInsert.Text = "Add Rooms";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewResvRooms
            // 
            this.dataGridViewResvRooms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewResvRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewResvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResvRooms.Location = new System.Drawing.Point(13, 278);
            this.dataGridViewResvRooms.Name = "dataGridViewResvRooms";
            this.dataGridViewResvRooms.RowHeadersWidth = 51;
            this.dataGridViewResvRooms.RowTemplate.Height = 29;
            this.dataGridViewResvRooms.Size = new System.Drawing.Size(695, 240);
            this.dataGridViewResvRooms.TabIndex = 99;
            this.dataGridViewResvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResvRooms_CellClick);
            // 
            // labelResvNo
            // 
            this.labelResvNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResvNo.AutoSize = true;
            this.labelResvNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResvNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelResvNo.Location = new System.Drawing.Point(714, 281);
            this.labelResvNo.Name = "labelResvNo";
            this.labelResvNo.Size = new System.Drawing.Size(122, 21);
            this.labelResvNo.TabIndex = 101;
            this.labelResvNo.Text = "Reservation ID";
            // 
            // textBoxResvNo
            // 
            this.textBoxResvNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxResvNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxResvNo.CausesValidation = false;
            this.textBoxResvNo.Location = new System.Drawing.Point(842, 278);
            this.textBoxResvNo.Name = "textBoxResvNo";
            this.textBoxResvNo.ReadOnly = true;
            this.textBoxResvNo.Size = new System.Drawing.Size(229, 27);
            this.textBoxResvNo.TabIndex = 102;
            this.textBoxResvNo.Text = "0";
            // 
            // buttonViewHistory
            // 
            this.buttonViewHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewHistory.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonViewHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonViewHistory.Location = new System.Drawing.Point(917, 447);
            this.buttonViewHistory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonViewHistory.Name = "buttonViewHistory";
            this.buttonViewHistory.Size = new System.Drawing.Size(154, 45);
            this.buttonViewHistory.TabIndex = 103;
            this.buttonViewHistory.Text = "View History";
            this.buttonViewHistory.UseVisualStyleBackColor = true;
            this.buttonViewHistory.Click += new System.EventHandler(this.buttonViewHistory_Click);
            // 
            // FormReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1090, 530);
            this.Controls.Add(this.buttonViewHistory);
            this.Controls.Add(this.textBoxResvNo);
            this.Controls.Add(this.labelResvNo);
            this.Controls.Add(this.dataGridViewResvRooms);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.labelOutDate);
            this.Controls.Add(this.dateTimePickerOutDate);
            this.Controls.Add(this.labelInDate);
            this.Controls.Add(this.dateTimePickerInDate);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.textBoxSearchCustomer);
            this.Controls.Add(this.labelSearchCustomer);
            this.Controls.Add(this.buttonSearchRooms);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "FormReservations";
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResvRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Button buttonSearchRooms;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.Label labelSearchCustomer;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePickerInDate;
        private System.Windows.Forms.Label labelInDate;
        private System.Windows.Forms.Label labelOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOutDate;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewResvRooms;
        private System.Windows.Forms.Label labelResvNo;
        private System.Windows.Forms.TextBox textBoxResvNo;
        private System.Windows.Forms.Button buttonViewHistory;
    }
}