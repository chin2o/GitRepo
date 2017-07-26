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
    public partial class sell_form : Form
    {
        public sell_form()
        {
            InitializeComponent();
        }

        private void btnsearchsell_Click(object sender, EventArgs e)
        {


             string constring = @"Data Source=Product_detail.db";
            using (SQLiteConnection con = new SQLiteConnection(constring))
          //  {
           //   using (SQLiteCommand cmd = new SQLiteCommand("SELECT BillNo, SellDate, ProductName, Quantity FROM product_table WHERE SellDate BETWEEN "+dtpdatefrom+" and "+dtpdateto+", AND ProductName = '"+txtsearchsellproductname.Text.ToString()+"'", con))
            // {
            //cmd.CommandType = CommandType.Text;
            //using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
            //{
             // using (DataTable dt = new DataTable())
            //{
             // sda.Fill(dt);
              //dataGridView1.DataSource = dt;
            //}
            // }
             //}
            if (String.IsNullOrEmpty(txtsearchsellproductname.Text))
            {
               // string constring = @"Data Source=Product_detail.db";
               // using (SQLiteConnection con = new SQLiteConnection(constring))
               // {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT BillNo, SellDate, ProductName, Quantity FROM Product_table WHERE Selldate BETWEEN '" + dtpdatefrom.Value.ToString() + "' and '" + dtpdateto.Value.ToString() + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }
            //}
            else
            {
              //  string constring = @"Data Source=Product_detail.db";
              //  using (SQLiteConnection con = new SQLiteConnection(constring))
               // {
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT BillNo, SellDate, ProductName, Quantity FROM Product_table WHERE ProductName LIKE '%" + txtsearchsellproductname.Text.ToString() + "%' AND SellDate BETWEEN '" + dtpdatefrom.Value.ToString() + "' and '" + dtpdateto.Value.ToString() + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                }
            }
        }
    //    private void btnclear_Click(object sender, EventArgs e)
      //  {
  //          dataGridView1.DataSource = null;
        }
   // }
//}

