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
    public partial class AddInvoiceForm : Form
    {
        public AddInvoiceForm()
        {
            InitializeComponent();
            initComboBoxes();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BLInvoices bLInvoices = new BLInvoices();
            InvoiceModel facturaCreata = new InvoiceModel();
            if (String.IsNullOrWhiteSpace(tbNumar.Text))
            {
                errorProvider1.SetError(tbNumar, "Camp obligatoriu!");
            }
            else
            {
                string nrFactura = tbNumar.Text;
                facturaCreata.InvoiceNumber = nrFactura;
                facturaCreata.InvoiceDate = dateTimePickerFactura.Value;
                facturaCreata.Observations = tbObs.Text;
                facturaCreata.user.UserId = LoginForm.UserId;
                facturaCreata.adresa.PartnerId = Convert.ToInt32(cbClient.SelectedValue);
                facturaCreata.client.ClientId = Convert.ToInt32(cbClient.SelectedValue);
                if (string.IsNullOrEmpty(cbAdrese.Text) || cbAdrese.SelectedIndex == -1)
                {

                    MessageBox.Show("Nu se poate face factura pentru un client fara adrese!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    facturaCreata.adresa.PartnerAddressId = Convert.ToInt32(cbAdrese.SelectedValue);
                    bLInvoices.InsertInvoice(facturaCreata, out bool status, out string message);
                    MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    DialogResult dialogResult = MessageBox.Show("Doriti sa adaugati si detalii pentru factura introdusa?", "Detalii Factura", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        InvoiceDetailsForm form = new InvoiceDetailsForm(facturaCreata);
                        form.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                    }
                }                
                InvoicesForm invoicesForm = new InvoicesForm();
                invoicesForm.initializareDataGridView();
            }
        }
        public void initComboBoxes()
        {
            BLClients bLClients = new BLClients();
            DataTable clienti = bLClients.GetClient();
            cbClient.DataSource = clienti;
            cbClient.ValueMember = "PartnerId";
            cbClient.DisplayMember = "PartnerName";
            cbClient.Text = "Clienti";
        }
        public void initAdrese(int id)
        {
            BLAddress blAdrese = new BLAddress();
            DataTable adrese = blAdrese.GetClientAddresses(id);
            cbAdrese.DataSource = adrese;
            cbAdrese.ValueMember = "PartnerAddressId";
            cbAdrese.DisplayMember = "AdresaClient";
        }
        private void CbClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initAdrese(Convert.ToInt32(cbClient.SelectedValue));
        }
    }
}