namespace WinUI
{
    partial class MainMenuForm
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
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnFacturi = new System.Windows.Forms.Button();
            this.btnArticole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienti
            // 
            this.btnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienti.Location = new System.Drawing.Point(43, 12);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(158, 23);
            this.btnClienti.TabIndex = 0;
            this.btnClienti.Text = "CLIENTI";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
            // 
            // btnFacturi
            // 
            this.btnFacturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturi.Location = new System.Drawing.Point(43, 51);
            this.btnFacturi.Name = "btnFacturi";
            this.btnFacturi.Size = new System.Drawing.Size(158, 23);
            this.btnFacturi.TabIndex = 1;
            this.btnFacturi.Text = "FACTURI";
            this.btnFacturi.UseVisualStyleBackColor = true;
            this.btnFacturi.Click += new System.EventHandler(this.BtnFacturi_Click);
            // 
            // btnArticole
            // 
            this.btnArticole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticole.Location = new System.Drawing.Point(43, 89);
            this.btnArticole.Name = "btnArticole";
            this.btnArticole.Size = new System.Drawing.Size(157, 23);
            this.btnArticole.TabIndex = 2;
            this.btnArticole.Text = "ARTICOLE";
            this.btnArticole.UseVisualStyleBackColor = true;
            this.btnArticole.Click += new System.EventHandler(this.BtnArticole_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 140);
            this.Controls.Add(this.btnArticole);
            this.Controls.Add(this.btnFacturi);
            this.Controls.Add(this.btnClienti);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "MENIU PRINCIPAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnFacturi;
        private System.Windows.Forms.Button btnArticole;
    }
}