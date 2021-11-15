
namespace PointOfSaleSystem
{
    partial class PurchaseInvoice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.txtProductTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGrossTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCostPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVPurchaseCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBPayments = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaying = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPaymentTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPurchaseCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.GBPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 73);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PointOfSaleSystem.Properties.Resources.cancel__2_;
            this.button1.Location = new System.Drawing.Point(1325, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Invoice";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnCancel);
            this.guna2GroupBox1.Controls.Add(this.btnGenerate);
            this.guna2GroupBox1.Controls.Add(this.txtInvoiceNo);
            this.guna2GroupBox1.Controls.Add(this.dtInvoiceDate);
            this.guna2GroupBox1.Controls.Add(this.cboType);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.cboSupplier);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 73);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1370, 107);
            this.guna2GroupBox1.TabIndex = 26;
            this.guna2GroupBox1.Text = "Invoice Details";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(870, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 32);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "&RESET";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(772, 63);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 32);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.AutoRoundedCorners = true;
            this.txtInvoiceNo.BorderRadius = 11;
            this.txtInvoiceNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoiceNo.DefaultText = "";
            this.txtInvoiceNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoiceNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoiceNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceNo.DisabledState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.FocusedState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoiceNo.HoverState.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Location = new System.Drawing.Point(626, 67);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PlaceholderText = "";
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.ShadowDecoration.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Size = new System.Drawing.Size(139, 25);
            this.txtInvoiceNo.TabIndex = 7;
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvoiceDate.Location = new System.Drawing.Point(419, 67);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(200, 24);
            this.dtInvoiceDate.TabIndex = 6;
            // 
            // cboType
            // 
            this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cboType.Location = new System.Drawing.Point(6, 67);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(140, 25);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Invoice Type:";
            // 
            // cboSupplier
            // 
            this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSupplier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(159, 67);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(244, 25);
            this.cboSupplier.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(623, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(416, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(156, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Supplier:";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnFinalize);
            this.guna2GroupBox2.Controls.Add(this.btnAdd);
            this.guna2GroupBox2.Controls.Add(this.cboProducts);
            this.guna2GroupBox2.Controls.Add(this.txtProductTotal);
            this.guna2GroupBox2.Controls.Add(this.txtGrossTotal);
            this.guna2GroupBox2.Controls.Add(this.txtSalePrice);
            this.guna2GroupBox2.Controls.Add(this.txtCostPrice);
            this.guna2GroupBox2.Controls.Add(this.txtDiscount);
            this.guna2GroupBox2.Controls.Add(this.txtQuantity);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.cboUnit);
            this.guna2GroupBox2.Controls.Add(this.label13);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 180);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(403, 423);
            this.guna2GroupBox2.TabIndex = 27;
            this.guna2GroupBox2.Text = "Product Entries";
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalize.FlatAppearance.BorderSize = 2;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Location = new System.Drawing.Point(17, 374);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(253, 32);
            this.btnFinalize.TabIndex = 8;
            this.btnFinalize.Text = "&FINALIZE";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboProducts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(12, 76);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(223, 25);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.AutoRoundedCorners = true;
            this.txtProductTotal.BorderRadius = 11;
            this.txtProductTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductTotal.DefaultText = "";
            this.txtProductTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTotal.DisabledState.Parent = this.txtProductTotal;
            this.txtProductTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductTotal.Enabled = false;
            this.txtProductTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductTotal.FocusedState.Parent = this.txtProductTotal;
            this.txtProductTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductTotal.HoverState.Parent = this.txtProductTotal;
            this.txtProductTotal.Location = new System.Drawing.Point(15, 232);
            this.txtProductTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.PasswordChar = '\0';
            this.txtProductTotal.PlaceholderText = "";
            this.txtProductTotal.SelectedText = "";
            this.txtProductTotal.ShadowDecoration.Parent = this.txtProductTotal;
            this.txtProductTotal.Size = new System.Drawing.Size(254, 25);
            this.txtProductTotal.TabIndex = 7;
            // 
            // txtGrossTotal
            // 
            this.txtGrossTotal.AutoRoundedCorners = true;
            this.txtGrossTotal.BorderRadius = 11;
            this.txtGrossTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrossTotal.DefaultText = "";
            this.txtGrossTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrossTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrossTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrossTotal.DisabledState.Parent = this.txtGrossTotal;
            this.txtGrossTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrossTotal.Enabled = false;
            this.txtGrossTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrossTotal.FocusedState.Parent = this.txtGrossTotal;
            this.txtGrossTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrossTotal.HoverState.Parent = this.txtGrossTotal;
            this.txtGrossTotal.Location = new System.Drawing.Point(19, 342);
            this.txtGrossTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrossTotal.Name = "txtGrossTotal";
            this.txtGrossTotal.PasswordChar = '\0';
            this.txtGrossTotal.PlaceholderText = "";
            this.txtGrossTotal.SelectedText = "";
            this.txtGrossTotal.ShadowDecoration.Parent = this.txtGrossTotal;
            this.txtGrossTotal.Size = new System.Drawing.Size(230, 25);
            this.txtGrossTotal.TabIndex = 7;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.AutoRoundedCorners = true;
            this.txtSalePrice.BorderRadius = 11;
            this.txtSalePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalePrice.DefaultText = "";
            this.txtSalePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.DisabledState.Parent = this.txtSalePrice;
            this.txtSalePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalePrice.Enabled = false;
            this.txtSalePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.FocusedState.Parent = this.txtSalePrice;
            this.txtSalePrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalePrice.HoverState.Parent = this.txtSalePrice;
            this.txtSalePrice.Location = new System.Drawing.Point(166, 128);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.PlaceholderText = "";
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.ShadowDecoration.Parent = this.txtSalePrice;
            this.txtSalePrice.Size = new System.Drawing.Size(139, 25);
            this.txtSalePrice.TabIndex = 7;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.AutoRoundedCorners = true;
            this.txtCostPrice.BorderRadius = 11;
            this.txtCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostPrice.DefaultText = "";
            this.txtCostPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.DisabledState.Parent = this.txtCostPrice;
            this.txtCostPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.Enabled = false;
            this.txtCostPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.FocusedState.Parent = this.txtCostPrice;
            this.txtCostPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.HoverState.Parent = this.txtCostPrice;
            this.txtCostPrice.Location = new System.Drawing.Point(12, 128);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.PasswordChar = '\0';
            this.txtCostPrice.PlaceholderText = "";
            this.txtCostPrice.SelectedText = "";
            this.txtCostPrice.ShadowDecoration.Parent = this.txtCostPrice;
            this.txtCostPrice.Size = new System.Drawing.Size(139, 25);
            this.txtCostPrice.TabIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoRoundedCorners = true;
            this.txtDiscount.BorderRadius = 11;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(166, 180);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(139, 25);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.BorderRadius = 11;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(15, 180);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(139, 25);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(238, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Select Unit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Products:";
            // 
            // cboUnit
            // 
            this.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboUnit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cboUnit.Location = new System.Drawing.Point(241, 76);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(140, 25);
            this.cboUnit.TabIndex = 5;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Grand Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Product Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(163, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sale Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(163, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Enter Discount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Purchae Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Enter Quantity:";
            // 
            // DGVPurchaseCart
            // 
            this.DGVPurchaseCart.AllowUserToAddRows = false;
            this.DGVPurchaseCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.DGVPurchaseCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPurchaseCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPurchaseCart.BackgroundColor = System.Drawing.Color.White;
            this.DGVPurchaseCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVPurchaseCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPurchaseCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVPurchaseCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVPurchaseCart.ColumnHeadersHeight = 30;
            this.DGVPurchaseCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PcodeGV,
            this.ProductGV,
            this.UnitGV,
            this.PurchasePriceGV,
            this.SalePriceGV,
            this.QuantityGV,
            this.DiscountGV,
            this.ProductTotalGV,
            this.ActionGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPurchaseCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPurchaseCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPurchaseCart.EnableHeadersVisualStyles = false;
            this.DGVPurchaseCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.DGVPurchaseCart.Location = new System.Drawing.Point(0, 0);
            this.DGVPurchaseCart.Name = "DGVPurchaseCart";
            this.DGVPurchaseCart.ReadOnly = true;
            this.DGVPurchaseCart.RowHeadersVisible = false;
            this.DGVPurchaseCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPurchaseCart.Size = new System.Drawing.Size(967, 314);
            this.DGVPurchaseCart.TabIndex = 28;
            this.DGVPurchaseCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.DGVPurchaseCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.DGVPurchaseCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVPurchaseCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVPurchaseCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVPurchaseCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVPurchaseCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVPurchaseCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVPurchaseCart.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVPurchaseCart.ThemeStyle.ReadOnly = true;
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.Height = 22;
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.DGVPurchaseCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVPurchaseCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPurchaseCart_CellClick);
            this.DGVPurchaseCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPurchaseCart_CellValueChanged);
            // 
            // PcodeGV
            // 
            this.PcodeGV.HeaderText = "ProductCode";
            this.PcodeGV.Name = "PcodeGV";
            this.PcodeGV.ReadOnly = true;
            this.PcodeGV.Visible = false;
            // 
            // ProductGV
            // 
            this.ProductGV.HeaderText = "Product";
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.ReadOnly = true;
            // 
            // UnitGV
            // 
            this.UnitGV.HeaderText = "Unit";
            this.UnitGV.Name = "UnitGV";
            this.UnitGV.ReadOnly = true;
            // 
            // PurchasePriceGV
            // 
            this.PurchasePriceGV.HeaderText = "Cost Price";
            this.PurchasePriceGV.Name = "PurchasePriceGV";
            this.PurchasePriceGV.ReadOnly = true;
            // 
            // SalePriceGV
            // 
            this.SalePriceGV.HeaderText = "Sale Price";
            this.SalePriceGV.Name = "SalePriceGV";
            this.SalePriceGV.ReadOnly = true;
            this.SalePriceGV.Visible = false;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Quantity";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // DiscountGV
            // 
            this.DiscountGV.HeaderText = "Discount";
            this.DiscountGV.Name = "DiscountGV";
            this.DiscountGV.ReadOnly = true;
            // 
            // ProductTotalGV
            // 
            this.ProductTotalGV.HeaderText = "Total";
            this.ProductTotalGV.Name = "ProductTotalGV";
            this.ProductTotalGV.ReadOnly = true;
            // 
            // ActionGV
            // 
            this.ActionGV.HeaderText = "ACTION";
            this.ActionGV.Name = "ActionGV";
            this.ActionGV.ReadOnly = true;
            this.ActionGV.Text = "REMOVE";
            this.ActionGV.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVPurchaseCart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(403, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 314);
            this.panel2.TabIndex = 29;
            // 
            // GBPayments
            // 
            this.GBPayments.Controls.Add(this.txtBalance);
            this.GBPayments.Controls.Add(this.txtPaying);
            this.GBPayments.Controls.Add(this.label14);
            this.GBPayments.Controls.Add(this.label16);
            this.GBPayments.Controls.Add(this.label15);
            this.GBPayments.Controls.Add(this.txtPaymentTotal);
            this.GBPayments.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.GBPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBPayments.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.GBPayments.ForeColor = System.Drawing.Color.White;
            this.GBPayments.Location = new System.Drawing.Point(403, 494);
            this.GBPayments.Name = "GBPayments";
            this.GBPayments.ShadowDecoration.Parent = this.GBPayments;
            this.GBPayments.Size = new System.Drawing.Size(967, 109);
            this.GBPayments.TabIndex = 30;
            this.GBPayments.Text = "PAYMENTS";
            this.GBPayments.Visible = false;
            // 
            // txtBalance
            // 
            this.txtBalance.AutoRoundedCorners = true;
            this.txtBalance.BorderRadius = 11;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.Parent = this.txtBalance;
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.Enabled = false;
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.FocusedState.Parent = this.txtBalance;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.HoverState.Parent = this.txtBalance;
            this.txtBalance.Location = new System.Drawing.Point(380, 71);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderText = "";
            this.txtBalance.SelectedText = "";
            this.txtBalance.ShadowDecoration.Parent = this.txtBalance;
            this.txtBalance.Size = new System.Drawing.Size(180, 25);
            this.txtBalance.TabIndex = 7;
            // 
            // txtPaying
            // 
            this.txtPaying.AutoRoundedCorners = true;
            this.txtPaying.BorderRadius = 11;
            this.txtPaying.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaying.DefaultText = "0";
            this.txtPaying.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaying.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaying.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaying.DisabledState.Parent = this.txtPaying;
            this.txtPaying.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaying.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaying.FocusedState.Parent = this.txtPaying;
            this.txtPaying.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaying.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaying.HoverState.Parent = this.txtPaying;
            this.txtPaying.Location = new System.Drawing.Point(195, 71);
            this.txtPaying.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaying.Name = "txtPaying";
            this.txtPaying.PasswordChar = '\0';
            this.txtPaying.PlaceholderText = "";
            this.txtPaying.SelectedText = "";
            this.txtPaying.SelectionStart = 1;
            this.txtPaying.ShadowDecoration.Parent = this.txtPaying;
            this.txtPaying.Size = new System.Drawing.Size(180, 25);
            this.txtPaying.TabIndex = 7;
            this.txtPaying.TextChanged += new System.EventHandler(this.txtPaying_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(4, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "Total Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(377, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(192, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Paying";
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.AutoRoundedCorners = true;
            this.txtPaymentTotal.BorderRadius = 11;
            this.txtPaymentTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentTotal.DefaultText = "";
            this.txtPaymentTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentTotal.DisabledState.Parent = this.txtPaymentTotal;
            this.txtPaymentTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentTotal.Enabled = false;
            this.txtPaymentTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentTotal.FocusedState.Parent = this.txtPaymentTotal;
            this.txtPaymentTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentTotal.HoverState.Parent = this.txtPaymentTotal;
            this.txtPaymentTotal.Location = new System.Drawing.Point(7, 71);
            this.txtPaymentTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.PasswordChar = '\0';
            this.txtPaymentTotal.PlaceholderText = "";
            this.txtPaymentTotal.SelectedText = "";
            this.txtPaymentTotal.ShadowDecoration.Parent = this.txtPaymentTotal;
            this.txtPaymentTotal.Size = new System.Drawing.Size(180, 25);
            this.txtPaymentTotal.TabIndex = 7;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 603);
            this.ControlBox = false;
            this.Controls.Add(this.GBPayments);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPurchaseCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.GBPayments.ResumeLayout(false);
            this.GBPayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboSupplier;
        public System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerate;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        public System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cboUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtCostPrice;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtSalePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtProductTotal;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DataGridView DGVPurchaseCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalGV;
        private System.Windows.Forms.DataGridViewButtonColumn ActionGV;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtGrossTotal;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2GroupBox GBPayments;
        private Guna.UI2.WinForms.Guna2TextBox txtPaying;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtPaymentTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinalize;
    }
}