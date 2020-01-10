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
    public partial class EditInvoiceForm : Form
    {
        public InvoicesForm form;
        public InvoiceModel factura;
        public EditInvoiceForm(InvoiceModel factura, InvoicesForm form)
        {
            InitializeComponent();
            this.factura = factura;
            this.form = form;
            InitForm(this.factura);
        }

        public void InitForm(InvoiceModel factura)
        {
            BLAddress blAdresa = new BLAddress();
            BLClients blClient = new BLClients();
            DataTable adresa = new DataTable();
            DataTable client = new DataTable();
            initComboBoxes();
            tbNumar.Text = factura.InvoiceNumber.ToString();
            dateTimePickerFactura.Value = factura.InvoiceDate;
            client = blClient.GetClientById(factura.client.ClientId);
            cbClient.Text = client.Rows[0]["NumeClient"].ToString();
            adresa = blAdresa.GetClientAddressesById(factura.client.ClientId, factura.adresa.PartnerAddressId);
            cbAdrese.Text = adresa.Rows[0]["AdresaClient"].ToString();
            tbObs.Text = factura.Observations.ToString();

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BLInvoices bLInvoices = new BLInvoices();
            InvoiceModel facturaCreata = new InvoiceModel();
            if (String.IsNullOrWhiteSpace(tbNumar.Text))
            {
                errorProvider1.SetError(tbNumar, "Camp obligatoriu!");
            }
            else if(cbAdrese.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbAdrese, "Nu se poate adauga un client fara adrese pe factura!");
            }
            else
            {
                try
                {
                    string nrFactura = tbNumar.Text;
                    facturaCreata.InvoiceId = factura.InvoiceId;
                    facturaCreata.InvoiceNumber = nrFactura;
                    facturaCreata.InvoiceDate = dateTimePickerFactura.Value;
                    facturaCreata.Observations = tbObs.Text;
                    facturaCreata.adresa.PartnerId = Convert.ToInt32(cbClient.SelectedValue);
                    facturaCreata.client.ClientId = Convert.ToInt32(cbClient.SelectedValue);
                    facturaCreata.adresa.PartnerAddressId = Convert.ToInt32(cbAdrese.SelectedValue);
                    
                    DialogResult dialogResult = MessageBox.Show("Sigur doriti sa modificati datele clientului?", "Adresa Client", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bLInvoices.UpdateInvoice(facturaCreata, out bool status, out string message);
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
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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
        private void CbClient_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            initAdrese(Convert.ToInt32(cbClient.SelectedValue));
        }
    }
}
 