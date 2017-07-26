namespace Invoice_Generator
{
    partial class sell_form
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
            this.lbldatefrom = new System.Windows.Forms.Label();
            this.lbldateto = new System.Windows.Forms.Label();
            this.dtpdatefrom = new System.Windows.Forms.DateTimePicker();
            this.dtpdateto = new System.Windows.Forms.DateTimePicker();
            this.lblproductname = new System.Windows.Forms.Label();
            this.txtsearchsellproductname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearchsell = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldatefrom
            // 
            this.lbldatefrom.AutoSize = true;
            this.lbldatefrom.Location = new System.Drawing.Point(37, 32);
            this.lbldatefrom.Name = "lbldatefrom";
            this.lbldatefrom.Size = new System.Drawing.Size(80, 19);
            this.lbldatefrom.TabIndex = 0;
            this.lbldatefrom.Text = "Date From";
            // 
            // lbldateto
            // 
            this.lbldateto.AutoSize = true;
            this.lbldateto.Location = new System.Drawing.Point(307, 32);
            this.lbldateto.Name = "lbldateto";
            this.lbldateto.Size = new System.Drawing.Size(60, 19);
            this.lbldateto.TabIndex = 1;
            this.lbldateto.Text = "Date to";
            // 
            // dtpdatefrom
            // 
            this.dtpdatefrom.CustomFormat = "dd/MM/yyyy";
            this.dtpdatefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdatefrom.Location = new System.Drawing.Point(151, 26);
            this.dtpdatefrom.Name = "dtpdatefrom";
            this.dtpdatefrom.Size = new System.Drawing.Size(120, 27);
            this.dtpdatefrom.TabIndex = 2;
            this.dtpdatefrom.Value = new System.DateTime(2017, 3, 2, 16, 41, 55, 0);
            // 
            // dtpdateto
            // 
            this.dtpdateto.CustomFormat = "dd/MM/yyyy";
            this.dtpdateto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdateto.Location = new System.Drawing.Point(390, 26);
            this.dtpdateto.Name = "dtpdateto";
            this.dtpdateto.Size = new System.Drawing.Size(115, 27);
            this.dtpdateto.TabIndex = 3;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Location = new System.Drawing.Point(37, 75);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(108, 19);
            this.lblproductname.TabIndex = 4;
            this.lblproductname.Text = "Product Name";
            // 
            // txtsearchsellproductname
            // 
            this.txtsearchsellproductname.Location = new System.Drawing.Point(151, 72);
            this.txtsearchsellproductname.Name = "txtsearchsellproductname";
            this.txtsearchsellproductname.Size = new System.Drawing.Size(132, 27);
            this.txtsearchsellproductname.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 325);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnsearchsell
            // 
            this.btnsearchsell.Location = new System.Drawing.Point(311, 72);
            this.btnsearchsell.Name = "btnsearchsell";
            this.btnsearchsell.Size = new System.Drawing.Size(75, 27);
            this.btnsearchsell.TabIndex = 7;
            this.btnsearchsell.Text = "Search";
            this.btnsearchsell.UseVisualStyleBackColor = true;
            this.btnsearchsell.Click += new System.EventHandler(this.btnsearchsell_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(151, 436);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 27);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // sell_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearchsell);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearchsellproductname);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.dtpdateto);
            this.Controls.Add(this.dtpdatefrom);
            this.Controls.Add(this.lbldateto);
            this.Controls.Add(this.lbldatefrom);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sell_form";
            this.Text = "Sell Record Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatefrom;
        private System.Windows.Forms.Label lbldateto;
        private System.Windows.Forms.DateTimePicker dtpdatefrom;
        private System.Windows.Forms.DateTimePicker dtpdateto;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.TextBox txtsearchsellproductname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearchsell;
        private System.Windows.Forms.Button btnclear;
    }
}