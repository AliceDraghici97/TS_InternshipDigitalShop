using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class EditClientForm : Form
    {
        public PartnerModel client;
        public ClientsForm form;

        public EditClientForm(PartnerModel client, ClientsForm clientsForm)
        {
            InitializeComponent();
            this.client = client;
            this.form = clientsForm;
            InitForm();
        }
        private void InitForm()
        {
            tbNume.Text = client.Nume;
            tbPrenume.Text = client.Prenume;
            tbCod.Text = client.CodClient;
            tbTelefon.Text = client.Telefon;
            tbEmail.Text = client.Email;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PartnerModel clientNou = new PartnerModel();
            clientNou.ClientId = this.client.ClientId;
            clientNou.Nume = tbNume.Text;
            clientNou.Prenume = tbPrenume.Text;
            clientNou.CodClient = tbCod.Text;
            clientNou.Telefon = tbTelefon.Text;
            clientNou.Email = tbEmail.Text;
            BLClients blClient = new BLClients();
            DialogResult dialogResult = MessageBox.Show("Sigur doriti sa modificati datele clientului?", "Adresa Client", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                blClient.UpdateClient(clientNou, out string message);
                MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                form.initializareDataGridView();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
        }
    }
}
