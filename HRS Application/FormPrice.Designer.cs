
namespace HRS_Application
{
    partial class FormPrice
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
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderDays = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.errorProviderTax = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDiscount = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscount)).BeginInit();
            this.SuspendLayout();
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
            this.comboBoxRoomType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRoomType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Comfort Single Room",
            "Comfort Double Room",
            "Luxury Single Room",
            "Luxury Double Room",
            "Club Suite Room"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(365, 102);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(213, 29);
            this.comboBoxRoomType.TabIndex = 25;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomType.Location = new System.Drawing.Point(238, 105);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(92, 21);
            this.labelRoomType.TabIndex = 24;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPrice.Location = new System.Drawing.Point(208, 174);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(122, 21);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Price (per day)";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPrice.CausesValidation = false;
            this.textBoxPrice.Location = new System.Drawing.Point(365, 172);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(127, 27);
            this.textBoxPrice.TabIndex = 27;
            this.textBoxPrice.Text = "0";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDays.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDays.Location = new System.Drawing.Point(671, 174);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(127, 27);
            this.textBoxDays.TabIndex = 29;
            this.textBoxDays.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Days);
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDays.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDays.Location = new System.Drawing.Point(545, 174);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(96, 21);
            this.labelDays.TabIndex = 28;
            this.labelDays.Text = "No. of Days";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDiscount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDiscount.Location = new System.Drawing.Point(365, 245);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(127, 27);
            this.textBoxDiscount.TabIndex = 31;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Discount);
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiscount.Location = new System.Drawing.Point(238, 247);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(92, 21);
            this.labelDiscount.TabIndex = 30;
            this.labelDiscount.Text = "Discount %";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTax.Location = new System.Drawing.Point(671, 245);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(127, 27);
            this.textBoxTax.TabIndex = 33;
            this.textBoxTax.Text = "18";
            this.textBoxTax.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Tax);
            // 
            // labelTax
            // 
            this.labelTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTax.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTax.Location = new System.Drawing.Point(589, 247);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(52, 21);
            this.labelTax.TabIndex = 32;
            this.labelTax.Text = "Tax %";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotal.Location = new System.Drawing.Point(238, 326);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(96, 21);
            this.labelTotal.TabIndex = 34;
            this.labelTotal.Text = "Grand Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTotal.Location = new System.Drawing.Point(365, 324);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(433, 27);
            this.textBoxTotal.TabIndex = 35;
            this.textBoxTotal.Text = "0";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRoomID.Location = new System.Drawing.Point(671, 102);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(127, 27);
            this.textBoxRoomID.TabIndex = 37;
            this.textBoxRoomID.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(593, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "RoomID";
            // 
            // errorProviderDays
            // 
            this.errorProviderDays.ContainerControl = this;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCalculate.Location = new System.Drawing.Point(444, 388);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(229, 45);
            this.buttonCalculate.TabIndex = 38;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResetForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonResetForm.Location = new System.Drawing.Point(444, 448);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(229, 45);
            this.buttonResetForm.TabIndex = 39;
            this.buttonResetForm.Text = "Reset";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // errorProviderTax
            // 
            this.errorProviderTax.ContainerControl = this;
            // 
            // errorProviderDiscount
            // 
            this.errorProviderDiscount.ContainerControl = this;
            // 
            // FormPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1090, 530);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxTax);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.labelRoomType);
            this.Name = "FormPrice";
            this.Text = "Price Estimation";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderDays;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.ErrorProvider errorProviderTax;
        private System.Windows.Forms.ErrorProvider errorProviderDiscount;
    }
}