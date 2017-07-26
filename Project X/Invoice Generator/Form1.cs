using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Invoice_Generator
{
    public partial class Form1 : Form
    {
        

        private static int billnum = 1;
        public Form1()
        {
            InitializeComponent();
        }
        //On form load the initial number of the bill.
        private void Form1_Load(object sender, EventArgs e)
        {


          
            txtbillno.Text = billnum.ToString();
           // myconn.Open();

        }

        // Events occured on add button click 
        //Adding data to datagridview
        //Calculate the amount for entered price and quantity.
        private void btnadd_Click(object sender, EventArgs e)
        {
            int r = 0;
            double varprice = Convert.ToDouble(txtprice.Text);
            double varquantity = Convert.ToDouble(txtqnty.Text);
            double varamount = varprice * varquantity ;
            double sum = 0;

            dataGridView1.Rows.Add();
            r = dataGridView1.Rows.Count - 2;
            dataGridView1["date", r].Value = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            dataGridView1["productname", r].Value = cmbproductname.SelectedItem.ToString();
            dataGridView1["qnty", r].Value = txtqnty.Text.ToString();
            dataGridView1["price", r].Value = txtprice.Text.ToString();
            dataGridView1["amount", r].Value = varamount;
            dataGridView1["billno", r].Value = billnum;

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value);
            }
            txttotal.Text = sum.ToString();
            txtfinaltotal.Text = txttotal.Text;
            txtqnty.Clear();
            txtprice.Clear();

        }
        //Price textbox keypress event to enter only numeric values
        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)||e.KeyChar=='.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //Quantity textbox keypress event to enter only numeric values
        private void txtqnty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //Discount textbox keypress event to enter only numeric values
        private void txtdisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        //Increment the bill number by 1.
        //Clear the datagridview
        //Clear quantity textbox
        //Clear price textbox.
        //Clear total textbox.
        //Clear final total textbox
        //Clear discount textbox.
        //Take out the printout of the generated bill.
        //Insert Data to Database
        private void btnprint_Click(object sender, EventArgs e)
        {
            billnum++;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string constring = @"Data Source=Product_detail.db";
                using (SQLiteConnection con = new SQLiteConnection(constring))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO product_table VALUES(@SellDate, @ProductName, @Quantity, @Price, @Amount, @BillNo)", con))
                    {
                        
                        cmd.Parameters.AddWithValue("@SellDate", row.Cells["date"].Value);
                        cmd.Parameters.AddWithValue("@ProductName", row.Cells["productname"].Value);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToDouble(row.Cells["qnty"].Value));
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(row.Cells["price"].Value));
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(row.Cells["amount"].Value));
                        cmd.Parameters.AddWithValue("@BillNo", Convert.ToInt16(row.Cells["billno"].Value));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            MessageBox.Show("Records inserted.");
        
        txtbillno.Text = billnum.ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtqnty.Clear();
            txtprice.Clear();
            txttotal.Clear();
            txtfinaltotal.Clear();
            txtdisc.Clear();
        }
        //Calculate the discount amount.
        //Change the final total when discount event occured.
        private void btncalc_Click(object sender, EventArgs e)
        {
            double k = 0;
            double l = 0;
            if(txtdisc.Text != null)
            {
                k = (Convert.ToDouble(txttotal.Text) * Convert.ToDouble(txtdisc.Text)) / 100;
                l = Convert.ToDouble(txttotal.Text) - k; 
                txtfinaltotal.Text = l.ToString();
            }

            if(txtdisc.Text == null)
            {
                txtfinaltotal.Text = txttotal.Text ; 
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            double sum = 0;
            if (e.KeyCode == Keys.Delete)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value);
                }
                txttotal.Text = sum.ToString();
                txtfinaltotal.Text = txttotal.Text;
            }


        }

        private void addInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            purchase_form Settingform = new purchase_form();
            Settingform.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sellRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell_form Settingform = new sell_form();
            Settingform.Show();
        }

        private void cmbproductname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
