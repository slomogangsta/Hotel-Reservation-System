
namespace HRS_Application
{
    partial class FormRoom
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.labelRoomNo = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomTypeID = new System.Windows.Forms.Label();
            this.textBoxRoomTypeID = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.errorProviderRoomNo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRoomType = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomType)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(23, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(532, 500);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRoomNo.Location = new System.Drawing.Point(732, 67);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(96, 27);
            this.textBoxRoomNo.TabIndex = 21;
            this.textBoxRoomNo.Text = "0";
            this.textBoxRoomNo.Validating += new System.ComponentModel.CancelEventHandler(this.validation_RoomNo);
            // 
            // labelRoomNo
            // 
            this.labelRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomNo.AutoSize = true;
            this.labelRoomNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomNo.Location = new System.Drawing.Point(606, 69);
            this.labelRoomNo.Name = "labelRoomNo";
            this.labelRoomNo.Size = new System.Drawing.Size(120, 21);
            this.labelRoomNo.TabIndex = 20;
            this.labelRoomNo.Text = "Room Number";
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomType.Location = new System.Drawing.Point(633, 149);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(92, 21);
            this.labelRoomType.TabIndex = 22;
            this.labelRoomType.Text = "Room Type";
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
            this.comboBoxRoomType.Location = new System.Drawing.Point(731, 143);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(332, 29);
            this.comboBoxRoomType.TabIndex = 23;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            this.comboBoxRoomType.Validating += new System.ComponentModel.CancelEventHandler(this.validation_RoomType);
            // 
            // labelRoomTypeID
            // 
            this.labelRoomTypeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomTypeID.AutoSize = true;
            this.labelRoomTypeID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomTypeID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomTypeID.Location = new System.Drawing.Point(887, 70);
            this.labelRoomTypeID.Name = "labelRoomTypeID";
            this.labelRoomTypeID.Size = new System.Drawing.Size(75, 21);
            this.labelRoomTypeID.TabIndex = 24;
            this.labelRoomTypeID.Text = "Room ID";
            // 
            // textBoxRoomTypeID
            // 
            this.textBoxRoomTypeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomTypeID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRoomTypeID.Location = new System.Drawing.Point(968, 67);
            this.textBoxRoomTypeID.Name = "textBoxRoomTypeID";
            this.textBoxRoomTypeID.ReadOnly = true;
            this.textBoxRoomTypeID.Size = new System.Drawing.Size(95, 27);
            this.textBoxRoomTypeID.TabIndex = 25;
            this.textBoxRoomTypeID.Text = "0";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonInsert.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInsert.Location = new System.Drawing.Point(606, 217);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(222, 45);
            this.buttonInsert.TabIndex = 26;
            this.buttonInsert.Text = "Add Rooms";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.Location = new System.Drawing.Point(873, 217);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(190, 45);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Remove Rooms";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRefresh.Location = new System.Drawing.Point(757, 409);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(190, 45);
            this.buttonRefresh.TabIndex = 36;
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
            this.buttonReset.Location = new System.Drawing.Point(874, 311);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(190, 45);
            this.buttonReset.TabIndex = 35;
            this.buttonReset.Text = "Reset Fields";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // errorProviderRoomNo
            // 
            this.errorProviderRoomNo.ContainerControl = this;
            // 
            // errorProviderRoomType
            // 
            this.errorProviderRoomType.ContainerControl = this;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdate.Location = new System.Drawing.Point(607, 311);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(222, 45);
            this.buttonUpdate.TabIndex = 41;
            this.buttonUpdate.Text = "Update Rooms";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1112, 542);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxRoomTypeID);
            this.Controls.Add(this.labelRoomTypeID);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.textBoxRoomNo);
            this.Controls.Add(this.labelRoomNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoom";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRoomType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label labelRoomNo;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomTypeID;
        private System.Windows.Forms.TextBox textBoxRoomTypeID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ErrorProvider errorProviderRoomNo;
        private System.Windows.Forms.ErrorProvider errorProviderRoomType;
        private System.Windows.Forms.Button buttonUpdate;
    }
}