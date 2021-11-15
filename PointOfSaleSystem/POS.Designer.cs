
namespace PointOfSaleSystem
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStoreAddress = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearhBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVSaleCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOfProductGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionAddGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ActionRemoveGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.txtGrandTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GBCustomer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtContactNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaying = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GBWalking = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtWChange = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWPaying = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSaleCart)).BeginInit();
            this.panel4.SuspendLayout();
            this.GBCustomer.SuspendLayout();
            this.GBWalking.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblStoreAddress);
            this.panel1.Controls.Add(this.lblStore);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 73);
            this.panel1.TabIndex = 24;
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
            // lblStoreAddress
            // 
            this.lblStoreAddress.AutoSize = true;
            this.lblStoreAddress.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.lblStoreAddress.ForeColor = System.Drawing.Color.White;
            this.lblStoreAddress.Location = new System.Drawing.Point(557, 21);
            this.lblStoreAddress.Name = "lblStoreAddress";
            this.lblStoreAddress.Size = new System.Drawing.Size(0, 40);
            this.lblStoreAddress.TabIndex = 2;
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.lblStore.ForeColor = System.Drawing.Color.White;
            this.lblStore.Location = new System.Drawing.Point(824, 18);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(61, 40);
            this.lblStore.TabIndex = 2;
            this.lblStore.Text = "cc";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(718, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 40);
            this.label16.TabIndex = 2;
            this.label16.Text = "Store:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point of Sale";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 73);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1370, 85);
            this.guna2GroupBox1.TabIndex = 25;
            this.guna2GroupBox1.Text = "SEARCH PRODUCT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtInvoiceDate);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtSearhBarcode);
            this.panel2.Controls.Add(this.cboProducts);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 57);
            this.panel2.TabIndex = 0;
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtInvoiceDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvoiceDate.Location = new System.Drawing.Point(863, 18);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(138, 24);
            this.dtInvoiceDate.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(810, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 19);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(1260, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 32);
            this.btnGenerate.TabIndex = 12;
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
            this.txtInvoiceNo.Location = new System.Drawing.Point(1114, 18);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PlaceholderText = "";
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.ShadowDecoration.Parent = this.txtInvoiceNo;
            this.txtInvoiceNo.Size = new System.Drawing.Size(139, 25);
            this.txtInvoiceNo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1021, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Invoice No:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(723, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearhBarcode
            // 
            this.txtSearhBarcode.AutoRoundedCorners = true;
            this.txtSearhBarcode.BorderRadius = 13;
            this.txtSearhBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearhBarcode.DefaultText = "";
            this.txtSearhBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearhBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearhBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearhBarcode.DisabledState.Parent = this.txtSearhBarcode;
            this.txtSearhBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearhBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearhBarcode.FocusedState.Parent = this.txtSearhBarcode;
            this.txtSearhBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearhBarcode.HoverState.Parent = this.txtSearhBarcode;
            this.txtSearhBarcode.IconLeft = global::PointOfSaleSystem.Properties.Resources.icons8_search_50px;
            this.txtSearhBarcode.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearhBarcode.Location = new System.Drawing.Point(365, 16);
            this.txtSearhBarcode.Margin = new System.Windows.Forms.Padding(37, 35, 37, 35);
            this.txtSearhBarcode.Name = "txtSearhBarcode";
            this.txtSearhBarcode.PasswordChar = '\0';
            this.txtSearhBarcode.PlaceholderText = "Enter Barcode";
            this.txtSearhBarcode.SelectedText = "";
            this.txtSearhBarcode.ShadowDecoration.Parent = this.txtSearhBarcode;
            this.txtSearhBarcode.Size = new System.Drawing.Size(356, 29);
            this.txtSearhBarcode.TabIndex = 4;
            this.txtSearhBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearhBarcode_KeyDown);
            // 
            // cboProducts
            // 
            this.cboProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(83, 18);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(242, 25);
            this.cboProducts.TabIndex = 1;
            this.cboProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProducts_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVSaleCart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 445);
            this.panel3.TabIndex = 26;
            // 
            // DGVSaleCart
            // 
            this.DGVSaleCart.AllowUserToAddRows = false;
            this.DGVSaleCart.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.DGVSaleCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSaleCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSaleCart.BackgroundColor = System.Drawing.Color.White;
            this.DGVSaleCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSaleCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSaleCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSaleCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVSaleCart.ColumnHeadersHeight = 30;
            this.DGVSaleCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDGV,
            this.ProductGV,
            this.UnitGV,
            this.CostPriceGV,
            this.SalePriceGV,
            this.QuantityGV,
            this.TotalOfProductGV,
            this.ActionAddGV,
            this.ActionRemoveGV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSaleCart.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVSaleCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSaleCart.EnableHeadersVisualStyles = false;
            this.DGVSaleCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.DGVSaleCart.Location = new System.Drawing.Point(0, 0);
            this.DGVSaleCart.Name = "DGVSaleCart";
            this.DGVSaleCart.ReadOnly = true;
            this.DGVSaleCart.RowHeadersVisible = false;
            this.DGVSaleCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSaleCart.Size = new System.Drawing.Size(804, 445);
            this.DGVSaleCart.TabIndex = 0;
            this.DGVSaleCart.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.DGVSaleCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.DGVSaleCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVSaleCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVSaleCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVSaleCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVSaleCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVSaleCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.DGVSaleCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.DGVSaleCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVSaleCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DGVSaleCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVSaleCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVSaleCart.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVSaleCart.ThemeStyle.ReadOnly = true;
            this.DGVSaleCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.DGVSaleCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSaleCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DGVSaleCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVSaleCart.ThemeStyle.RowsStyle.Height = 22;
            this.DGVSaleCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.DGVSaleCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVSaleCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSaleCart_CellClick);
            // 
            // ProductIDGV
            // 
            this.ProductIDGV.HeaderText = "ProductID";
            this.ProductIDGV.Name = "ProductIDGV";
            this.ProductIDGV.ReadOnly = true;
            this.ProductIDGV.Visible = false;
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
            // CostPriceGV
            // 
            this.CostPriceGV.HeaderText = "CostPrice";
            this.CostPriceGV.Name = "CostPriceGV";
            this.CostPriceGV.ReadOnly = true;
            this.CostPriceGV.Visible = false;
            // 
            // SalePriceGV
            // 
            this.SalePriceGV.HeaderText = "Price";
            this.SalePriceGV.Name = "SalePriceGV";
            this.SalePriceGV.ReadOnly = true;
            // 
            // QuantityGV
            // 
            this.QuantityGV.HeaderText = "Qty";
            this.QuantityGV.Name = "QuantityGV";
            this.QuantityGV.ReadOnly = true;
            // 
            // TotalOfProductGV
            // 
            this.TotalOfProductGV.HeaderText = "Total";
            this.TotalOfProductGV.Name = "TotalOfProductGV";
            this.TotalOfProductGV.ReadOnly = true;
            // 
            // ActionAddGV
            // 
            this.ActionAddGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionAddGV.HeaderText = "";
            this.ActionAddGV.Name = "ActionAddGV";
            this.ActionAddGV.ReadOnly = true;
            this.ActionAddGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActionAddGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ActionAddGV.Text = "ADD";
            this.ActionAddGV.UseColumnTextForButtonValue = true;
            // 
            // ActionRemoveGV
            // 
            this.ActionRemoveGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActionRemoveGV.HeaderText = "";
            this.ActionRemoveGV.Name = "ActionRemoveGV";
            this.ActionRemoveGV.ReadOnly = true;
            this.ActionRemoveGV.Text = "REMOVE";
            this.ActionRemoveGV.UseColumnTextForButtonValue = true;
            // 
            // CustomerToggle
            // 
            this.CustomerToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.CustomerToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.CustomerToggle.CheckedState.Parent = this.CustomerToggle;
            this.CustomerToggle.Location = new System.Drawing.Point(146, 7);
            this.CustomerToggle.Name = "CustomerToggle";
            this.CustomerToggle.ShadowDecoration.Parent = this.CustomerToggle;
            this.CustomerToggle.Size = new System.Drawing.Size(95, 33);
            this.CustomerToggle.TabIndex = 5;
            this.CustomerToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CustomerToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CustomerToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.CustomerToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.CustomerToggle.UncheckedState.Parent = this.CustomerToggle;
            this.CustomerToggle.CheckedChanged += new System.EventHandler(this.CustomerToggle_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFinalize);
            this.panel4.Controls.Add(this.txtGrandTotal);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.GBCustomer);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.CustomerToggle);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.GBWalking);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.panel4.Location = new System.Drawing.Point(804, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 445);
            this.panel4.TabIndex = 27;
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFinalize.FlatAppearance.BorderSize = 2;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Font = new System.Drawing.Font("Century Gothic", 23F);
            this.btnFinalize.ForeColor = System.Drawing.Color.White;
            this.btnFinalize.Location = new System.Drawing.Point(10, 315);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(373, 54);
            this.btnFinalize.TabIndex = 10;
            this.btnFinalize.Text = "&FINALIZE";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.AutoRoundedCorners = true;
            this.txtGrandTotal.BorderRadius = 14;
            this.txtGrandTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrandTotal.DefaultText = "";
            this.txtGrandTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrandTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrandTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.DisabledState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.FocusedState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrandTotal.HoverState.Parent = this.txtGrandTotal;
            this.txtGrandTotal.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtGrandTotal.Location = new System.Drawing.Point(203, 78);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(49, 46, 49, 46);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.PasswordChar = '\0';
            this.txtGrandTotal.PlaceholderText = "";
            this.txtGrandTotal.SelectedText = "";
            this.txtGrandTotal.ShadowDecoration.Parent = this.txtGrandTotal;
            this.txtGrandTotal.Size = new System.Drawing.Size(269, 31);
            this.txtGrandTotal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Grand Total";
            // 
            // GBCustomer
            // 
            this.GBCustomer.Controls.Add(this.cboCustomer);
            this.GBCustomer.Controls.Add(this.txtContactNo);
            this.GBCustomer.Controls.Add(this.txtBalance);
            this.GBCustomer.Controls.Add(this.label9);
            this.GBCustomer.Controls.Add(this.label7);
            this.GBCustomer.Controls.Add(this.label10);
            this.GBCustomer.Controls.Add(this.txtPaying);
            this.GBCustomer.Controls.Add(this.label8);
            this.GBCustomer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.GBCustomer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.GBCustomer.ForeColor = System.Drawing.Color.White;
            this.GBCustomer.Location = new System.Drawing.Point(10, 126);
            this.GBCustomer.Name = "GBCustomer";
            this.GBCustomer.ShadowDecoration.Parent = this.GBCustomer;
            this.GBCustomer.Size = new System.Drawing.Size(544, 166);
            this.GBCustomer.TabIndex = 6;
            this.GBCustomer.Text = "CUSTOMER INFO And PAYMENTS";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(7, 67);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(258, 25);
            this.cboCustomer.TabIndex = 11;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.AutoRoundedCorners = true;
            this.txtContactNo.BackColor = System.Drawing.Color.White;
            this.txtContactNo.BorderRadius = 14;
            this.txtContactNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNo.DefaultText = "";
            this.txtContactNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNo.DisabledState.Parent = this.txtContactNo;
            this.txtContactNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNo.Enabled = false;
            this.txtContactNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNo.FocusedState.Parent = this.txtContactNo;
            this.txtContactNo.ForeColor = System.Drawing.Color.Black;
            this.txtContactNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNo.HoverState.Parent = this.txtContactNo;
            this.txtContactNo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtContactNo.Location = new System.Drawing.Point(283, 64);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(116, 102, 116, 102);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.PasswordChar = '\0';
            this.txtContactNo.PlaceholderText = "";
            this.txtContactNo.SelectedText = "";
            this.txtContactNo.ShadowDecoration.Parent = this.txtContactNo;
            this.txtContactNo.Size = new System.Drawing.Size(220, 31);
            this.txtContactNo.TabIndex = 10;
            // 
            // txtBalance
            // 
            this.txtBalance.AutoRoundedCorners = true;
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderRadius = 14;
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
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.HoverState.Parent = this.txtBalance;
            this.txtBalance.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtBalance.Location = new System.Drawing.Point(140, 124);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(87, 78, 87, 78);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderText = "";
            this.txtBalance.SelectedText = "";
            this.txtBalance.ShadowDecoration.Parent = this.txtBalance;
            this.txtBalance.Size = new System.Drawing.Size(165, 31);
            this.txtBalance.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Select Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Paying";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(279, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contact No:";
            // 
            // txtPaying
            // 
            this.txtPaying.AutoRoundedCorners = true;
            this.txtPaying.BackColor = System.Drawing.Color.White;
            this.txtPaying.BorderRadius = 14;
            this.txtPaying.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaying.DefaultText = "";
            this.txtPaying.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaying.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaying.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaying.DisabledState.Parent = this.txtPaying;
            this.txtPaying.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaying.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaying.FocusedState.Parent = this.txtPaying;
            this.txtPaying.ForeColor = System.Drawing.Color.Black;
            this.txtPaying.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaying.HoverState.Parent = this.txtPaying;
            this.txtPaying.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPaying.Location = new System.Drawing.Point(7, 124);
            this.txtPaying.Margin = new System.Windows.Forms.Padding(65, 60, 65, 60);
            this.txtPaying.Name = "txtPaying";
            this.txtPaying.PasswordChar = '\0';
            this.txtPaying.PlaceholderText = "";
            this.txtPaying.SelectedText = "";
            this.txtPaying.ShadowDecoration.Parent = this.txtPaying;
            this.txtPaying.Size = new System.Drawing.Size(124, 31);
            this.txtPaying.TabIndex = 10;
            this.txtPaying.TextChanged += new System.EventHandler(this.txtPaying_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(136, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoRoundedCorners = true;
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.BorderRadius = 14;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtDiscount.Location = new System.Drawing.Point(17, 78);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(87, 78, 87, 78);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(165, 31);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Saved Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Walking Customer";
            // 
            // GBWalking
            // 
            this.GBWalking.Controls.Add(this.txtWChange);
            this.GBWalking.Controls.Add(this.label12);
            this.GBWalking.Controls.Add(this.txtWPaying);
            this.GBWalking.Controls.Add(this.label14);
            this.GBWalking.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.GBWalking.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.GBWalking.ForeColor = System.Drawing.Color.White;
            this.GBWalking.Location = new System.Drawing.Point(10, 126);
            this.GBWalking.Name = "GBWalking";
            this.GBWalking.ShadowDecoration.Parent = this.GBWalking;
            this.GBWalking.Size = new System.Drawing.Size(544, 166);
            this.GBWalking.TabIndex = 12;
            this.GBWalking.Text = "PAYMENTS";
            // 
            // txtWChange
            // 
            this.txtWChange.AutoRoundedCorners = true;
            this.txtWChange.BackColor = System.Drawing.Color.White;
            this.txtWChange.BorderRadius = 14;
            this.txtWChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWChange.DefaultText = "";
            this.txtWChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWChange.DisabledState.Parent = this.txtWChange;
            this.txtWChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWChange.Enabled = false;
            this.txtWChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWChange.FocusedState.Parent = this.txtWChange;
            this.txtWChange.ForeColor = System.Drawing.Color.Black;
            this.txtWChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWChange.HoverState.Parent = this.txtWChange;
            this.txtWChange.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtWChange.Location = new System.Drawing.Point(140, 67);
            this.txtWChange.Margin = new System.Windows.Forms.Padding(87, 78, 87, 78);
            this.txtWChange.Name = "txtWChange";
            this.txtWChange.PasswordChar = '\0';
            this.txtWChange.PlaceholderText = "";
            this.txtWChange.SelectedText = "";
            this.txtWChange.ShadowDecoration.Parent = this.txtWChange;
            this.txtWChange.Size = new System.Drawing.Size(165, 31);
            this.txtWChange.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Paying";
            // 
            // txtWPaying
            // 
            this.txtWPaying.AutoRoundedCorners = true;
            this.txtWPaying.BackColor = System.Drawing.Color.White;
            this.txtWPaying.BorderRadius = 14;
            this.txtWPaying.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWPaying.DefaultText = "";
            this.txtWPaying.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWPaying.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWPaying.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWPaying.DisabledState.Parent = this.txtWPaying;
            this.txtWPaying.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWPaying.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWPaying.FocusedState.Parent = this.txtWPaying;
            this.txtWPaying.ForeColor = System.Drawing.Color.Black;
            this.txtWPaying.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWPaying.HoverState.Parent = this.txtWPaying;
            this.txtWPaying.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtWPaying.Location = new System.Drawing.Point(7, 67);
            this.txtWPaying.Margin = new System.Windows.Forms.Padding(65, 60, 65, 60);
            this.txtWPaying.Name = "txtWPaying";
            this.txtWPaying.PasswordChar = '\0';
            this.txtWPaying.PlaceholderText = "";
            this.txtWPaying.SelectedText = "";
            this.txtWPaying.ShadowDecoration.Parent = this.txtWPaying;
            this.txtWPaying.Size = new System.Drawing.Size(124, 31);
            this.txtWPaying.TabIndex = 10;
            this.txtWPaying.TextChanged += new System.EventHandler(this.txtWPaying_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(136, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 7;
            this.label14.Text = "Change";
            // 
            // POS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSaleCart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.GBCustomer.ResumeLayout(false);
            this.GBCustomer.PerformLayout();
            this.GBWalking.ResumeLayout(false);
            this.GBWalking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DGVSaleCart;
        public System.Windows.Forms.ComboBox cboProducts;
        public Guna.UI2.WinForms.Guna2TextBox txtSearhBarcode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOfProductGV;
        private System.Windows.Forms.DataGridViewButtonColumn ActionAddGV;
        private System.Windows.Forms.DataGridViewButtonColumn ActionRemoveGV;
        private Guna.UI2.WinForms.Guna2GroupBox GBCustomer;
        public Guna.UI2.WinForms.Guna2TextBox txtGrandTotal;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox txtPaying;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox txtContactNo;
        private Guna.UI2.WinForms.Guna2GroupBox GBWalking;
        public Guna.UI2.WinForms.Guna2TextBox txtWChange;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TextBox txtWPaying;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnGenerate;
        private Guna.UI2.WinForms.Guna2TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        public Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        public Guna.UI2.WinForms.Guna2ToggleSwitch CustomerToggle;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblStoreAddress;
    }
}