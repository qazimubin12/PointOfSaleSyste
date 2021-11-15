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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!File.Exists(path + "\\posconnect"))
            {
                DatabaseSettings sl = new DatabaseSettings();
                sl.ShowDialog();
            }
            long fileLen = new FileInfo(path + "\\posconnect").Length;
            if (File.Exists(path + "\\posconnect") && fileLen != 0)
            {
                Login hs = new Login();
                MainClass.showWindow(hs, this);
            }
            else
            {
                DatabaseSettings sl = new DatabaseSettings();
                sl.ShowDialog();
            }
        }
    }
}
