
namespace HRS_Application
{
    partial class FormBilling
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
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxAdditionalPrice = new System.Windows.Forms.TextBox();
            this.labelAdditionalPrice = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.textBoxCustomerFName = new System.Windows.Forms.TextBox();
            this.labelCustomerFName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCustomerLName = new System.Windows.Forms.TextBox();
            this.labelCustomerLName = new System.Windows.Forms.Label();
            this.textBoxAadhaar = new System.Windows.Forms.TextBox();
            this.labelAadhaar = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonRefreshCustomer = new System.Windows.Forms.Button();
            this.textBoxMobileNo = new System.Windows.Forms.TextBox();
            this.labelMobileNo = new System.Windows.Forms.Label();
            this.textBoxGSTIN = new System.Windows.Forms.TextBox();
            this.labelGSTIN = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.errorProviderDiscount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTax = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDays = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAdditionalPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGSTIN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSearch = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdditionalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGSTIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetForm.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResetForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonResetForm.Location = new System.Drawing.Point(44, 461);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(153, 45);
            this.buttonResetForm.TabIndex = 55;
            this.buttonResetForm.Text = "Reset";
            this.buttonResetForm.UseVisualStyleBackColor = true;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCalculate.Location = new System.Drawing.Point(288, 461);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(153, 45);
            this.buttonCalculate.TabIndex = 54;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRoomID.Location = new System.Drawing.Point(415, 236);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(127, 27);
            this.textBoxRoomID.TabIndex = 53;
            this.textBoxRoomID.Text = "0";
            this.textBoxRoomID.TextChanged += new System.EventHandler(this.textBoxRoomID_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTotal.Location = new System.Drawing.Point(166, 409);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(376, 27);
            this.textBoxTotal.TabIndex = 51;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextChanged += new System.EventHandler(this.textBoxTotal_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTotal.Location = new System.Drawing.Point(39, 411);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(96, 21);
            this.labelTotal.TabIndex = 50;
            this.labelTotal.Text = "Grand Total";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTax.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTax.Location = new System.Drawing.Point(415, 322);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(127, 27);
            this.textBoxTax.TabIndex = 49;
            this.textBoxTax.Text = "18";
            this.textBoxTax.TextChanged += new System.EventHandler(this.textBoxTax_TextChanged);
            this.textBoxTax.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Tax);
            // 
            // labelTax
            // 
            this.labelTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTax.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTax.Location = new System.Drawing.Point(357, 324);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(52, 21);
            this.labelTax.TabIndex = 48;
            this.labelTax.Text = "Tax %";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDiscount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDiscount.Location = new System.Drawing.Point(166, 279);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(127, 27);
            this.textBoxDiscount.TabIndex = 47;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            this.textBoxDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Discount);
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDiscount.Location = new System.Drawing.Point(39, 281);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(92, 21);
            this.labelDiscount.TabIndex = 46;
            this.labelDiscount.Text = "Discount %";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDays.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDays.Location = new System.Drawing.Point(415, 280);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.ReadOnly = true;
            this.textBoxDays.Size = new System.Drawing.Size(127, 27);
            this.textBoxDays.TabIndex = 45;
            this.textBoxDays.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            this.textBoxDays.Validating += new System.ComponentModel.CancelEventHandler(this.validation_Days);
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDays.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDays.Location = new System.Drawing.Point(313, 282);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(96, 21);
            this.labelDays.TabIndex = 44;
            this.labelDays.Text = "No. of Days";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPrice.CausesValidation = false;
            this.textBoxPrice.Location = new System.Drawing.Point(166, 236);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(127, 27);
            this.textBoxPrice.TabIndex = 43;
            this.textBoxPrice.Text = "0";
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPrice.Location = new System.Drawing.Point(13, 242);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(122, 21);
            this.labelPrice.TabIndex = 42;
            this.labelPrice.Text = "Price (per day)";
            // 
            // textBoxAdditionalPrice
            // 
            this.textBoxAdditionalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdditionalPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAdditionalPrice.Location = new System.Drawing.Point(166, 322);
            this.textBoxAdditionalPrice.Name = "textBoxAdditionalPrice";
            this.textBoxAdditionalPrice.Size = new System.Drawing.Size(127, 27);
            this.textBoxAdditionalPrice.TabIndex = 57;
            this.textBoxAdditionalPrice.Text = "0";
            this.textBoxAdditionalPrice.TextChanged += new System.EventHandler(this.textBoxAdditionalPrice_TextChanged);
            this.textBoxAdditionalPrice.Validating += new System.ComponentModel.CancelEventHandler(this.validation_AdditionalPrice);
            // 
            // labelAdditionalPrice
            // 
            this.labelAdditionalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdditionalPrice.AutoSize = true;
            this.labelAdditionalPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdditionalPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAdditionalPrice.Location = new System.Drawing.Point(7, 324);
            this.labelAdditionalPrice.Name = "labelAdditionalPrice";
            this.labelAdditionalPrice.Size = new System.Drawing.Size(153, 21);
            this.labelAdditionalPrice.TabIndex = 56;
            this.labelAdditionalPrice.Text = "Additional Charges";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCustomerID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCustomerID.Location = new System.Drawing.Point(680, 223);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(99, 27);
            this.textBoxCustomerID.TabIndex = 60;
            this.textBoxCustomerID.Text = "0";
            this.textBoxCustomerID.TextChanged += new System.EventHandler(this.textBoxCustomerID_TextChanged);
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCustomerID.Location = new System.Drawing.Point(568, 225);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(106, 21);
            this.labelCustomerID.TabIndex = 59;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // textBoxCustomerFName
            // 
            this.textBoxCustomerFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCustomerFName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCustomerFName.Location = new System.Drawing.Point(639, 268);
            this.textBoxCustomerFName.Name = "textBoxCustomerFName";
            this.textBoxCustomerFName.ReadOnly = true;
            this.textBoxCustomerFName.Size = new System.Drawing.Size(439, 27);
            this.textBoxCustomerFName.TabIndex = 62;
            this.textBoxCustomerFName.TextChanged += new System.EventHandler(this.textBoxCustomerFName_TextChanged);
            // 
            // labelCustomerFName
            // 
            this.labelCustomerFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustomerFName.AutoSize = true;
            this.labelCustomerFName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerFName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCustomerFName.Location = new System.Drawing.Point(568, 270);
            this.labelCustomerFName.Name = "labelCustomerFName";
            this.labelCustomerFName.Size = new System.Drawing.Size(65, 21);
            this.labelCustomerFName.TabIndex = 61;
            this.labelCustomerFName.Text = "FName";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSearch.Location = new System.Drawing.Point(924, 461);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(154, 45);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCustomerLName
            // 
            this.textBoxCustomerLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCustomerLName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCustomerLName.Location = new System.Drawing.Point(639, 314);
            this.textBoxCustomerLName.Name = "textBoxCustomerLName";
            this.textBoxCustomerLName.ReadOnly = true;
            this.textBoxCustomerLName.Size = new System.Drawing.Size(439, 27);
            this.textBoxCustomerLName.TabIndex = 65;
            // 
            // labelCustomerLName
            // 
            this.labelCustomerLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustomerLName.AutoSize = true;
            this.labelCustomerLName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerLName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCustomerLName.Location = new System.Drawing.Point(568, 316);
            this.labelCustomerLName.Name = "labelCustomerLName";
            this.labelCustomerLName.Size = new System.Drawing.Size(65, 21);
            this.labelCustomerLName.TabIndex = 64;
            this.labelCustomerLName.Text = "LName";
            // 
            // textBoxAadhaar
            // 
            this.textBoxAadhaar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAadhaar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAadhaar.Location = new System.Drawing.Point(861, 225);
            this.textBoxAadhaar.Name = "textBoxAadhaar";
            this.textBoxAadhaar.ReadOnly = true;
            this.textBoxAadhaar.Size = new System.Drawing.Size(217, 27);
            this.textBoxAadhaar.TabIndex = 67;
            this.textBoxAadhaar.TextChanged += new System.EventHandler(this.textBoxAadhaar_TextChanged);
            // 
            // labelAadhaar
            // 
            this.labelAadhaar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAadhaar.AutoSize = true;
            this.labelAadhaar.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAadhaar.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAadhaar.Location = new System.Drawing.Point(785, 227);
            this.labelAadhaar.Name = "labelAadhaar";
            this.labelAadhaar.Size = new System.Drawing.Size(73, 21);
            this.labelAadhaar.TabIndex = 66;
            this.labelAadhaar.Text = "Aadhaar";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Location = new System.Drawing.Point(639, 359);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(439, 27);
            this.textBoxEmail.TabIndex = 73;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelEmail.Location = new System.Drawing.Point(568, 361);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 21);
            this.labelEmail.TabIndex = 72;
            this.labelEmail.Text = "Email";
            // 
            // buttonRefreshCustomer
            // 
            this.buttonRefreshCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefreshCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshCustomer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefreshCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRefreshCustomer.Location = new System.Drawing.Point(734, 461);
            this.buttonRefreshCustomer.Name = "buttonRefreshCustomer";
            this.buttonRefreshCustomer.Size = new System.Drawing.Size(153, 45);
            this.buttonRefreshCustomer.TabIndex = 74;
            this.buttonRefreshCustomer.Text = "Email";
            this.buttonRefreshCustomer.UseVisualStyleBackColor = true;
            this.buttonRefreshCustomer.Click += new System.EventHandler(this.buttonRefreshCustomer_Click);
            // 
            // textBoxMobileNo
            // 
            this.textBoxMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMobileNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMobileNo.Location = new System.Drawing.Point(639, 408);
            this.textBoxMobileNo.Name = "textBoxMobileNo";
            this.textBoxMobileNo.ReadOnly = true;
            this.textBoxMobileNo.Size = new System.Drawing.Size(439, 27);
            this.textBoxMobileNo.TabIndex = 76;
            // 
            // labelMobileNo
            // 
            this.labelMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMobileNo.AutoSize = true;
            this.labelMobileNo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMobileNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMobileNo.Location = new System.Drawing.Point(568, 410);
            this.labelMobileNo.Name = "labelMobileNo";
            this.labelMobileNo.Size = new System.Drawing.Size(59, 21);
            this.labelMobileNo.TabIndex = 75;
            this.labelMobileNo.Text = "Mobile";
            // 
            // textBoxGSTIN
            // 
            this.textBoxGSTIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGSTIN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGSTIN.CausesValidation = false;
            this.textBoxGSTIN.Location = new System.Drawing.Point(166, 365);
            this.textBoxGSTIN.Name = "textBoxGSTIN";
            this.textBoxGSTIN.Size = new System.Drawing.Size(376, 27);
            this.textBoxGSTIN.TabIndex = 78;
            this.textBoxGSTIN.TextChanged += new System.EventHandler(this.textBoxGSTIN_TextChanged);
            this.textBoxGSTIN.Validating += new System.ComponentModel.CancelEventHandler(this.validation_GSTIN);
            // 
            // labelGSTIN
            // 
            this.labelGSTIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGSTIN.AutoSize = true;
            this.labelGSTIN.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGSTIN.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelGSTIN.Location = new System.Drawing.Point(75, 367);
            this.labelGSTIN.Name = "labelGSTIN";
            this.labelGSTIN.Size = new System.Drawing.Size(56, 21);
            this.labelGSTIN.TabIndex = 77;
            this.labelGSTIN.Text = "GSTIN";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerate.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonGenerate.Location = new System.Drawing.Point(521, 461);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(153, 45);
            this.buttonGenerate.TabIndex = 79;
            this.buttonGenerate.Text = "Print Invoice";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelRoomID
            // 
            this.labelRoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRoomID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomID.Location = new System.Drawing.Point(339, 238);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(70, 21);
            this.labelRoomID.TabIndex = 80;
            this.labelRoomID.Text = "RoomID";
            // 
            // errorProviderDiscount
            // 
            this.errorProviderDiscount.ContainerControl = this;
            // 
            // errorProviderTax
            // 
            this.errorProviderTax.ContainerControl = this;
            // 
            // errorProviderDays
            // 
            this.errorProviderDays.ContainerControl = this;
            // 
            // errorProviderAdditionalPrice
            // 
            this.errorProviderAdditionalPrice.ContainerControl = this;
            // 
            // errorProviderGSTIN
            // 
            this.errorProviderGSTIN.ContainerControl = this;
            // 
            // errorProviderSearch
            // 
            this.errorProviderSearch.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.Location = new System.Drawing.Point(7, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1071, 211);
            this.dataGridView2.TabIndex = 83;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1090, 530);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxGSTIN);
            this.Controls.Add(this.labelGSTIN);
            this.Controls.Add(this.textBoxMobileNo);
            this.Controls.Add(this.labelMobileNo);
            this.Controls.Add(this.buttonRefreshCustomer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAadhaar);
            this.Controls.Add(this.labelAadhaar);
            this.Controls.Add(this.textBoxCustomerLName);
            this.Controls.Add(this.labelCustomerLName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxCustomerFName);
            this.Controls.Add(this.labelCustomerFName);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.textBoxAdditionalPrice);
            this.Controls.Add(this.labelAdditionalPrice);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxRoomID);
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
            this.Name = "FormBilling";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.FormBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAdditionalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGSTIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxAdditionalPrice;
        private System.Windows.Forms.Label labelAdditionalPrice;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.TextBox textBoxCustomerFName;
        private System.Windows.Forms.Label labelCustomerFName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCustomerLName;
        private System.Windows.Forms.Label labelCustomerLName;
        private System.Windows.Forms.TextBox textBoxAadhaar;
        private System.Windows.Forms.Label labelAadhaar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonRefreshCustomer;
        private System.Windows.Forms.Label labelMobileNo;
        private System.Windows.Forms.TextBox textBoxGSTIN;
        private System.Windows.Forms.Label labelGSTIN;
        private System.Windows.Forms.TextBox textBoxMobileNo;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.ErrorProvider errorProviderDiscount;
        private System.Windows.Forms.ErrorProvider errorProviderTax;
        private System.Windows.Forms.ErrorProvider errorProviderDays;
        private System.Windows.Forms.ErrorProvider errorProviderAdditionalPrice;
        private System.Windows.Forms.ErrorProvider errorProviderGSTIN;
        private System.Windows.Forms.ErrorProvider errorProviderSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}