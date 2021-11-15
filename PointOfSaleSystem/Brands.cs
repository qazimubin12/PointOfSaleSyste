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
    public partial class Brands : Form
    {
        int bedit = 0;
        public Brands()
        {
            InitializeComponent();
        }

        private void ShowBrands(DataGridView dgv, DataGridViewColumn ID, DataGridViewColumn Brand, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();
                if (data != "")
                {
                    cmd = new SqlCommand("select * from BrandsTable  where Brand  like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select * from BrandsTable order by Brand", MainClass.con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Brand.DataPropertyName = dt.Columns["Brand"].ToString();
                ID.DataPropertyName = dt.Columns["BrandID"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Brands_Load(object sender, EventArgs e)
        {

            ShowBrands(DgvBrands, BrandIDGV, BrandGV);

        }

        private void Clear()
        {
            txtBrand.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bedit == 0)
            {
                if (txtBrand.Text == "")
                {
                    MessageBox.Show("Please Input Details");
                }
                else
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("insert into BrandsTable (Brand) values(@Brand)", MainClass.con);
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);

                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Brand Inserted Successfully.");
                        Clear();
                        ShowBrands(DgvBrands, BrandIDGV, BrandGV);
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
                if (bedit == 1)
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("update BrandsTable set Brand = @Brand where BrandID = @BrandID", MainClass.con);
                        cmd.Parameters.AddWithValue("@BrandID", lblID.Text);
                        cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Brand Updated Successfully.");
                        btnSave.Text = "SAVE";
                        btnSave.BackColor = Color.FromArgb(39, 174, 96);
                        Clear();
                        ShowBrands(DgvBrands, BrandIDGV, BrandGV);
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bedit = 1;
            lblID.Text = DgvBrands.CurrentRow.Cells[0].Value.ToString();
            txtBrand.Text = DgvBrands.CurrentRow.Cells[1].Value.ToString();
            btnSave.Text = "UPDATE";
            btnSave.BackColor = Color.Orange;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvBrands != null)
            {
                if (DgvBrands.Rows.Count > 0)
                {
                    if (DgvBrands.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from BrandsTable where BrandID = @BrandID", MainClass.con);
                            cmd.Parameters.AddWithValue("@BrandID", DgvBrands.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowBrands(DgvBrands, BrandIDGV, BrandGV);
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

        private void btnCancelB_Click(object sender, EventArgs e)
        {
            bedit = 0;
            if (btnSave.BackColor == Color.Orange)
            {
                btnSave.Text = "SAVE";
                btnSave.BackColor = Color.FromArgb(39, 174, 96);
                txtBrand.Text = "";
            }
            else
            {
                if (txtBrand.Text == "")
                {
                    HomeScreen hs = new HomeScreen();
                    MainClass.showWindow(hs, this, MDI.ActiveForm);
                }
                else
                {
                    txtBrand.Text = "";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowBrands(DgvBrands, BrandIDGV, BrandGV, txtSearch.Text.ToString());
        }

        private void DgvBrands_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvBrands.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}

