namespace WinUI
{
    partial class InvoiceDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDetalii = new System.Windows.Forms.DataGridView();
            this.InvoiceDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddFact = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbObservations = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQtty = new System.Windows.Forms.TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.tbDatFactura = new System.Windows.Forms.TextBox();
            this.tbNrFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalii)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetalii
            // 
            this.dataGridViewDetalii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceDetailId,
            this.InvoiceId,
            this.ItemId,
            this.ItemName,
            this.Qtty,
            this.Price,
            this.Amount,
            this.Observations});
            this.dataGridViewDetalii.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewDetalii.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetalii.Name = "dataGridViewDetalii";
            this.dataGridViewDetalii.Size = new System.Drawing.Size(663, 150);
            this.dataGridViewDetalii.TabIndex = 0;
            // 
            // InvoiceDetailId
            // 
            this.InvoiceDetailId.DataPropertyName = "InvoiceDetailId";
            this.InvoiceDetailId.HeaderText = "InvoiceDetailId";
            this.InvoiceDetailId.Name = "InvoiceDetailId";
            this.InvoiceDetailId.Visible = false;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Visible = false;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "NumeArticol";
            this.ItemName.Name = "ItemName";
            // 
            // Qtty
            // 
            this.Qtty.DataPropertyName = "Qtty";
            this.Qtty.HeaderText = "Cantitate";
            this.Qtty.Name = "Qtty";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Pret";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Valoare";
            this.Amount.Name = "Amount";
            // 
            // Observations
            // 
            this.Observations.DataPropertyName = "Observations";
            this.Observations.HeaderText = "Observatii";
            this.Observations.Name = "Observations";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Sterge Detaliu Factura";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(215, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(182, 23);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Modifica Detaliu Factura";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAddFact
            // 
            this.btnAddFact.Location = new System.Drawing.Point(43, 156);
            this.btnAddFact.Name = "btnAddFact";
            this.btnAddFact.Size = new System.Drawing.Size(166, 23);
            this.btnAddFact.TabIndex = 30;
            this.btnAddFact.Text = "Adauga Detaliu Factura";
            this.btnAddFact.UseVisualStyleBackColor = true;
            this.btnAddFact.Click += new System.EventHandler(this.BtnAddFact_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.tbObservations);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbQtty);
            this.panel1.Controls.Add(this.cbItems);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditDetail);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 177);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valoare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Observatii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantitate";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(265, 34);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(100, 21);
            this.tbAmount.TabIndex = 9;
            // 
            // tbObservations
            // 
            this.tbObservations.Location = new System.Drawing.Point(265, 60);
            this.tbObservations.Multiline = true;
            this.tbObservations.Name = "tbObservations";
            this.tbObservations.Size = new System.Drawing.Size(180, 46);
            this.tbObservations.TabIndex = 8;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(77, 86);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(60, 21);
            this.tbPrice.TabIndex = 7;
            this.tbPrice.TextChanged += new System.EventHandler(this.TbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrice_KeyPress);
            // 
            // tbQtty
            // 
            this.tbQtty.Location = new System.Drawing.Point(77, 60);
            this.tbQtty.Name = "tbQtty";
            this.tbQtty.Size = new System.Drawing.Size(60, 21);
            this.tbQtty.TabIndex = 6;
            this.tbQtty.TextChanged += new System.EventHandler(this.TbQtty_TextChanged);
            this.tbQtty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbQtty_KeyPress);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(77, 33);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Articol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modificare Detaliu";
            this.label2.Visible = false;
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Location = new System.Drawing.Point(185, 137);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 2;
            this.btnEditDetail.Text = "Modifica";
            this.btnEditDetail.UseVisualStyleBackColor = true;
            this.btnEditDetail.Visible = false;
            this.btnEditDetail.Click += new System.EventHandler(this.BtnEditDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Detaliu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(397, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "NumeClient";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(271, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "DataFactura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "NrFactura";
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(392, 202);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.ReadOnly = true;
            this.tbNumeClient.Size = new System.Drawing.Size(100, 21);
            this.tbNumeClient.TabIndex = 45;
            this.tbNumeClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDatFactura
            // 
            this.tbDatFactura.Location = new System.Drawing.Point(240, 202);
            this.tbDatFactura.Name = "tbDatFactura";
            this.tbDatFactura.ReadOnly = true;
            this.tbDatFactura.Size = new System.Drawing.Size(146, 21);
            this.tbDatFactura.TabIndex = 44;
            this.tbDatFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNrFactura
            // 
            this.tbNrFactura.Location = new System.Drawing.Point(134, 202);
            this.tbNrFactura.Name = "tbNrFactura";
            this.tbNrFactura.ReadOnly = true;
            this.tbNrFactura.Size = new System.Drawing.Size(100, 21);
            this.tbNrFactura.TabIndex = 43;
            this.tbNrFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InvoiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.tbDatFactura);
            this.Controls.Add(this.tbNrFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddFact);
            this.Controls.Add(this.dataGridViewDetalii);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceDetailsForm";
            this.Text = "DETALII FACTURA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalii)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetalii;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbObservations;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQtty;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.TextBox tbDatFactura;
        private System.Windows.Forms.TextBox tbNrFactura;
    }
}