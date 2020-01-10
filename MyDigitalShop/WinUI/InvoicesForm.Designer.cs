namespace WinUI
{
    partial class InvoicesForm
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
            this.dataGridViewFacturi = new System.Windows.Forms.DataGridView();
            this.btnCautaFacturi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddFact = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFacturi
            // 
            this.dataGridViewFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.Adresa,
            this.PartnerName,
            this.InvoiceId,
            this.PartnerId,
            this.PartnerAddressId,
            this.InvoiceDate,
            this.UserId,
            this.Observations});
            this.dataGridViewFacturi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFacturi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFacturi.Name = "dataGridViewFacturi";
            this.dataGridViewFacturi.Size = new System.Drawing.Size(624, 188);
            this.dataGridViewFacturi.TabIndex = 0;
            // 
            // btnCautaFacturi
            // 
            this.btnCautaFacturi.Location = new System.Drawing.Point(106, 211);
            this.btnCautaFacturi.Name = "btnCautaFacturi";
            this.btnCautaFacturi.Size = new System.Drawing.Size(103, 23);
            this.btnCautaFacturi.TabIndex = 1;
            this.btnCautaFacturi.Text = "Cauta Facturi";
            this.btnCautaFacturi.UseVisualStyleBackColor = true;
            this.btnCautaFacturi.Click += new System.EventHandler(this.BtnCautaFacturi_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Meniu Principal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(427, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Sterge Factura";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(321, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 23);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Modifica Factura";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAddFact
            // 
            this.btnAddFact.Location = new System.Drawing.Point(215, 211);
            this.btnAddFact.Name = "btnAddFact";
            this.btnAddFact.Size = new System.Drawing.Size(100, 23);
            this.btnAddFact.TabIndex = 27;
            this.btnAddFact.Text = "Adauga Factura";
            this.btnAddFact.UseVisualStyleBackColor = true;
            this.btnAddFact.Click += new System.EventHandler(this.BtnAddFact_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(534, 211);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 31;
            this.btnDetails.Text = "Detalii";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNumber";
            this.InvoiceNo.HeaderText = "NumarFactura";
            this.InvoiceNo.Name = "InvoiceNo";
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "AdresaClient";
            this.Adresa.HeaderText = "Adresa Client";
            this.Adresa.Name = "Adresa";
            // 
            // PartnerName
            // 
            this.PartnerName.DataPropertyName = "NumePartener";
            this.PartnerName.HeaderText = "Nume Client";
            this.PartnerName.Name = "PartnerName";
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Visible = false;
            // 
            // PartnerId
            // 
            this.PartnerId.DataPropertyName = "PartnerId";
            this.PartnerId.HeaderText = "PartnerId";
            this.PartnerId.Name = "PartnerId";
            this.PartnerId.Visible = false;
            // 
            // PartnerAddressId
            // 
            this.PartnerAddressId.DataPropertyName = "PartnerAddressId";
            this.PartnerAddressId.HeaderText = "PartnerAddressId";
            this.PartnerAddressId.Name = "PartnerAddressId";
            this.PartnerAddressId.Visible = false;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Data Factura";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            // 
            // Observations
            // 
            this.Observations.DataPropertyName = "Observations";
            this.Observations.HeaderText = "Observatii";
            this.Observations.Name = "Observations";
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 252);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dataGridViewFacturi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddFact);
            this.Controls.Add(this.btnCautaFacturi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoicesForm";
            this.Text = "FACTURI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFacturi;
        private System.Windows.Forms.Button btnCautaFacturi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddFact;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observations;
    }
}