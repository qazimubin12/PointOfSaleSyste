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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }


        

     

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);

        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            Units u = new Units();
            MainClass.showWindow(u, this, MDI.ActiveForm);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showWindow(p, this, MDI.ActiveForm);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            Persons p = new Persons();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseInvoice p = new PurchaseInvoice();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();
            MainClass.showWindow(i, this, MDI.ActiveForm);
        }

        private void btnLedgers_Click(object sender, EventArgs e)
        {
            Ledgers l = new Ledgers();
            MainClass.showWindow(l, this, MDI.ActiveForm);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            POS p = new POS();
            MainClass.showWindow(p, this, MDI.ActiveForm);
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
                    btnPurchase.Visible = false;
                    btnInventory.Visible = false;
                    lowStocksPanel.Visible = false;
                    btnPos.Location = new Point(3, 125);
                }
                else
                {
                    btnPurchase.Visible = true;
                    btnInventory.Visible = true;
                    lowStocksPanel.Visible = true;
                    btnPos.Location = new Point(3, 247);

                }

                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FindDailySales()
        {
            string sdate = DateTime.Now.ToShortDateString();
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select sum(GrandTotal) from SalesTable st where st.SaleDate between '" + sdate + "' and  '" + sdate + "'", MainClass.con);
                lblDailySales.Text = cmd.ExecuteScalar().ToString();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FindCustomerBalance()
        {
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select sum(Balance) from CustomerLedgersTable", MainClass.con);
                lblTotalCustomerLedger.Text = cmd.ExecuteScalar().ToString();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }



        private void FindLowStocks()
        {
            try
            {
                SqlCommand cmd = null;
                MainClass.con.Open();
                float lowqty;
                cmd = new SqlCommand("select LowStockQty from StoreTable",MainClass.con);
                object l = cmd.ExecuteScalar();
                if(l == null)
                {
                    lowqty = 0;
                }
                else
                {
                    lowqty = float.Parse(l.ToString());
                }


                cmd = new SqlCommand("select count(*) from Inventory where Qty < "+lowqty.ToString()+"  ", MainClass.con);
                lblLowStocks.Text = cmd.ExecuteScalar().ToString();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FindTodayExpense()
        {
            object Expense = null;
            string sdate = DateTime.Now.ToShortDateString();

            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("select sum(ExpensePrice) from ExpensesTable  where ExpenseDate between '" + sdate + "' and '" + sdate + "'", MainClass.con);
                Expense = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
            lblExpense.Text = Expense.ToString();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            CheckMode();
            FindDailySales();
            FindTodayExpense();
            FindCustomerBalance();
            FindLowStocks();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login ls = new Login();
            MainClass.showWindow(ls, this, MDI.ActiveForm);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expenses es = new Expenses();
            MainClass.showWindow(es, this, MDI.ActiveForm);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            MainClass.showWindow(r, this, MDI.ActiveForm);
        }
    }
}
