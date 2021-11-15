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
    public partial class SearchProducts : Form
    {
        POS p;
        public SearchProducts(POS ps)
        {
            InitializeComponent();
            this.p = ps;
            MainClass.ShowProducts(DGVSearchProducts, ProductIDGV, ProductGV, QuantityGV, txtSearch.Text);
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            MainClass.ShowProducts(DGVSearchProducts, ProductIDGV, ProductGV, QuantityGV, txtSearch.Text);
        }

        private void DGVSearchProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (DGVSearchProducts != null)
                {
                    if (DGVSearchProducts.Rows.Count > 0)
                    {
                        if (DGVSearchProducts.SelectedRows.Count == 1)
                        {
                            if (p != null)
                            {
                                p.cboProducts.SelectedValue = Convert.ToString(DGVSearchProducts.CurrentRow.Cells[0].Value);
                                p.cboProducts.Text = Convert.ToString(DGVSearchProducts.CurrentRow.Cells[1].Value);
                                this.Close();
                            }
                          
                        }
                        else
                        {
                            MessageBox.Show("Please Select Atleast One Record");
                        }
                    }
                    else
                    {
                        MessageBox.Show("List is Empty");
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MainClass.ShowProducts(DGVSearchProducts, ProductIDGV, ProductGV, QuantityGV, txtSearch.Text);
        }
    }
}
