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
    public partial class Settings : Form
    {
        int edit = 0;
        int mode = 0;
        public Settings()
        {
            InitializeComponent();
        }

        private void ShowUsers(DataGridView dgv, DataGridViewColumn NameGV, DataGridViewColumn UsernameGV, DataGridViewColumn PasswordGV, DataGridViewColumn RoleGv)
        {
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select * from UsersTable order by Name", MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                PasswordGV.DataPropertyName = dt.Columns["Password"].ToString();
                RoleGv.DataPropertyName = dt.Columns["Role"].ToString();
                dgv.DataSource = dt;
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        private void CheckMode()
        {
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select InventoryMode from ModeSwitching", MainClass.con);
                mode = int.Parse(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();

                if(mode == 0)
                {
                    modetoggle.Checked = false;
                }
                else
                {
                    modetoggle.Checked = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MainClass.con.Close();
            }
        }



        private void ShowStore()
        {
            MainClass.con.Open();
            SqlCommand cmd = new SqlCommand("select * from StoreTable ", MainClass.con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

                txtStoreName.Text = dr["StoreName"].ToString();
                txtStoreAddress.Text = dr["StoreAddress"].ToString();
                txtLowStockQty.Text = dr["LowStockQty"].ToString();
            }
            else
            {
                txtStoreName.Text = "";
                txtStoreAddress.Text = "";
                txtLowStockQty.Text = "";
            }
           
            dr.Close();
            MainClass.con.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                if (txtName.Text == "" && txtUsername.Text == "" && txtPasword.Text == "" && cboRole.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Input Details");
                }
                else
                {
                    if (txtPasword.Text != txtConfimPassword.Text)
                    {
                        MessageBox.Show("Password Mismatched");
                    }
                    else
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("insert into UsersTable (Name,Username,Password,Role) values(@Name,@Username,@Password,@Role)", MainClass.con);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtConfimPassword.Text);
                            cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem);
                            cmd.ExecuteNonQuery();
                            MainClass.con.Close();
                            MessageBox.Show("User Updated Successfully.");
                            Clear();
                            ShowUsers(DgvUsers, NameGV, UserNameGV, PasswordGV, RoleGV);
                        }
                        catch (Exception ex)
                        {
                            MainClass.con.Close();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                if (edit == 1)
                {
                    if (txtPasword.Text != txtConfimPassword.Text)
                    {
                        MessageBox.Show("Password Mismatched");
                    }
                    else
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("update UsersTable set Name = @Name, @Password = @Password, Role = @Role where Username = @Username", MainClass.con);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text);
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@Password", txtConfimPassword.Text);
                            cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem);
                            cmd.ExecuteNonQuery();
                            MainClass.con.Close();
                            MessageBox.Show("User Updated Successfully.");
                            Clear();
                            ShowUsers(DgvUsers, NameGV, UserNameGV, PasswordGV, RoleGV);
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
            if (txtName.Text != "" || txtUsername.Text != "" || txtPasword.Text != "" || cboRole.SelectedIndex != 0 || txtConfimPassword.Text != "")
            {
                Clear();
                edit = 0;
            }
            else
            {
                HomeScreen ds = new HomeScreen();
                MainClass.showWindow(ds, this, MDI.ActiveForm);
            }
        }
        void Clear()
        {
            txtName.Text = "";
            txtUsername.Text = "";
            txtPasword.Text = "";
            txtConfimPassword.Text = "";
            cboRole.SelectedIndex = 0;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = 1;
            txtName.Text = DgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = DgvUsers.CurrentRow.Cells[0].Value.ToString();
            txtPasword.Text = DgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtConfimPassword.Text = DgvUsers.CurrentRow.Cells[2].Value.ToString();
            cboRole.SelectedItem = DgvUsers.CurrentRow.Cells[3].Value.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvUsers != null)
            {
                if (DgvUsers.Rows.Count > 0)
                {
                    if (DgvUsers.SelectedRows.Count == 1)
                    {
                        try
                        {
                            MainClass.con.Open();
                            SqlCommand cmd = new SqlCommand("delete from Users where Username = @Username", MainClass.con);
                            cmd.Parameters.AddWithValue("@Username", DgvUsers.CurrentRow.Cells[0].Value.ToString());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully");
                            MainClass.con.Close();
                            ShowUsers(DgvUsers, NameGV, UserNameGV, PasswordGV, RoleGV);
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

        private void Settings_Load(object sender, EventArgs e)
        {
            ShowUsers(DgvUsers, NameGV, UserNameGV, PasswordGV, RoleGV);
            MainClass.HideAllTabsOnTabControl(tabControl1);
            tabControl1.SelectedIndex = 0;
            CheckMode();
            ShowStore();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnDatabaseSettings_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeScreen ds = new HomeScreen();
            MainClass.showWindow(ds, this, MDI.ActiveForm);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            String Database = MainClass.con.Database.ToString();
            try
            {
                MainClass.con.Open();
                if (txtBackup.Text == "")
                {
                    MessageBox.Show("Please Locate The Backup File", "Error", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    string q = "BACKUP DATABASE[" + Database + "] TO DISK = '" + txtBackup.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                    SqlCommand cmd = new SqlCommand(q, MainClass.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Backup Success", "Success", MessageBoxButtons.OK);
                }
                MainClass.con.Close();
            }

            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();
            String Database = MainClass.con.Database.ToString();
            try
            {
                string sql1 = string.Format("ALTER DATABASE [" + Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd = new SqlCommand(sql1, MainClass.con);
                cmd.ExecuteNonQuery();

                string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + Database + "] FROM DISK='" + txtRestore.Text + "' WITH REPLACE;");
                SqlCommand cmd2 = new SqlCommand(sql2, MainClass.con);
                cmd2.ExecuteNonQuery();

                string sql3 = string.Format("ALTER DATABASE [" + Database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(sql3, MainClass.con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { MainClass.con.Close(); }

        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = fbd.SelectedPath;
                btnBackupBrowse.Enabled = true;
            }
        }

        private void btnSaveMode_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();
            SqlCommand cmd = new SqlCommand("update ModeSwitching set InventoryMode = @InventoryMode", MainClass.con);
            if(modetoggle.Checked == false)
            {
                cmd.Parameters.AddWithValue("@InventoryMode", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@InventoryMode", 1);

            }
            cmd.ExecuteNonQuery();
            MessageBox.Show("Settings Updated Successfully");
            MainClass.con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            if(txtStoreName.Text != "")
            {
                btnSaveStore.Enabled = false;
                btnUpdateStore.Enabled = true;
            }
            else
            {
                btnSaveStore.Enabled = true;
                btnUpdateStore.Enabled = false;
            }
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();
            SqlCommand cmd = new SqlCommand("insert into StoreTable (StoreName,StoreAddress,LowStockQty) values (@StoreName,@StoreAddress,@LowStockQty) ", MainClass.con);
            cmd.Parameters.AddWithValue("@StoreName", txtStoreName.Text);
            cmd.Parameters.AddWithValue("@StoreAddress", txtStoreAddress.Text);
            cmd.Parameters.AddWithValue("@LowStockQty", txtLowStockQty.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Store Saved Successfully");
            MainClass.con.Close();
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();
            SqlCommand cmd = new SqlCommand("update StoreTable set StoreName = @StoreName, StoreAddress= @StoreAddress , LowStockQty = @LowStockQty ", MainClass.con);
            cmd.Parameters.AddWithValue("@StoreName", txtStoreName.Text);
            cmd.Parameters.AddWithValue("@StoreAddress", txtStoreAddress.Text);
            cmd.Parameters.AddWithValue("@LowStockQty", txtLowStockQty.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Store Updated Successfully");
            MainClass.con.Close();
            ShowStore();
        }
    }
}
