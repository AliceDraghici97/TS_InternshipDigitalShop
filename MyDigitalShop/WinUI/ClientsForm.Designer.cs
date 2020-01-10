namespace WinUI
{
    partial class ClientsForm
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
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.PartnerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartnerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartnerId,
            this.PartnerName,
            this.PartnerSurname,
            this.PartnerCode,
            this.PhoneNo,
            this.Email});
            this.dataGridViewClienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewClienti.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewClienti.Size = new System.Drawing.Size(542, 159);
            this.dataGridViewClienti.TabIndex = 0;
            // 
            // PartnerId
            // 
            this.PartnerId.DataPropertyName = "PartnerId";
            this.PartnerId.HeaderText = "Id";
            this.PartnerId.Name = "PartnerId";
            this.PartnerId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartnerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PartnerId.Visible = false;
            // 
            // PartnerName
            // 
            this.PartnerName.DataPropertyName = "PartnerName";
            this.PartnerName.HeaderText = "Nume";
            this.PartnerName.Name = "PartnerName";
            this.PartnerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartnerSurname
            // 
            this.PartnerSurname.DataPropertyName = "PartnerSurname";
            this.PartnerSurname.HeaderText = "Prenume";
            this.PartnerSurname.Name = "PartnerSurname";
            this.PartnerSurname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartnerSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartnerCode
            // 
            this.PartnerCode.DataPropertyName = "PartnerCode";
            this.PartnerCode.HeaderText = "Cod";
            this.PartnerCode.Name = "PartnerCode";
            this.PartnerCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartnerCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneNo
            // 
            this.PhoneNo.DataPropertyName = "PhoneNo";
            this.PhoneNo.HeaderText = "Telefon";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareClientToolStripMenuItem,
            this.stergereClientToolStripMenuItem,
            this.modificareClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // adaugareClientToolStripMenuItem
            // 
            this.adaugareClientToolStripMenuItem.Name = "adaugareClientToolStripMenuItem";
            this.adaugareClientToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.adaugareClientToolStripMenuItem.Text = "Adaugare Client";
            this.adaugareClientToolStripMenuItem.Click += new System.EventHandler(this.AdaugareClientToolStripMenuItem_Click);
            // 
            // stergereClientToolStripMenuItem
            // 
            this.stergereClientToolStripMenuItem.Name = "stergereClientToolStripMenuItem";
            this.stergereClientToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.stergereClientToolStripMenuItem.Text = "Stergere Client";
            this.stergereClientToolStripMenuItem.Click += new System.EventHandler(this.StergereClientToolStripMenuItem_Click);
            // 
            // modificareClientToolStripMenuItem
            // 
            this.modificareClientToolStripMenuItem.Name = "modificareClientToolStripMenuItem";
            this.modificareClientToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificareClientToolStripMenuItem.Text = "Modificare Client";
            this.modificareClientToolStripMenuItem.Click += new System.EventHandler(this.ModificareClientToolStripMenuItem_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(15, 202);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 1;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(121, 202);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 20);
            this.tbPrenume.TabIndex = 2;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(227, 202);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 3;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(333, 202);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 4;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTelefon_KeyPress);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 176);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(103, 13);
            this.lblTitlu.TabIndex = 6;
            this.lblTitlu.Text = "FILTRARE CLIENTI";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(35, 225);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(64, 13);
            this.lblNume.TabIndex = 7;
            this.lblNume.Text = "Nume Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenume Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cod Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Client";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(15, 259);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(100, 24);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.BtnCauta_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(121, 260);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 23);
            this.btnAddClient.TabIndex = 13;
            this.btnAddClient.Text = "Adauga Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(227, 260);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(100, 23);
            this.btnEditClient.TabIndex = 14;
            this.btnEditClient.Text = "Modifica Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.BtnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(333, 260);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteClient.TabIndex = 15;
            this.btnDeleteClient.Text = "Sterge Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(455, 182);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Meniu Principal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnAdresa
            // 
            this.btnAdresa.Location = new System.Drawing.Point(455, 244);
            this.btnAdresa.Name = "btnAdresa";
            this.btnAdresa.Size = new System.Drawing.Size(75, 36);
            this.btnAdresa.TabIndex = 17;
            this.btnAdresa.Text = "Adresa Client";
            this.btnAdresa.UseVisualStyleBackColor = true;
            this.btnAdresa.Click += new System.EventHandler(this.BtnAdresa_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.btnAdresa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.dataGridViewClienti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsForm";
            this.Text = "CLIENTI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareClientToolStripMenuItem;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartnerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnAdresa;
    }
}