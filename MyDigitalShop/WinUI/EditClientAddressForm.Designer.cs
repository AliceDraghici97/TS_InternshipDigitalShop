namespace WinUI
{
    partial class EditClientAddressForm
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
            this.dataGridViewAdrese = new System.Windows.Forms.DataGridView();
            this.cityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPartener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Judet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.btnSaveADRS = new System.Windows.Forms.Button();
            this.comboBoxJudete = new System.Windows.Forms.ComboBox();
            this.comboBoxOrase = new System.Windows.Forms.ComboBox();
            this.tbNumar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Numar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdrese)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdrese
            // 
            this.dataGridViewAdrese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdrese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityId,
            this.pAdressId,
            this.CountyId,
            this.IdPartener,
            this.Strada,
            this.Numarr,
            this.Oras,
            this.Judet});
            this.dataGridViewAdrese.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAdrese.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdrese.Name = "dataGridViewAdrese";
            this.dataGridViewAdrese.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewAdrese.TabIndex = 0;
            // 
            // cityId
            // 
            this.cityId.DataPropertyName = "CityId";
            this.cityId.HeaderText = "CityId";
            this.cityId.Name = "cityId";
            this.cityId.Visible = false;
            // 
            // pAdressId
            // 
            this.pAdressId.DataPropertyName = "PartnerAddressId";
            this.pAdressId.HeaderText = "PartnerAddressId";
            this.pAdressId.Name = "pAdressId";
            this.pAdressId.Visible = false;
            // 
            // CountyId
            // 
            this.CountyId.DataPropertyName = "CountyId";
            this.CountyId.HeaderText = "CountyId";
            this.CountyId.Name = "CountyId";
            this.CountyId.Visible = false;
            // 
            // IdPartener
            // 
            this.IdPartener.DataPropertyName = "PartnerId";
            this.IdPartener.HeaderText = "PartnerId";
            this.IdPartener.Name = "IdPartener";
            this.IdPartener.Visible = false;
            // 
            // Strada
            // 
            this.Strada.DataPropertyName = "StreetName";
            this.Strada.HeaderText = "Strada";
            this.Strada.Name = "Strada";
            // 
            // Numarr
            // 
            this.Numarr.DataPropertyName = "StreetNo";
            this.Numarr.HeaderText = "Numar";
            this.Numarr.Name = "Numarr";
            // 
            // Oras
            // 
            this.Oras.DataPropertyName = "CityName";
            this.Oras.HeaderText = "Oras";
            this.Oras.Name = "Oras";
            // 
            // Judet
            // 
            this.Judet.DataPropertyName = "CountyName";
            this.Judet.HeaderText = "Judet";
            this.Judet.Name = "Judet";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(30, 156);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(111, 23);
            this.btnAddAddress.TabIndex = 1;
            this.btnAddAddress.Text = "Adauga Adresa";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adaugare Adresa Noua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Strada";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(59, 38);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(172, 21);
            this.tbStreet.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveEdits);
            this.panel1.Controls.Add(this.btnSaveADRS);
            this.panel1.Controls.Add(this.comboBoxJudete);
            this.panel1.Controls.Add(this.comboBoxOrase);
            this.panel1.Controls.Add(this.tbNumar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Numar);
            this.panel1.Controls.Add(this.tbStreet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 138);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Location = new System.Drawing.Point(159, 112);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(116, 23);
            this.btnSaveEdits.TabIndex = 10;
            this.btnSaveEdits.Text = "Salveaza Modificarile";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Visible = false;
            this.btnSaveEdits.Click += new System.EventHandler(this.BtnSaveEdits_Click);
            // 
            // btnSaveADRS
            // 
            this.btnSaveADRS.Location = new System.Drawing.Point(59, 112);
            this.btnSaveADRS.Name = "btnSaveADRS";
            this.btnSaveADRS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveADRS.TabIndex = 9;
            this.btnSaveADRS.Text = "Salveaza";
            this.btnSaveADRS.UseVisualStyleBackColor = true;
            this.btnSaveADRS.Click += new System.EventHandler(this.BtnSaveADRS_Click);
            // 
            // comboBoxJudete
            // 
            this.comboBoxJudete.FormattingEnabled = true;
            this.comboBoxJudete.Location = new System.Drawing.Point(281, 75);
            this.comboBoxJudete.Name = "comboBoxJudete";
            this.comboBoxJudete.Size = new System.Drawing.Size(100, 21);
            this.comboBoxJudete.TabIndex = 8;
            // 
            // comboBoxOrase
            // 
            this.comboBoxOrase.FormattingEnabled = true;
            this.comboBoxOrase.Location = new System.Drawing.Point(59, 75);
            this.comboBoxOrase.Name = "comboBoxOrase";
            this.comboBoxOrase.Size = new System.Drawing.Size(172, 21);
            this.comboBoxOrase.TabIndex = 7;
            // 
            // tbNumar
            // 
            this.tbNumar.Location = new System.Drawing.Point(281, 38);
            this.tbNumar.Name = "tbNumar";
            this.tbNumar.Size = new System.Drawing.Size(100, 21);
            this.tbNumar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Oras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Judet";
            // 
            // Numar
            // 
            this.Numar.AutoSize = true;
            this.Numar.Location = new System.Drawing.Point(237, 45);
            this.Numar.Name = "Numar";
            this.Numar.Size = new System.Drawing.Size(38, 13);
            this.Numar.TabIndex = 3;
            this.Numar.Text = "Numar";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sterge Adresa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(171, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Modificati Adresa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prenume Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cod Client";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(30, 203);
            this.tbNume.Name = "tbNume";
            this.tbNume.ReadOnly = true;
            this.tbNume.Size = new System.Drawing.Size(116, 21);
            this.tbNume.TabIndex = 8;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(171, 202);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.ReadOnly = true;
            this.tbPrenume.Size = new System.Drawing.Size(111, 21);
            this.tbPrenume.TabIndex = 9;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(320, 203);
            this.tbCod.Name = "tbCod";
            this.tbCod.ReadOnly = true;
            this.tbCod.Size = new System.Drawing.Size(111, 21);
            this.tbCod.TabIndex = 10;
            // 
            // EditClientAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 393);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.dataGridViewAdrese);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClientAddressForm";
            this.Text = "ADRESE CLIENTI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdrese)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdrese;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Numar;
        private System.Windows.Forms.Button btnSaveADRS;
        private System.Windows.Forms.ComboBox comboBoxJudete;
        private System.Windows.Forms.ComboBox comboBoxOrase;
        private System.Windows.Forms.TextBox tbNumar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPartener;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numarr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Judet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label7;
    }
}