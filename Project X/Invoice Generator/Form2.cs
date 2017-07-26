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
    public partial class purchase_form : Form
    {
        private static int rcptnum = 1;
        public purchase_form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtreceiptno.Text = rcptnum.ToString();
            // string td = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int r = 0;
            double varpquantity = Convert.ToDouble(txtpquantity.Text);
            double varpurchaseamt = Convert.ToDouble(txtpurchaseamt.Text);
            double varamount = varpquantity * varpurchaseamt;
            // double sum = 0;

            dataGridView1.Rows.Add();
            r = dataGridView1.Rows.Count - 2;
            dataGridView1["receiptnumber", r].Value = rcptnum;
            dataGridView1["dop", r].Value = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            dataGridView1["companyname", r].Value = txtcmpnyname.Text.ToString();
            dataGridView1["pid", r].Value = txtpurchasedetail.Text.ToString();
            dataGridView1["pqnty", r].Value = txtpquantity.Text.ToString();
            dataGridView1["pa", r].Value = varamount;


            //  for (int j = 0; j < dataGridView1.Rows.Count; j++)
            // {
            //   sum += Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value);
            //}
            //txttotal.Text = sum.ToString();
            //txtfinaltotal.Text = txttotal.Text;
            //txtqnty.Clear();
            //txtprice.Clear();
        }

        private void txtpurchaseamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            rcptnum++;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string constring = @"Data Source=Product_detail.db";
                using (SQLiteConnection con = new SQLiteConnection(constring))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Inventory_table VALUES(@ReceiptNo, @PurchaseDate, @CompanyName, @PurchaseItemDetail, @PurchaseQuantity, @PurchaseAmount)", con))
                    {

                        cmd.Parameters.AddWithValue("@ReceiptNo", Convert.ToInt16(row.Cells["receiptnumber"].Value));
                        cmd.Parameters.AddWithValue("@PurchaseDate", row.Cells["dop"].Value);
                        cmd.Parameters.AddWithValue("@CompanyName", row.Cells["companyname"].Value);
                        cmd.Parameters.AddWithValue("@PurchaseItemDetail", row.Cells["pid"].Value);
                        cmd.Parameters.AddWithValue("@Purchasequantity", Convert.ToDouble(row.Cells["pqnty"].Value));
                        cmd.Parameters.AddWithValue("@PurchaseAmount", Convert.ToDouble(row.Cells["pa"].Value));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            MessageBox.Show("Records inserted.");

            txtreceiptno.Text = rcptnum.ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            txtcmpnyname.Clear();
            txtpurchaseamt.Clear();
            txtpurchasedetail.Clear();
            txtpquantity.Clear();
            //txtdisc.Clear();

        }

        private void txtpquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // string td = dateTimePicker1.Value.ToShortDateString();


        }
    }
}
