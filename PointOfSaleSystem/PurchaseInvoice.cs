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
    public partial class PurchaseInvoice : Form
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.showWindow(hs, this, MDI.ActiveForm);
        }

        private void GenerateInvoiceNo()
        {
            try
            {
                MainClass.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select InvoiceNo from InvoiceNo order by InvoiceNo desc", MainClass.con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count > 0)
                {
                    txtInvoiceNo.Text = (int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1).ToString();
                }
                else
                {
                    txtInvoiceNo.Text = "1";
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                MainClass.con.Open();
                SqlCommand cmd = new SqlCommand("insert into InvoiceNo (InvoiceNo) values ('" + txtInvoiceNo.Text + "')", MainClass.con);
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                GenerateInvoiceNo();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            GenerateInvoiceNo();
            MainClass.FillSupplier(cboSupplier);
            MainClass.FillProducts(cboProducts);
            cboUnit.Text = "";
        }
            
        private void FillUnitComboBox(ComboBox cmb)
        {
            try
            {
                DataTable dtUnits = new DataTable();
                dtUnits.Columns.Add("Unit");
                dtUnits.Columns.Add("UnitID");
              
                DataTable dt = MainClass.Retrieve("select u.Unit,u.UnitID from UnitsTable u join ProductsTable p on p.UnitID = u.UnitID  union select up.Unit,up.UnitID  from UnitsTable up join ProductsTable p on p.PackUnitID = up.UnitID  where ProductID = '" + cboProducts.SelectedValue.ToString() + "'");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow units in dt.Rows)
                        {
                            dtUnits.Rows.Add(units["Unit"], units["UnitID"]);
                        }
                    }
                }
                cmb.DisplayMember = "Unit";
                cmb.ValueMember = "UnitID";
                cmb.DataSource = dtUnits;
                
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        bool found = false;
        object item = false;
        int packqty = 0;
        private string[] ProductsData = new string[3];
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboProducts.SelectedIndex == 0)
            {
                cboUnit.Text = "";
                txtCostPrice.Text = "";
                txtSalePrice.Text = "";
                return;
            }
            SqlCommand cmd = null;
            try
            {
                MainClass.con.Open();
                cmd = new SqlCommand("select PackUnitID from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "'", MainClass.con);
                object ob = cmd.ExecuteScalar();
                if(ob == null)
                {
                    found = false;
                }
                else
                {
                    found = true;
                    try
                    {
                        cmd = new SqlCommand("select PackQty from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "'", MainClass.con);
                        packqty = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    catch (Exception ex)
                    {
                        MainClass.con.Close();
                        MessageBox.Show(ex.Message);
                    } //Finding Pack Qty

                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            } // Finding PackUnit / Qty

            FillUnitComboBox(cboUnit);
        }


        private void GetPrice()
        {
            SqlCommand cmd = null;
            SqlDataReader dr;
            try
            {
                MainClass.con.Open();
                cmd = new SqlCommand("select IsPackage from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "'", MainClass.con);
                item = cmd.ExecuteScalar().ToString();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }

            try
            {
                MainClass.con.Open();
                DataTable dt = new DataTable();
                if (item.ToString() != "false")
                {
                    object checkpack = null;
                  
                    cmd = new SqlCommand("select PackUnitID from ProductsTable where PackUnitID = '"+cboUnit.SelectedValue.ToString()+"' ", MainClass.con);
                    checkpack = cmd.ExecuteScalar();
                    if (checkpack == null)
                    {
                        cmd = new SqlCommand("select CostPrice,SalePrice from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "' and UnitID =  '" + cboUnit.SelectedValue.ToString() + "' ", MainClass.con);
                        dr = cmd.ExecuteReader();
                    }
                    else
                    {
                        cmd = new SqlCommand("select PackCostPrice,PackSalePrice from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "' and PackUnitID = '" + cboUnit.SelectedValue.ToString() + "' ", MainClass.con);
                        dr = cmd.ExecuteReader();
                    }
                }
                else
                {
                    cmd = new SqlCommand("select PackCostPrice,PackSalePrice from ProductsTable where ProductID = '" + cboProducts.SelectedValue.ToString() + "' and PackUnitID = '" + cboUnit.SelectedValue.ToString() + "'", MainClass.con);
                    dr = cmd.ExecuteReader();
                }
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductsData[0] = dr[0].ToString();
                        ProductsData[1] = dr[1].ToString();
                        txtCostPrice.Text = ProductsData[0].ToString();
                        txtSalePrice.Text = ProductsData[1].ToString();
                    }
                }
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducts.SelectedIndex != 0)
            {
                GetPrice();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "" && txtQuantity.Text != "0")
            {
                float rate = float.Parse(txtCostPrice.Text);
                float qty = float.Parse(txtQuantity.Text);
                float ptot = rate * qty;
                txtProductTotal.Text = ptot.ToString();
            }
            else
            {
                txtProductTotal.Text = "0";
            }
        }

        private void GBClear()
        {
            txtProductTotal.Text = "";
            txtQuantity.Text = "";
            txtSalePrice.Text = "";
            txtQuantity.Text = "";
            txtDiscount.Text = "";
            cboUnit.Text = "";
            cboProducts.SelectedIndex = 0;
            cboProducts.Focus();
        }

        private void FullClear()
        {
            GBClear();
            txtGrossTotal.Text = "";
            txtPaymentTotal.Text = "";
            txtBalance.Text = "";
            cboSupplier.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            dtInvoiceDate.Value = DateTime.Now;
            cboType.Focus();
            DGVPurchaseCart.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool productalready = false;
            if(txtProductTotal.Text == "" || txtProductTotal.Text == "0")
            {
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity", "Input Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtCostPrice.Text == "")
                {
                    MessageBox.Show("Please Get Rate", "Input Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                float discount;
                float qty = float.Parse(txtQuantity.Text);
                float costrate = float.Parse(txtCostPrice.Text);
                float salerate = float.Parse(txtSalePrice.Text);
                float producttotal = float.Parse(txtProductTotal.Text);
                if (txtDiscount.Text != "")
                {
                     discount = float.Parse(txtDiscount.Text);
                }
                else
                {
                    txtDiscount.Text = "0";

                }

                if (DGVPurchaseCart.Rows.Count == 0)
                {
                    DataGridViewRow createrow = new DataGridViewRow();
                    createrow.CreateCells(DGVPurchaseCart);
                    createrow.Cells[0].Value = cboProducts.SelectedValue.ToString();
                    createrow.Cells[1].Value = cboProducts.Text.ToString();
                    createrow.Cells[2].Value = cboUnit.Text.ToString();
                    createrow.Cells[3].Value = txtCostPrice.Text.ToString();
                    createrow.Cells[4].Value = txtSalePrice.Text.ToString();
                    createrow.Cells[5].Value = txtQuantity.Text.ToString();
                    createrow.Cells[6].Value = txtDiscount.Text.ToString();
                    createrow.Cells[7].Value = txtProductTotal.Text.ToString();
                    DGVPurchaseCart.Rows.Add(createrow);
                    GBClear();
                }
                else
                {
                    foreach (DataGridViewRow check in DGVPurchaseCart.Rows)
                    {
                        if (Convert.ToString(check.Cells[0].Value) == Convert.ToString(cboProducts.SelectedValue) &&
                            Convert.ToString(check.Cells[2].Value) == Convert.ToString(cboUnit.Text))
                        {
                            productalready = true;
                            break;
                        }
                        else
                        {
                            productalready = false;
                        }

                    }
                    if (productalready == true)
                    {
                        foreach (DataGridViewRow row in DGVPurchaseCart.Rows)
                        {
                            if (Convert.ToString(row.Cells[0].Value) == Convert.ToString(cboProducts.SelectedValue))
                            {
                                row.Cells[5].Value = float.Parse(row.Cells[5].Value.ToString()) + qty;
                                row.Cells[7].Value = float.Parse(row.Cells[5].Value.ToString()) * float.Parse(row.Cells[3].Value.ToString());
                                GBClear();
                            }
                        }
                    }

                    else
                    {
                        if (productalready == false)
                        {
                            DataGridViewRow createrow = new DataGridViewRow();
                            createrow.CreateCells(DGVPurchaseCart);
                            createrow.Cells[0].Value = cboProducts.SelectedValue.ToString();
                            createrow.Cells[1].Value = cboProducts.Text.ToString();
                            createrow.Cells[2].Value = cboUnit.Text.ToString();
                            createrow.Cells[3].Value = txtCostPrice.Text.ToString();
                            createrow.Cells[4].Value = txtSalePrice.Text.ToString();
                            createrow.Cells[5].Value = txtQuantity.Text.ToString();
                            createrow.Cells[6].Value = txtDiscount.Text.ToString();
                            createrow.Cells[7].Value = txtProductTotal.Text.ToString();
                            DGVPurchaseCart.Rows.Add(createrow);
                            GBClear();
                        }
                    }
                }
            }
            CalculateTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "" || txtCostPrice.Text == "" || txtQuantity.Text == "")
            {
                txtDiscount.Text = "0";
            }
            else
            {
                if (txtDiscount.Text != "")
                {
                    float qty = float.Parse(txtQuantity.Text);
                    float rate = float.Parse(txtCostPrice.Text);
                    float dis = float.Parse(txtDiscount.Text);
                    txtProductTotal.Text = Convert.ToString((qty * rate) - dis);
                }
                else
                {
                    float rate = float.Parse(txtCostPrice.Text);
                    float qty;
                    float.TryParse(txtQuantity.Text.Trim(), out qty);
                    txtProductTotal.Text = Convert.ToString(qty * rate);
                }
            }
        }

      
        private void DGVPurchaseCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 8)
                {
                    DGVPurchaseCart.Rows.RemoveAt(DGVPurchaseCart.CurrentRow.Index);
                }
            }
            CalculateTotal();

            if(DGVPurchaseCart.Rows.Count == 0)
            {
                FullClear();
            }
        }

        private void CalculateTotal()
        {
            float gross = 0;
            if (DGVPurchaseCart.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVPurchaseCart.Rows)
                {
                    gross += float.Parse(row.Cells[7].Value.ToString());
                }
                txtGrossTotal.Text = Convert.ToString(gross);
            }
           
            txtPaymentTotal.Text = txtGrossTotal.Text;
            if (txtPaying.Text == "0" || txtPaying.Text == "")
            {
                txtBalance.Text = gross.ToString();
            }

            if(cboType.Text == "Cash")
            {
                txtPaying.Text = gross.ToString();
                txtBalance.Text = "0";
            }
        }
        private void DGVPurchaseCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotal();
        }

        private void txtPaying_TextChanged(object sender, EventArgs e)
        {

            if (txtPaying.Text != "" || txtPaying.Text == "0")
            {
                float tot = Convert.ToInt32(txtPaymentTotal.Text);
                float paying = Convert.ToInt32(txtPaying.Text);
                txtBalance.Text = Convert.ToString(tot - paying);
            }
            else
            {
                txtBalance.Text = txtPaymentTotal.Text;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboType.Text == "Credit")
            {
                GBPayments.Visible = true;
            }
            else
            {
                GBPayments.Visible = false;
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FullClear();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "" || cboSupplier.SelectedIndex == 0 || DGVPurchaseCart.Rows.Count == 0)
            {
                MessageBox.Show("Please Check Info");
                return;
            }
            else
            {
                SqlCommand cmd = null;
                string invoiceno = "PUR" + txtInvoiceNo.Text.ToString();
                float grantotal = float.Parse(txtGrossTotal.Text.ToString());
                string SupplierInvoiceID = "";
                string PurchaseID = "";
                string SupplierID = cboSupplier.SelectedValue.ToString();
                
                try
                {
                    MainClass.con.Open();
                    cmd = new SqlCommand("insert into SupplierInvoicesTable (SupplierID,PaymentType,InvoiceDate,InvoiceNo,TotalAmount,RemainingBalance) values (" +
                        "@SupplierID,@PaymentType,@InvoiceDate,@InvoiceNo,@TotalAmount,@RemainingBalance)", MainClass.con);

                    cmd.Parameters.AddWithValue("@SupplierID", cboSupplier.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PaymentType", cboType.Text);
                    cmd.Parameters.AddWithValue("@InvoiceDate", dtInvoiceDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceno);
                    cmd.Parameters.AddWithValue("@TotalAmount", grantotal);
                    cmd.Parameters.AddWithValue("@RemainingBalance", txtBalance.Text);
                    cmd.ExecuteNonQuery();
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } // Inserting Supplier Invoices
                try
                {
                    MainClass.con.Open();
                    SupplierInvoiceID = Convert.ToString(MainClass.Retrieve("select MAX(SupplierInvoiceID) from SupplierInvoicesTable").Rows[0][0]);
                    if (string.IsNullOrEmpty(SupplierInvoiceID))
                    {
                        MessageBox.Show("Please Check The Error or Try Again");
                        return;
                    }
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } // Get Supplier InvoiceID
                try
                {
                    MainClass.con.Open();
                    cmd = new SqlCommand("insert into PurchasesTable (InvoiceNo,SupplierInvoice_ID,Supplier_ID,GrandTotal) values (" +
                        "@InvoiceNo,@SupplierInvoice_ID,@Supplier_ID,@GrandTotal)", MainClass.con);
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceno);
                    cmd.Parameters.AddWithValue("@SupplierInvoice_ID", SupplierInvoiceID);
                    cmd.Parameters.AddWithValue("@Supplier_ID", SupplierID);
                    cmd.Parameters.AddWithValue("@GrandTotal", grantotal);
                    cmd.ExecuteNonQuery();
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } // Inserting into Purchases
                try
                {
                    MainClass.con.Open();
                    PurchaseID = Convert.ToString(MainClass.Retrieve("select MAX(PurchaseID) from PurchasesTable").Rows[0][0]);
                    if (string.IsNullOrEmpty(PurchaseID))
                    {
                        MessageBox.Show("Please Check The Error or Try Again");
                        return;
                    }
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } // Get Purchase ID
                try
                {
                    MainClass.con.Open();
                    foreach (DataGridViewRow item in DGVPurchaseCart.Rows)
                    {
                        int ProductID = 0;
                        int UnitID = 0;
                        try
                        {
                            cmd = new SqlCommand("select ProductID from ProductsTable where ProductName = '" + item.Cells[1].Value.ToString() + "'", MainClass.con);
                            ProductID = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        } // ProductID
                        try
                        {
                            cmd = new SqlCommand("select UnitID from UnitsTable where Unit = '" + item.Cells[2].Value.ToString() + "'", MainClass.con);
                            UnitID = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        } // UnitID

                        float qty = float.Parse(item.Cells[5].Value.ToString());
                        float cost = float.Parse(item.Cells[3].Value.ToString());
                        float sale = float.Parse(item.Cells[4].Value.ToString());
                        float discount = float.Parse(item.Cells[6].Value.ToString());
                        float totofprodcut = float.Parse(item.Cells[7].Value.ToString());


                        string insertPurchaseInfo = "insert into PurchasesInfo (Purchase_ID,Supplier_InvoiceID,Product_ID,Quantity,Unit,CostPrice,SalePrice,Discount,TotalOfProduct) values (@Purchase_ID,@Supplier_InvoiceID,@Product_ID,@Quantity,@Unit,@CostPrice,@SalePrice,@Discount,@TotalOfProduct)";
                        cmd = new SqlCommand(insertPurchaseInfo, MainClass.con);
                        cmd.Parameters.AddWithValue("@Purchase_ID", PurchaseID);
                        cmd.Parameters.AddWithValue("@Supplier_InvoiceID", SupplierInvoiceID);
                        cmd.Parameters.AddWithValue("@Product_ID", ProductID);
                        cmd.Parameters.AddWithValue("@Quantity", qty);
                        cmd.Parameters.AddWithValue("@Unit", UnitID);
                        cmd.Parameters.AddWithValue("@CostPrice", cost);
                        cmd.Parameters.AddWithValue("@SalePrice", sale);
                        cmd.Parameters.AddWithValue("@Discount", discount);
                        cmd.Parameters.AddWithValue("@TotalOfProduct", totofprodcut);
                        cmd.ExecuteNonQuery();
                    }
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } // Inserting Purchase Info
                try
                {
                    bool checkpackage = false;
                    bool pack = false;
                    int productId = 0;
                    string barcode = "";
                    int unitId = 0;
                    object stockqty = null;
                    
                    MainClass.con.Open();
                    foreach (DataGridViewRow item in DGVPurchaseCart.Rows)
                    {
                        try
                        {
                            cmd = new SqlCommand("select Qty from Inventory where ProductID = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                            stockqty = cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        }

                        cmd = new SqlCommand("select IsPackage from ProductsTable where ProductID = '" + item.Cells[0].Value.ToString() + "'", MainClass.con);
                        checkpackage = bool.Parse(cmd.ExecuteScalar().ToString());

                        if (checkpackage != false)
                        {
                            pack = true;
                        }
                        else
                        {
                            pack = false;
                        }

                        try
                        {
                            cmd = new SqlCommand("select ProductID from ProductsTable where ProductName = '" + item.Cells[1].Value.ToString() + "' ", MainClass.con);
                            productId = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        } // Product ID

                        try
                        {
                            cmd = new SqlCommand("select Barcode from ProductsTable where ProductName = '" + item.Cells[1].Value.ToString() + "' ", MainClass.con);
                            barcode = cmd.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        } // Barcode

                        try
                        {
                            cmd = new SqlCommand("select UnitID from ProductsTable where ProductID = '" + item.Cells[0].Value.ToString() + "' ", MainClass.con);
                            unitId = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MainClass.con.Close();
                        } // Unit ID
                        float packqty = 0;
                        float costprice = 0;
                        float finalqty = 0;
                        if (stockqty == null)
                        {
                            cmd = new SqlCommand("select PackQty from ProductsTable where ProductID = '" + productId + "'", MainClass.con);
                            packqty = float.Parse(cmd.ExecuteScalar().ToString());

                            cmd = new SqlCommand("select CostPrice from ProductsTable where ProductID = '" + productId + "'", MainClass.con);
                            costprice = float.Parse(cmd.ExecuteScalar().ToString());

                            cmd = new SqlCommand("insert into Inventory (ProductID,Unit,Qty,Rate,Barcode) values (@ProductID,@Unit,@Qty,@Rate,@Barcode)", MainClass.con);
                            if (pack == true)
                            {
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@Unit", unitId);

                                finalqty = float.Parse(item.Cells[5].Value.ToString()) * float.Parse(packqty.ToString());
                                cmd.Parameters.AddWithValue("@Qty", finalqty);
                                cmd.Parameters.AddWithValue("@Rate", costprice);
                                cmd.Parameters.AddWithValue("@Barcode", barcode);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@ProductID", productId);
                                cmd.Parameters.AddWithValue("@Unit", unitId);
                                cmd.Parameters.AddWithValue("@Qty", item.Cells[5].Value.ToString());
                                cmd.Parameters.AddWithValue("@Rate", costprice);
                                cmd.Parameters.AddWithValue("@Barcode", barcode);
                                cmd.ExecuteNonQuery();
                            }
                        } // Inserting 
                        else
                        {
                            cmd = new SqlCommand("select PackQty from ProductsTable where ProductID = '" + productId + "'", MainClass.con);
                            packqty = float.Parse(cmd.ExecuteScalar().ToString());

                            if (pack == true)
                            {
                                finalqty = float.Parse(item.Cells[5].Value.ToString()) * float.Parse(packqty.ToString());
                                finalqty += float.Parse(stockqty.ToString());
                                MainClass.UpdateInventory(productId, finalqty);
                            }
                            else
                            {
                                float qty = 0;
                                float.TryParse(stockqty.ToString(), out qty);
                                qty += float.Parse(item.Cells[5].Value.ToString());
                                MainClass.UpdateInventory(productId, qty);
                            }
                        } //Updating
                    }
                    MainClass.con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MainClass.con.Close();
                } // Inserting and Updating Inventory
                try
                {
                    MainClass.con.Open();
                    string InsertPayment = "insert into SupplierLedgersTable (SupplierInvoice_ID,Supplier_ID,InvoiceType,InvoiceDate,InvoiceNo,TotalAmount,PaidAmount,Balance) values(@SupplierInvoice_ID,@Supplier_ID,@InvoiceType,@InvoiceDate,@InvoiceNo,@TotalAmount,@PaidAmount,@Balance)";
                    cmd = new SqlCommand(InsertPayment, MainClass.con);
                    cmd.Parameters.AddWithValue("@SupplierInvoice_ID", SupplierInvoiceID);
                    cmd.Parameters.AddWithValue("@Supplier_ID", cboSupplier.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@InvoiceType", cboType.Text);
                    cmd.Parameters.AddWithValue("@InvoiceNo", invoiceno);
                    cmd.Parameters.AddWithValue("@InvoiceDate", dtInvoiceDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@TotalAmount", txtPaymentTotal.Text);
                    cmd.Parameters.AddWithValue("@PaidAmount", txtPaying.Text);
                    cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
                    cmd.ExecuteNonQuery();
                    MainClass.con.Close();
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MessageBox.Show(ex.Message);
                } //Inserting Ledgers
            }
            btnGenerate.PerformClick();
            MessageBox.Show("Purchase Successfuly");
            FullClear();
        }
    }
}
