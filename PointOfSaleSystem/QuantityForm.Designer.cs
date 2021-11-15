
namespace PointOfSaleSystem
{
    partial class QuantityForm
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
            this.txtQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbIsPackage = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultText = "1";
            this.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.DisabledState.Parent = this.txtQty;
            this.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.FocusedState.Parent = this.txtQty;
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQty.HoverState.Parent = this.txtQty;
            this.txtQty.Location = new System.Drawing.Point(0, 43);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderText = "Enter Qty";
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionStart = 1;
            this.txtQty.ShadowDecoration.Parent = this.txtQty;
            this.txtQty.Size = new System.Drawing.Size(313, 79);
            this.txtQty.TabIndex = 0;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // CbIsPackage
            // 
            this.CbIsPackage.AutoSize = true;
            this.CbIsPackage.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsPackage.CheckedState.BorderRadius = 2;
            this.CbIsPackage.CheckedState.BorderThickness = 0;
            this.CbIsPackage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbIsPackage.Location = new System.Drawing.Point(210, 13);
            this.CbIsPackage.Name = "CbIsPackage";
            this.CbIsPackage.Size = new System.Drawing.Size(91, 23);
            this.CbIsPackage.TabIndex = 1;
            this.CbIsPackage.Text = "Packing?";
            this.CbIsPackage.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbIsPackage.UncheckedState.BorderRadius = 2;
            this.CbIsPackage.UncheckedState.BorderThickness = 0;
            this.CbIsPackage.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbIsPackage.UseVisualStyleBackColor = true;
            // 
            // QuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 122);
            this.Controls.Add(this.CbIsPackage);
            this.Controls.Add(this.txtQty);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuantityForm";
            this.Text = "Quantity";
            this.Load += new System.EventHandler(this.QuantityForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtQty;
        private Guna.UI2.WinForms.Guna2CheckBox CbIsPackage;
    }
}