namespace Invoice_Generator
{
    partial class purchase_form
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
            this.lblreceiptno = new System.Windows.Forms.Label();
            this.txtreceiptno = new System.Windows.Forms.TextBox();
            this.lbldateofpurchase = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.txtcmpnyname = new System.Windows.Forms.TextBox();
            this.lblpurchaseamt = new System.Windows.Forms.Label();
            this.txtpurchaseamt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receiptnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblpurchaseitemdetail = new System.Windows.Forms.Label();
            this.txtpurchasedetail = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtpquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblreceiptno
            // 
            this.lblreceiptno.AutoSize = true;
            this.lblreceiptno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceiptno.Location = new System.Drawing.Point(21, 29);
            this.lblreceiptno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreceiptno.Name = "lblreceiptno";
            this.lblreceiptno.Size = new System.Drawing.Size(120, 19);
            this.lblreceiptno.TabIndex = 0;
            this.lblreceiptno.Text = "Receipt Number";
            // 
            // txtreceiptno
            // 
            this.txtreceiptno.Location = new System.Drawing.Point(177, 26);
            this.txtreceiptno.Margin = new System.Windows.Forms.Padding(4);
            this.txtreceiptno.Name = "txtreceiptno";
            this.txtreceiptno.ReadOnly = true;
            this.txtreceiptno.Size = new System.Drawing.Size(132, 27);
            this.txtreceiptno.TabIndex = 1;
            // 
            // lbldateofpurchase
            // 
            this.lbldateofpurchase.AutoSize = true;
            this.lbldateofpurchase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofpurchase.Location = new System.Drawing.Point(21, 67);
            this.lbldateofpurchase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldateofpurchase.Name = "lbldateofpurchase";
            this.lbldateofpurchase.Size = new System.Drawing.Size(125, 19);
            this.lbldateofpurchase.TabIndex = 2;
            this.lbldateofpurchase.Text = "Date of Purchase";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Location = new System.Drawing.Point(21, 98);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(117, 19);
            this.lblcompanyname.TabIndex = 4;
            this.lblcompanyname.Text = "Company Name";
            // 
            // txtcmpnyname
            // 
            this.txtcmpnyname.Location = new System.Drawing.Point(177, 95);
            this.txtcmpnyname.Name = "txtcmpnyname";
            this.txtcmpnyname.Size = new System.Drawing.Size(293, 27);
            this.txtcmpnyname.TabIndex = 5;
            // 
            // lblpurchaseamt
            // 
            this.lblpurchaseamt.AutoSize = true;
            this.lblpurchaseamt.Location = new System.Drawing.Point(21, 197);
            this.lblpurchaseamt.Name = "lblpurchaseamt";
            this.lblpurchaseamt.Size = new System.Drawing.Size(131, 19);
            this.lblpurchaseamt.TabIndex = 6;
            this.lblpurchaseamt.Text = "Purchase Amount";
            // 
            // txtpurchaseamt
            // 
            this.txtpurchaseamt.Location = new System.Drawing.Point(177, 194);
            this.txtpurchaseamt.Name = "txtpurchaseamt";
            this.txtpurchaseamt.Size = new System.Drawing.Size(100, 27);
            this.txtpurchaseamt.TabIndex = 7;
            this.txtpurchaseamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpurchaseamt_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptnumber,
            this.dop,
            this.companyname,
            this.pid,
            this.pqnty,
            this.pa});
            this.dataGridView1.Location = new System.Drawing.Point(25, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 323);
            this.dataGridView1.TabIndex = 8;
            // 
            // receiptnumber
            // 
            this.receiptnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.receiptnumber.HeaderText = "Receipt Number";
            this.receiptnumber.Name = "receiptnumber";
            this.receiptnumber.Width = 132;
            // 
            // dop
            // 
            this.dop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dop.HeaderText = "Date Of Purchase";
            this.dop.Name = "dop";
            this.dop.Width = 139;
            // 
            // companyname
            // 
            this.companyname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyname.HeaderText = "Company Name";
            this.companyname.Name = "companyname";
            // 
            // pid
            // 
            this.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pid.HeaderText = "Purchase Item Detail";
            this.pid.Name = "pid";
            // 
            // pqnty
            // 
            this.pqnty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pqnty.HeaderText = "Purchase Quantity";
            this.pqnty.Name = "pqnty";
            this.pqnty.Width = 146;
            // 
            // pa
            // 
            this.pa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pa.HeaderText = "Purchase Amount";
            this.pa.Name = "pa";
            this.pa.Width = 142;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(283, 194);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 27);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(384, 556);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 29);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblpurchaseitemdetail
            // 
            this.lblpurchaseitemdetail.AutoSize = true;
            this.lblpurchaseitemdetail.Location = new System.Drawing.Point(21, 131);
            this.lblpurchaseitemdetail.Name = "lblpurchaseitemdetail";
            this.lblpurchaseitemdetail.Size = new System.Drawing.Size(150, 19);
            this.lblpurchaseitemdetail.TabIndex = 11;
            this.lblpurchaseitemdetail.Text = "Purchase Item Detail";
            // 
            // txtpurchasedetail
            // 
            this.txtpurchasedetail.Location = new System.Drawing.Point(177, 128);
            this.txtpurchasedetail.Name = "txtpurchasedetail";
            this.txtpurchasedetail.Size = new System.Drawing.Size(293, 27);
            this.txtpurchasedetail.TabIndex = 12;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(21, 164);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(69, 19);
            this.lblquantity.TabIndex = 13;
            this.lblquantity.Text = "Quantity";
            // 
            // txtpquantity
            // 
            this.txtpquantity.Location = new System.Drawing.Point(177, 161);
            this.txtpquantity.Name = "txtpquantity";
            this.txtpquantity.Size = new System.Drawing.Size(100, 27);
            this.txtpquantity.TabIndex = 14;
            this.txtpquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpquantity_KeyPress);
            // 
            // purchase_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 597);
            this.Controls.Add(this.txtpquantity);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.txtpurchasedetail);
            this.Controls.Add(this.lblpurchaseitemdetail);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpurchaseamt);
            this.Controls.Add(this.lblpurchaseamt);
            this.Controls.Add(this.txtcmpnyname);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbldateofpurchase);
            this.Controls.Add(this.txtreceiptno);
            this.Controls.Add(this.lblreceiptno);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "purchase_form";
            this.Text = "Purchased Inventory";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblreceiptno;
        private System.Windows.Forms.TextBox txtreceiptno;
        private System.Windows.Forms.Label lbldateofpurchase;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.TextBox txtcmpnyname;
        private System.Windows.Forms.Label lblpurchaseamt;
        private System.Windows.Forms.TextBox txtpurchaseamt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblpurchaseitemdetail;
        private System.Windows.Forms.TextBox txtpurchasedetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dop;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtpquantity;
    }
}