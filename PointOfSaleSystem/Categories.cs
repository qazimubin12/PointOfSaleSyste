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
    public partial class Categories : Form
    {
        int cedit = 0;
        public Categories()
        {
            InitializeComponent();
        }

        private void ShowCategorys(DataGridView dgv, DataGridViewColumn ID, DataGridViewColumn Category, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();
                if (data != "")
                {
                    cmd = new SqlCommand("select * from CategoriesTable  where Category  like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select * from CategoriesTable order by Category", MainClass.con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Category.DataPropertyName = dt.Columns["Category"].ToString();
                ID.DataPropertyName = dt.Columns["CategoryID"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Categorys_Load(object sender, EventArgs e)
        {
            ShowCategorys(DgvCategory, CatIDGV, CategoryGV);
        }

        private void Clear()
        {
            txtCategory.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cedit == 0)
            {
                if (txtCategory.Text == "")
                {
                    MessageBox.Show("Please Input Details");
                }
                else
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("insert into CategoriesTable (Category) values(@Category)", MainClass.con);
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text);

                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Category Inserted Successfully.");
                        Clear();
                        ShowCategorys(DgvCategory, CatIDGV, CategoryGV);
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
                if (cedit == 1)
                {
                    try
                    {
                        MainClass.con.Open();
                        SqlCommand cmd = new SqlCommand("update CategoriesTable set Category = @Category where CategoryID = @CategoryID", MainClass.con);
                        cmd.Parameters.AddWithValue("@CategoryID", lblID.Text);
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                        cmd.ExecuteNonQuery();
                        MainClass.con.Close();
                        MessageBox.Show("Category Updated Successfully.");
                        btnSave.Text = "SAVE";
                        btnSave.BackColor = Color.FromArgb(39, 174, 96);
                        Clear();
                        ShowCategorys(DgvCategory, CatIDGV, CategoryGV);
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
            cedit = 1;
            lblID.Text = DgvCategory.CurrentRow.Cells[0].Value.ToString();
            txtCategory.Text = DgvCategory.CurrentRow.Cells[1].Value.ToString();
            btnSave.Text = "UPDATE";
            btnSave.BackColor = Color.Orange;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvCategory != null)
            {
                if (DgvCategory.Rows.Count > 0)
                {
                    if (DgvCategory.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from CategoriesTable where CategoryID = @CategoryID", MainClass.con);
                            cmd.Parameters.AddWithValue("@CategoryID", DgvCategory.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowCategorys(DgvCategory, CatIDGV, CategoryGV);
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
            cedit = 0;
            if (btnSave.BackColor == Color.Orange)
            {
                btnSave.Text = "SAVE";
                btnSave.BackColor = Color.FromArgb(39, 174, 96);
                txtCategory.Text = "";
            }
            else
            {
                if (txtCategory.Text == "")
                {
                    HomeScreen hs = new HomeScreen();
                    MainClass.showWindow(hs, this, MDI.ActiveForm);
                }
                else
                {
                    txtCategory.Text = "";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowCategorys(DgvCategory, CatIDGV, CategoryGV, txtSearch.Text.ToString());

        }

        private void DgvCategory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvCategory.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}

