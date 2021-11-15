using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class Products : Form
    {
        int show = 0;
        int pedit = 0;
        public Products()
        {
            InitializeComponent();
        }

        private void CheckMode()
        {
            int mode;
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select InventoryMode from ModeSwitching", MainClass.con);
                mode = int.Parse(cmd.ExecuteScalar().ToString());
                if (mode == 0)
                {
                    label2.Visible = false;
                    label6.Visible = false;
                 //   cbPackage.Visible = false;
                    DGVSomeProducts.Columns["CostSID"].Visible = false;
                    DGVSomeProducts.Columns["BarcodeSID"].Visible = false;
                    txtBarcode.Visible = false;
                    txtCostPrice.Visible = false;

                }
                else
                {
                    label2.Visible = true;
                    label6.Visible = true;
                //    cbPackage.Visible = true;
                    txtBarcode.Visible = true;
                    txtCostPrice.Visible = true;
                    DGVSomeProducts.Columns["CostSID"].Visible = true;
                    DGVSomeProducts.Columns["BarcodeSID"].Visible = true;


                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void ShowProductSID(DataGridView dgv2, DataGridViewColumn ID, DataGridViewColumn Barcode, DataGridViewColumn Name, DataGridViewColumn Cat, DataGridViewColumn Cost,
           DataGridViewColumn Sale, DataGridViewColumn Remarks, DataGridViewColumn Unit, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();

                if (data != "")
                {
                    cmd = new SqlCommand("select p.ProductID,p.Barcode,p.ProductName,c.Category,u.Unit,p.CostPrice,p.SalePrice,p.Remarks from ProductsTable p inner join CategoriesTable c on c.CategoryID = p.CatID  join UnitsTable u on u.UnitID = p.UnitID  where p.ProductName like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select p.ProductID,p.Barcode,p.ProductName,c.Category,u.Unit,p.CostPrice,p.SalePrice,p.Remarks from ProductsTable p inner join CategoriesTable c on c.CategoryID = p.CatID  join UnitsTable u on u.UnitID = p.UnitID  order by p.ProductName", MainClass.con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ID.DataPropertyName = dt.Columns["ProductID"].ToString();
                Name.DataPropertyName = dt.Columns["ProductName"].ToString();
                Barcode.DataPropertyName = dt.Columns["Barcode"].ToString();
                Cat.DataPropertyName = dt.Columns["Category"].ToString();
                Cost.DataPropertyName = dt.Columns["CostPrice"].ToString();
                Sale.DataPropertyName = dt.Columns["SalePrice"].ToString();
                Remarks.DataPropertyName = dt.Columns["Remarks"].ToString();
                Unit.DataPropertyName = dt.Columns["Unit"].ToString();
                dgv2.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void ShowProducts(DataGridView dgv, DataGridViewColumn ID, DataGridViewColumn Barcode, DataGridViewColumn Name, DataGridViewColumn Cat,  DataGridViewColumn Cost,
            DataGridViewColumn Sale, DataGridViewColumn Remarks, DataGridViewColumn Unit, DataGridViewCheckBoxColumn Packing, DataGridViewColumn PackQty, DataGridViewColumn PackCost,
            DataGridViewColumn PackSale, DataGridViewColumn PackUnit, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();

                if (data != null)
                {
                    cmd = new SqlCommand("select p.ProductID,p.Barcode,p.ProductName,c.Category,u.Unit,p.CostPrice,p.SalePrice,p.Remarks,p.IsPackage,p.PackQty,p.PackCostPrice,p.PackSalePrice,up.Unit as 'Pack Unit' from ProductsTable p  inner join CategoriesTable c on c.CategoryID = p.CatID  join UnitsTable u on u.UnitID = p.UnitID join UnitsTable up on up.UnitID = p.PackUnitID where p.ProductName like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select p.ProductID,p.Barcode,p.ProductName,c.Category,u.Unit,p.CostPrice,p.SalePrice,p.Remarks,p.IsPackage,p.PackQty,p.PackCostPrice,p.PackSalePrice,up.Unit as 'Pack Unit' from ProductsTable p inner join CategoriesTable c on c.CategoryID = p.CatID  join UnitsTable u on u.UnitID = p.UnitID join UnitsTable up on up.UnitID = p.PackUnitID order by p.ProductName", MainClass.con);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ID.DataPropertyName = dt.Columns["ProductID"].ToString();
                Name.DataPropertyName = dt.Columns["ProductName"].ToString();
                Barcode.DataPropertyName = dt.Columns["Barcode"].ToString();
                Cat.DataPropertyName = dt.Columns["Category"].ToString();
                Cost.DataPropertyName = dt.Columns["CostPrice"].ToString();
                Sale.DataPropertyName = dt.Columns["SalePrice"].ToString();
                Remarks.DataPropertyName = dt.Columns["Remarks"].ToString();
                Unit.DataPropertyName = dt.Columns["Unit"].ToString();
                Packing.DataPropertyName = dt.Columns["IsPackage"].ToString();
                PackQty.DataPropertyName = dt.Columns["PackQty"].ToString();
                PackCost.DataPropertyName = dt.Columns["PackCostPrice"].ToString();
                PackSale.DataPropertyName = dt.Columns["PackSalePrice"].ToString();
                PackUnit.DataPropertyName = dt.Columns["Pack Unit"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void ShownHide()
        {
            if (cbPackage.Checked == true)
            {
                show = 1;
                GBPacking.Visible = true;
                IsPackageGV.Visible = true;
                PackCostGV.Visible = true;
                PackSaleGV.Visible = true;
                PackUnitGV.Visible = true;
                PackQtyGv.Visible = true;
            }
            else
            {
                show = 0;
                GBPacking.Visible = false;
                IsPackageGV.Visible = false;
                PackCostGV.Visible = false;
                PackSaleGV.Visible = false;
                PackUnitGV.Visible = false;
                PackQtyGv.Visible = false;

            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            CheckMode();
            ShownHide();
            MainClass.FillCategories(cboCategory);
            MainClass.FillUnits(cboPackUnit);
            MainClass.FillUnits(cboUnits);
            DGVSomeProducts.BringToFront();
            ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID, txtSearch.Text.ToString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (show == 1)
            {
                ShowProducts(DgvProducts, ProIDGV, BarcodeGV, ProductNameGV, CategoryGV, CostPriceGV, SalePriceGV, RemarksGV, UnitGV, IsPackageGV, PackQtyGv, PackCostGV, PackSaleGV, PackUnitGV, txtSearch.Text.ToString());
            }
            else
            {
                ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID,txtSearch.Text.ToString());
            }
        }

        private void cbPackage_CheckedChanged(object sender, EventArgs e)
        {
            ShownHide();
            if (show == 1)
            {
                DgvProducts.BringToFront();
                ShowProducts(DgvProducts, ProIDGV, BarcodeGV, ProductNameGV, CategoryGV, CostPriceGV, SalePriceGV, RemarksGV, UnitGV, IsPackageGV, PackQtyGv, PackCostGV, PackSaleGV, PackUnitGV, txtSearch.Text.ToString());
            }
            else
            {
                DGVSomeProducts.BringToFront();
                ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID, txtSearch.Text.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }

        private void Clear()
        {
            txtBarcode.Text = "";
            txtProductName.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtPackQty.Text = "";
            txtPackCostPrice.Text = "";
            txtPackSalePrice.Text = "";
            txtRemarks.Text = "";
            cboUnits.SelectedIndex = 0;
            cboPackUnit.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlDataReader dr;

            string catId = "";
            string unitid = "";
            string packunitid = "";

            MainClass.con.Open();

            //CatUnit
            cmd = new SqlCommand("select CategoryID from CategoriesTable where Category like '" + cboCategory.Text + "'", MainClass.con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    catId = dr[0].ToString();
                }
            }
            dr.Close();

            
            //Unit
            cmd = new SqlCommand("select UnitID from UnitsTable where Unit like '" + cboUnits.Text + "'", MainClass.con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    unitid = dr[0].ToString();
                }
            }
            dr.Close();
            
            //Pack Unit
            cmd = new SqlCommand("select UnitID from UnitsTable where Unit like '" + cboPackUnit.Text + "'", MainClass.con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    packunitid = dr[0].ToString();
                }
            }
            dr.Close();
            
            
            MainClass.con.Close();

            if (pedit == 0)
            {
                if (txtProductName.Text == "" || txtSalePrice.Text == "" || txtCostPrice.Text == "" ||
                    cboCategory.SelectedIndex == 0 || cboUnits.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Input Details");
                }
                else
                {
                    try
                    {
                        MainClass.con.Open();
                        cmd = new SqlCommand("insert into ProductsTable (Barcode,ProductName,CatID,UnitID,CostPrice,SalePrice,Remarks,IsPackage,PackQty,PackCostPrice,PackSalePrice,PackUnitID) values(@Barcode,@ProductName,@CatID,@UnitID,@CostPrice,@SalePrice,@Remarks,@IsPackage,@PackQty,@PackCostPrice,@PackSalePrice,@PackUnitID)", MainClass.con);
                        cmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@CatID", catId);
                        cmd.Parameters.AddWithValue("@UnitID", unitid);
                        cmd.Parameters.AddWithValue("@CostPrice", txtCostPrice.Text);
                        cmd.Parameters.AddWithValue("@SalePrice", txtSalePrice.Text);
                        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                        cmd.Parameters.AddWithValue("@IsPackage", cbPackage.Checked);
                        cmd.Parameters.AddWithValue("@PackQty", txtPackQty.Text);
                        cmd.Parameters.AddWithValue("@PackCostPrice", txtPackCostPrice.Text);
                        cmd.Parameters.AddWithValue("@PackSalePrice", txtPackSalePrice.Text);
                        if (cboPackUnit.SelectedIndex == 0)
                        {
                            cmd.Parameters.AddWithValue("@PackUnitID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PackUnitID", packunitid);
                        }
                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Product Inserted Successfully.");
                        Clear();
                        ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                if (pedit == 1)
                {                    
                    try
                    {
                        MainClass.con.Open();
                        cmd = new SqlCommand("UPDATE ProductsTable SET Barcode =@Barcode,ProductName =@ProductName,CatID =@CatID,UnitID =@UnitID,CostPrice =@CostPrice,SalePrice =@SalePrice, Remarks =@Remarks,IsPackage =@IsPackage,PackQty =@PackQty,PackCostPrice =@PackCostPrice,PackSalePrice =@PackSalePrice,PackUnitID =@PackUnitID where ProductID = @ProductID", MainClass.con);
                        cmd.Parameters.AddWithValue("@ProductID", lblID.Text);
                        cmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@CatID", catId);
                        cmd.Parameters.AddWithValue("@UnitID", unitid);
                        cmd.Parameters.AddWithValue("@CostPrice", txtCostPrice.Text);
                        cmd.Parameters.AddWithValue("@SalePrice", txtSalePrice.Text);
                        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                        cmd.Parameters.AddWithValue("@IsPackage", cbPackage.Checked);
                        cmd.Parameters.AddWithValue("@PackQty", txtPackQty.Text);
                        cmd.Parameters.AddWithValue("@PackCostPrice", txtPackCostPrice.Text);
                        cmd.Parameters.AddWithValue("@PackSalePrice", txtPackSalePrice.Text);
                        if (cboPackUnit.SelectedIndex == 0)
                        {
                            cmd.Parameters.AddWithValue("@PackUnitID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PackUnitID", packunitid);
                        }
                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Product Updated Successfully.");
                        btnSave.Text = "SAVE";
                        btnSave.BackColor = Color.FromArgb(39, 174, 96);
                        Clear();
                        ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pedit = 1;
            lblID.Text = DgvProducts.CurrentRow.Cells[0].Value.ToString();
            txtBarcode.Text = DgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtProductName.Text = DgvProducts.CurrentRow.Cells[2].Value.ToString();
            cboCategory.Text = DgvProducts.CurrentRow.Cells[3].Value.ToString();
            cboUnits.Text = DgvProducts.CurrentRow.Cells[4].Value.ToString();
            txtCostPrice.Text = DgvProducts.CurrentRow.Cells[5].Value.ToString();
            txtSalePrice.Text = DgvProducts.CurrentRow.Cells[6].Value.ToString();
            txtRemarks.Text = DgvProducts.CurrentRow.Cells[7].Value.ToString();
            cbPackage.Checked = bool.Parse(DgvProducts.CurrentRow.Cells[8].Value.ToString());
            txtPackQty.Text = DgvProducts.CurrentRow.Cells[9].Value.ToString();
            txtPackCostPrice.Text = DgvProducts.CurrentRow.Cells[10].Value.ToString();
            txtPackSalePrice.Text = DgvProducts.CurrentRow.Cells[11].Value.ToString();
            cboPackUnit.Text = DgvProducts.CurrentRow.Cells[12].Value.ToString();
            btnSave.Text = "UPDATE";
            btnSave.BackColor = Color.Orange;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (DgvProducts != null)
            {
                if (DgvProducts.Rows.Count > 0)
                {
                    if (DgvProducts.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from ProductsTable where ProductID = @ProductID", MainClass.con);
                            cmd.Parameters.AddWithValue("@ProductID", DgvProducts.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowProducts(DgvProducts, ProIDGV, BarcodeGV, ProductNameGV, CategoryGV, CostPriceGV, SalePriceGV, RemarksGV, UnitGV, IsPackageGV, PackQtyGv, PackCostGV, PackSaleGV, PackUnitGV);
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedit = 1;
            lblID.Text = DGVSomeProducts.CurrentRow.Cells[0].Value.ToString();
            txtBarcode.Text = DGVSomeProducts.CurrentRow.Cells[1].Value.ToString();
            txtProductName.Text = DGVSomeProducts.CurrentRow.Cells[2].Value.ToString();
            cboCategory.Text = DGVSomeProducts.CurrentRow.Cells[3].Value.ToString();
            cboUnits.Text = DGVSomeProducts.CurrentRow.Cells[4].Value.ToString();
            txtCostPrice.Text = DGVSomeProducts.CurrentRow.Cells[5].Value.ToString();
            txtSalePrice.Text = DGVSomeProducts.CurrentRow.Cells[6].Value.ToString();
            txtRemarks.Text = DGVSomeProducts.CurrentRow.Cells[7].Value.ToString();
           
            btnSave.Text = "UPDATE";
            btnSave.BackColor = Color.Orange;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVSomeProducts != null)
            {
                if (DGVSomeProducts.Rows.Count > 0)
                {
                    if (DGVSomeProducts.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from ProductsTable where ProductID = @ProductID", MainClass.con);
                            cmd.Parameters.AddWithValue("@ProductID", DGVSomeProducts.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowProductSID(DGVSomeProducts, ProSID, BarcodeSID, NameSID, CategorySID, CostSID, SaleSID, RemarksSID, UnitSID);
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pedit = 0;
            if (btnSave.BackColor == Color.Orange)
            {
                btnSave.Text = "SAVE";
                btnSave.BackColor = Color.FromArgb(39, 174, 96);
                Clear();
            }
            else
            {
                if (txtBarcode.Text == "" &&
                txtProductName.Text == "" &&
                txtCostPrice.Text == "" &&
                txtSalePrice.Text == "" &&
                txtPackQty.Text == "" &&
                txtPackCostPrice.Text == "" &&
                txtPackSalePrice.Text == "" &&
                txtRemarks.Text == "" &&
                cboUnits.SelectedIndex == 0 &&
                cboPackUnit.SelectedIndex == 0 &&
                cboCategory.SelectedIndex == 0 )
                {
                    HomeScreen hs = new HomeScreen();
                    MainClass.showWindow(hs, this, MDI.ActiveForm);
                }
                else
                {
                    Clear();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
