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
    public partial class AddClientForm : Form
    {
        public ClientsForm form;
        public AddClientForm(ClientsForm clientsForm)
        {
            InitializeComponent();
            this.form = clientsForm;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BLClients blClients = new BLClients();
            if (String.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorProvider1.SetError(tbNume, "Camp obligatoriu!");
            }
            else if (String.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                errorProvider1.SetError(tbPrenume, "Camp obligatoriu!");
            }
            else if (String.IsNullOrWhiteSpace(tbCod.Text))
            {
                errorProvider1.SetError(tbCod, "Camp obligatoriu!");
            }
            else if (String.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                errorProvider1.SetError(tbTelefon, "Camp obligatoriu!");
            }
            else
            {
                PartnerModel clientNou = new PartnerModel();
                string nume = tbNume.Text;
                clientNou.Nume = nume;
                string prenume = tbPrenume.Text;
                clientNou.Prenume = prenume;
                string cod = tbCod.Text;
                clientNou.CodClient = cod;
                string tel = tbTelefon.Text;
                clientNou.Telefon = tel;
                string email = tbEmail.Text;
                clientNou.Email = email;
                blClients.InsertUser(nume, prenume, cod, tel, email, out bool status, out string error);
                MessageBox.Show(error, "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                form.initializareDataGridView();
                DialogResult dialogResult = MessageBox.Show("Doriti sa adaugati si adresa pentru clientul introdus?", "Adresa Client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddressModel adresa = new AddressModel();
                    adresa.PartnerId = blClients.SelectPartnerId(nume, prenume, cod);
                    EditClientAddressForm form = new EditClientAddressForm(adresa, clientNou);
                    form.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
        }
        private void TbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (tbEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(tbEmail.Text))
                {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbEmail.SelectAll();
                    e.Cancel = true;
                }
            }

        }
    }
}