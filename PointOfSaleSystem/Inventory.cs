using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PointOfSaleSystem
{
    public partial class Inventory : Form
    {
        private void ShowStocks(DataGridView dgv, DataGridViewColumn Product,DataGridViewColumn Barcode, DataGridViewColumn Unit, DataGridViewColumn Qty, DataGridViewColumn Rate, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                if (data != null)
                {
                    cmd = new SqlCommand("select p.ProductName,i.Barcode,u.Unit,i.Qty,i.Rate from Inventory i inner join ProductsTable p on p.ProductID = i.ProductID inner join UnitsTable u on u.UnitID = i.Unit where p.ProductName like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select p.ProductName,i.Barcode,u.Unit,i.Qty,i.Rate from Inventory i inner join ProductsTable p on p.ProductID = i.ProductID inner join UnitsTable u on u.UnitID = i.Unit", MainClass.con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Product.DataPropertyName = dt.Columns["ProductName"].ToString();
                Barcode.DataPropertyName = dt.Columns["Barcode"].ToString();
                Unit.DataPropertyName = dt.Columns["Unit"].ToString();
                Qty.DataPropertyName = dt.Columns["Qty"].ToString();
                Rate.DataPropertyName = dt.Columns["Rate"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            ShowStocks(DGVInventory, ProductGV,BarcodeGV ,UnitGV, QuantityGV, RateGV);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            cbPackage.Checked = false;
            ShowStocks(DGVInventory, ProductGV, BarcodeGV,UnitGV, QuantityGV, RateGV, txtSearch.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }

        private void DGVInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGVInventory.ClearSelection();
        }

        private void cbPackage_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            if (cbPackage.Checked == true)
            {
                foreach (DataGridViewRow item in DGVInventory.Rows)
                {
                    bool check = false;
                    try
                    {
                        MainClass.con.Open();
                        cmd = new SqlCommand("select IsPackage from ProductsTable where ProductName = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                        check = bool.Parse(cmd.ExecuteScalar().ToString());
                        MainClass.con.Close();
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    } //Check
                    if (check == true)
                    {

                        object packqty = null;
                        object rate = null;
                        object unit = null;
                        try
                        {
                            MainClass.con.Open();
                            cmd = new SqlCommand("select PackQty from ProductsTable where ProductName = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                            packqty = cmd.ExecuteScalar();
                            MainClass.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        } //Packqty
                        try
                        {
                            MainClass.con.Open();
                            cmd = new SqlCommand("select u.Unit from ProductsTable p inner join UnitsTable u on u.UnitID = p.PackUnitID where p.ProductName = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                            unit = cmd.ExecuteScalar();
                            MainClass.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        } //Unit
                        try
                        {
                            MainClass.con.Open();
                            cmd = new SqlCommand("select PackCostPrice from ProductsTable where ProductName = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                            rate = cmd.ExecuteScalar();
                            MainClass.con.Close();
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        } //Rate

                        item.Cells[1].Value = unit.ToString();
                        float qty = float.Parse(item.Cells[2].Value.ToString());
                        qty = float.Parse(qty.ToString()) / float.Parse(packqty.ToString());
                        item.Cells[2].Value = qty;
                        item.Cells[3].Value = rate;
                    }
                }
            }
            else
            {
                ShowStocks(DGVInventory, ProductGV, BarcodeGV, UnitGV, QuantityGV, RateGV);
            }

        }
    }
}
