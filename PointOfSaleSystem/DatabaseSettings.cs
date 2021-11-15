using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
        }

        private void DatabaseSettings_Load(object sender, EventArgs e)
        {

        }

        private void ISCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ISCB.Checked == true)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ISCB.Checked == true)
            {
                if (txtServer.Text != "" && txtDatabase.Text != "")
                {
                    s = "Data Source = " + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security = True;";
                    File.WriteAllText(path + "\\posconnect", s);
                }
                else
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            else
            {
                if (txtServer.Text != "" && txtDatabase.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
                {
                    s = "Data Source = " + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID = " + txtUsername.Text + ";Password =" + txtPassword.Text + ";";
                    File.WriteAllText(path + "\\posconnect", s);
                }
                else
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            DialogResult dr = MessageBox.Show("Database Connected Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {

                this.Close();
            }
        }
    }
}
