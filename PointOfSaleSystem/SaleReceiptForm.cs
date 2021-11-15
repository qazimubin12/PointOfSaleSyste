using CrystalDecisions.CrystalReports.Engine;
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
    public partial class SaleReceiptForm : Form
    {
        POS p = new POS();
        ReportDocument rd = new ReportDocument();

        public SaleReceiptForm()
        {
            InitializeComponent();
        }

        private void SaleReceiptForm_Load(object sender, EventArgs e)
        {
            if (POS.SALES_ID != 0)
            {
                if (POS.savedcustomercheck == true)
                {
                    MainClass.ShowSaleRecieptSavedCustomer(rd, crystalReportViewer1, "SaleRecieptOfSavedCustomer", "@SaleID", POS.SALES_ID);
                }
                else
                {
                    MainClass.ShowSaleReciept(rd, crystalReportViewer1, "SaleRecieptOfWalkingCustomer", "@SaleID", POS.SALES_ID);
                }
            }
            else
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select Customer_ID from SalesTable where SaleID = '" + Reports.SALES_ID + "'", MainClass.con);
                object pb = cmd.ExecuteScalar();
                MainClass.con.Close();
                if(pb.ToString() == "")
                {
                    MainClass.ShowSaleReciept(rd, crystalReportViewer1, "SaleRecieptOfWalkingCustomer", "@SaleID", Reports.SALES_ID);
                }
                else
                {
                    MainClass.ShowSaleRecieptSavedCustomer(rd, crystalReportViewer1, "SaleRecieptOfSavedCustomer", "@SaleID", Reports.SALES_ID);
                }
            }
        }

        private void SaleReceiptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
