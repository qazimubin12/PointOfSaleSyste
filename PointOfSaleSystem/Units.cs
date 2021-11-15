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
    public partial class Units : Form
    {
        int uedit = 0;
        public Units()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowUnits(DgvUnits, UNITIDDGV, UnitGV, txtSearch.Text.ToString());
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {

                if (uedit == 0)
                {
                    if (txtUnit.Text == "")
                    {
                        MessageBox.Show("Please Input Details");
                    }
                    else
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("insert into UnitsTable (Unit) values(@Unit)", MainClass.con);
                            cmd.Parameters.AddWithValue("@Unit", txtUnit.Text);

                            cmd.ExecuteNonQuery();
                            MainClass.con.Close();
                            MessageBox.Show("Unit Inserted Successfully.");
                            Clear();
                            ShowUnits(DgvUnits, UNITIDDGV, UnitGV);
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
                    if (uedit == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("update UnitsTable set Unit = @Unit where UnitID = @UnitID", MainClass.con);
                            cmd.Parameters.AddWithValue("@UnitID", lblID.Text);
                            cmd.Parameters.AddWithValue("@Unit", txtUnit.Text);
                            cmd.ExecuteNonQuery();
                            MainClass.con.Close();
                            MessageBox.Show("Unit Updated Successfully.");
                            btnSave.Text = "SAVE";
                            btnSave.BackColor = Color.FromArgb(39, 174, 96);
                            Clear();
                            ShowUnits(DgvUnits, UNITIDDGV, UnitGV);
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            uedit = 0;
            if (btnSave.BackColor == Color.Orange)
            {
                btnSave.Text = "SAVE";
                btnSave.BackColor = Color.FromArgb(39, 174, 96);
                txtUnit.Text = "";
            }
            else
            {
                if (txtUnit.Text == "")
                {
                    HomeScreen hs = new HomeScreen();
                    MainClass.showWindow(hs, this, MDI.ActiveForm);
                }
                else
                {
                    txtUnit.Text = "";
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
             uedit = 1;
            lblID.Text = DgvUnits.CurrentRow.Cells[0].Value.ToString();
            txtUnit.Text = DgvUnits.CurrentRow.Cells[1].Value.ToString();
            btnSave.Text = "UPDATE";
            btnSave.BackColor = Color.Orange;
        }



        private void ShowUnits(DataGridView dgv, DataGridViewColumn ID, DataGridViewColumn Unit, string data = null)
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();
                if (data != "")
                {
                    cmd = new SqlCommand("select * from UnitsTable  where Unit  like '%" + data + "%'", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("select * from UnitsTable order by Unit", MainClass.con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Unit.DataPropertyName = dt.Columns["Unit"].ToString();
                ID.DataPropertyName = dt.Columns["UnitID"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void Units_Load(object sender, EventArgs e)
        {
            ShowUnits(DgvUnits, UNITIDDGV, UnitGV);
        }

        private void Clear()
        {
            txtUnit.Text = "";
        }
        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (DgvUnits != null)
            {
                if (DgvUnits.Rows.Count > 0)
                {
                    if (DgvUnits.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from UnitsTable where UnitID = @UnitID", MainClass.con);
                            cmd.Parameters.AddWithValue("@UnitID", DgvUnits.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowUnits(DgvUnits, UNITIDDGV, UnitGV);
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

        private void button1_Click(object sender, EventArgs e)
        {

            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }
    }
}

