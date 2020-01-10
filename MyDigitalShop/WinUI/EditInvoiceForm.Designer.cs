namespace WinUI
{
    partial class EditInvoiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAdrese = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFactura = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbObs = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumar = new System.Windows.Forms.Label();
            this.tbNumar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAdrese);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.dateTimePickerFactura);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lbObs);
            this.panel1.Controls.Add(this.tbObs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumar);
            this.panel1.Controls.Add(this.tbNumar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 214);
            this.panel1.TabIndex = 23;
            // 
            // cbAdrese
            // 
            this.cbAdrese.FormattingEnabled = true;
            this.cbAdrese.Location = new System.Drawing.Point(92, 93);
            this.cbAdrese.Name = "cbAdrese";
            this.cbAdrese.Size = new System.Drawing.Size(200, 21);
            this.cbAdrese.TabIndex = 34;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(134, 66);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 21);
            this.cbClient.TabIndex = 33;
            this.cbClient.SelectionChangeCommitted += new System.EventHandler(this.CbClient_SelectionChangeCommitted_1);
            // 
            // dateTimePickerFactura
            // 
            this.dateTimePickerFactura.Location = new System.Drawing.Point(92, 41);
            this.dateTimePickerFactura.Name = "dateTimePickerFactura";
            this.dateTimePickerFactura.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerFactura.TabIndex = 32;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Salvare";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lbObs
            // 
            this.lbObs.AutoSize = true;
            this.lbObs.Location = new System.Drawing.Point(25, 126);
            this.lbObs.Name = "lbObs";
            this.lbObs.Size = new System.Drawing.Size(56, 13);
            this.lbObs.TabIndex = 30;
            this.lbObs.Text = "Observatii";
            // 
            // tbObs
            // 
            this.tbObs.Location = new System.Drawing.Point(143, 123);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(100, 21);
            this.tbObs.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Adrese Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nume Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data Factura";
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Location = new System.Drawing.Point(9, 18);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(78, 13);
            this.lblNumar.TabIndex = 25;
            this.lblNumar.Text = "Numar Factura";
            // 
            // tbNumar
            // 
            this.tbNumar.Location = new System.Drawing.Point(143, 11);
            this.tbNumar.Name = "tbNumar";
            this.tbNumar.Size = new System.Drawing.Size(100, 21);
            this.tbNumar.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 242);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditInvoiceForm";
            this.Text = "EDITARE FACTURA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbAdrese;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerFactura;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbObs;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.TextBox tbNumar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}