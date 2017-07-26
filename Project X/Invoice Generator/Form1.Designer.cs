namespace Invoice_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbillno = new System.Windows.Forms.Label();
            this.txtbillno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblproductname = new System.Windows.Forms.Label();
            this.cmbproductname = new System.Windows.Forms.ComboBox();
            this.lblqnty = new System.Windows.Forms.Label();
            this.txtqnty = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.lblfinaltotal = new System.Windows.Forms.Label();
            this.txtfinaltotal = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbillno
            // 
            this.lblbillno.AutoSize = true;
            this.lblbillno.Location = new System.Drawing.Point(12, 31);
            this.lblbillno.Name = "lblbillno";
            this.lblbillno.Size = new System.Drawing.Size(90, 19);
            this.lblbillno.TabIndex = 0;
            this.lblbillno.Text = "Bill Number";
            // 
            // txtbillno
            // 
            this.txtbillno.Location = new System.Drawing.Point(130, 28);
            this.txtbillno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.ReadOnly = true;
            this.txtbillno.Size = new System.Drawing.Size(132, 27);
            this.txtbillno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2017, 2, 28, 3, 21, 46, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(12, 102);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(108, 19);
            this.lblproductname.TabIndex = 4;
            this.lblproductname.Text = "Product Name";
            // 
            // cmbproductname
            // 
            this.cmbproductname.FormattingEnabled = true;
            this.cmbproductname.Items.AddRange(new object[] {
            "Jeans",
            "T-shirt",
            "Cotton Trouser",
            "Cotton Shirt",
            "Cotton Shirt Piece",
            "Cotton Trouser Piece",
            "Lenen Shirt Piece",
            "Lenen Trouse Piece"});
            this.cmbproductname.Location = new System.Drawing.Point(130, 99);
            this.cmbproductname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbproductname.Name = "cmbproductname";
            this.cmbproductname.Size = new System.Drawing.Size(159, 27);
            this.cmbproductname.TabIndex = 5;
            this.cmbproductname.SelectedIndexChanged += new System.EventHandler(this.cmbproductname_SelectedIndexChanged);
            // 
            // lblqnty
            // 
            this.lblqnty.AutoSize = true;
            this.lblqnty.Location = new System.Drawing.Point(320, 102);
            this.lblqnty.Name = "lblqnty";
            this.lblqnty.Size = new System.Drawing.Size(69, 19);
            this.lblqnty.TabIndex = 6;
            this.lblqnty.Text = "Quantity";
            // 
            // txtqnty
            // 
            this.txtqnty.Location = new System.Drawing.Point(395, 99);
            this.txtqnty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtqnty.Name = "txtqnty";
            this.txtqnty.Size = new System.Drawing.Size(132, 27);
            this.txtqnty.TabIndex = 7;
            this.txtqnty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqnty_KeyPress);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(547, 102);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(43, 19);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(596, 99);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(132, 27);
            this.txtprice.TabIndex = 9;
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(766, 94);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 34);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.productname,
            this.qnty,
            this.price,
            this.amount,
            this.billno});
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 395);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 66;
            // 
            // productname
            // 
            this.productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            // 
            // qnty
            // 
            this.qnty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qnty.HeaderText = "Quantity";
            this.qnty.Name = "qnty";
            this.qnty.Width = 94;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // billno
            // 
            this.billno.HeaderText = "Bill Number";
            this.billno.Name = "billno";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(547, 540);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(43, 19);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "Total";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(596, 537);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(132, 27);
            this.txttotal.TabIndex = 13;
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.Location = new System.Drawing.Point(521, 580);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(69, 19);
            this.lbldiscount.TabIndex = 14;
            this.lbldiscount.Text = "Discount";
            // 
            // txtdisc
            // 
            this.txtdisc.Location = new System.Drawing.Point(596, 572);
            this.txtdisc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(132, 27);
            this.txtdisc.TabIndex = 15;
            this.txtdisc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdisc_KeyPress);
            // 
            // lblfinaltotal
            // 
            this.lblfinaltotal.AutoSize = true;
            this.lblfinaltotal.Location = new System.Drawing.Point(511, 615);
            this.lblfinaltotal.Name = "lblfinaltotal";
            this.lblfinaltotal.Size = new System.Drawing.Size(79, 19);
            this.lblfinaltotal.TabIndex = 16;
            this.lblfinaltotal.Text = "Final Total";
            // 
            // txtfinaltotal
            // 
            this.txtfinaltotal.Location = new System.Drawing.Point(596, 607);
            this.txtfinaltotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfinaltotal.Name = "txtfinaltotal";
            this.txtfinaltotal.ReadOnly = true;
            this.txtfinaltotal.Size = new System.Drawing.Size(132, 27);
            this.txtfinaltotal.TabIndex = 17;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(734, 567);
            this.btncalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(99, 34);
            this.btncalc.TabIndex = 19;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(596, 642);
            this.btnprint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(99, 34);
            this.btnprint.TabIndex = 20;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.barcodeScannerToolStripMenuItem,
            this.addInventoryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellRecordToolStripMenuItem,
            this.purchaseRecordToolStripMenuItem,
            this.compareRecordToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sellRecordToolStripMenuItem
            // 
            this.sellRecordToolStripMenuItem.Name = "sellRecordToolStripMenuItem";
            this.sellRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sellRecordToolStripMenuItem.Text = "Sell Record";
            this.sellRecordToolStripMenuItem.Click += new System.EventHandler(this.sellRecordToolStripMenuItem_Click);
            // 
            // purchaseRecordToolStripMenuItem
            // 
            this.purchaseRecordToolStripMenuItem.Name = "purchaseRecordToolStripMenuItem";
            this.purchaseRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseRecordToolStripMenuItem.Text = "Purchase Record";
            // 
            // compareRecordToolStripMenuItem
            // 
            this.compareRecordToolStripMenuItem.Name = "compareRecordToolStripMenuItem";
            this.compareRecordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.compareRecordToolStripMenuItem.Text = "Compare Record";
            // 
            // barcodeScannerToolStripMenuItem
            // 
            this.barcodeScannerToolStripMenuItem.Name = "barcodeScannerToolStripMenuItem";
            this.barcodeScannerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.barcodeScannerToolStripMenuItem.Text = "Scanner";
            // 
            // addInventoryToolStripMenuItem
            // 
            this.addInventoryToolStripMenuItem.Name = "addInventoryToolStripMenuItem";
            this.addInventoryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addInventoryToolStripMenuItem.Text = "Add inventory";
            this.addInventoryToolStripMenuItem.Click += new System.EventHandler(this.addInventoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 680);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtfinaltotal);
            this.Controls.Add(this.lblfinaltotal);
            this.Controls.Add(this.txtdisc);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtqnty);
            this.Controls.Add(this.lblqnty);
            this.Controls.Add(this.cmbproductname);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillno);
            this.Controls.Add(this.lblbillno);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbillno;
        private System.Windows.Forms.TextBox txtbillno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.ComboBox cmbproductname;
        private System.Windows.Forms.Label lblqnty;
        private System.Windows.Forms.TextBox txtqnty;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn billno;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.Label lblfinaltotal;
        private System.Windows.Forms.TextBox txtfinaltotal;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem addInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareRecordToolStripMenuItem;
    }
}

