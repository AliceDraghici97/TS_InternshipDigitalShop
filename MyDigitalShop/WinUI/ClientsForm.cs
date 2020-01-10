using BusinessLogic;
using DataAccess;
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
    public partial class ClientsForm : Form
    {
        public bool filled = false;
        public ClientsForm()
        {
            InitializeComponent();
        }
        public void initializareDataGridView()
        {
            try
            {
                BLClients blClienti = new BLClients();
                DataTable dt = new DataTable();
                dt = blClienti.GetClient();
                dataGridViewClienti.DataSource = dt;
                filled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCauta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbCod.Text) && String.IsNullOrWhiteSpace(tbNume.Text) && String.IsNullOrWhiteSpace(tbPrenume.Text) &&
                String.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                initializareDataGridView();
            }
            else
            {
                filter();
            }
        }
        private void filter()
        {
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string cod = tbCod.Text;
            string tel = tbTelefon.Text;

            BLClients blClienti = new BLClients();
            DataTable dt = new DataTable();

            dt = blClienti.FiltrareClienti(nume, prenume, cod, tel);
            dataGridViewClienti.DataSource = dt;
        }
        private void TbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void AdaugareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClientForm form = new AddClientForm(this);
            form.Show();
        }
        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            AdaugareClientToolStripMenuItem_Click(sender, e);
        }
        private void StergereClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewClienti.SelectedRows.Count > 0)
                {
                    int clientId = -2;
                    BLClients blClients = new BLClients();
                    BLAddress bLAddress = new BLAddress();
                    BLInvoices blInvoice = new BLInvoices();
                    foreach (DataGridViewRow row in dataGridViewClienti.SelectedRows)
                    {
                        clientId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                    DataTable facturiClient = blInvoice.GetInvoicesById(clientId);
                    if (facturiClient.Rows.Count <= 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Sigur doriti sa stergeti datele clientului?",
                            "Stergere Client", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            bLAddress.DeleteAllAddresses(clientId, out string errorMessage);
                            blClients.DeleteClient(clientId, out string message);
                            MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                            initializareDataGridView();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu se poate sterge clientul, deoarece are facturi inregistrate!", "Status", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                        initializareDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Selectati un client pentru stergere!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista clieti goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void ModificareClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewClienti.SelectedRows.Count > 0)
                {
                    PartnerModel client = new PartnerModel();
                    foreach (DataGridViewRow row in dataGridViewClienti.SelectedRows)
                    {
                        client.ClientId = Convert.ToInt32(row.Cells[0].Value.ToString());
                        client.Nume = row.Cells[1].Value.ToString();
                        client.Prenume = row.Cells[2].Value.ToString();
                        client.CodClient = row.Cells[3].Value.ToString();
                        client.Telefon = row.Cells[4].Value.ToString();
                        client.Email = row.Cells[5].Value.ToString();
                    }
                    EditClientForm form = new EditClientForm(client, this);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Selectati un client pentru editare!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista clieti goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            ModificareClientToolStripMenuItem_Click(sender, e);
        }
        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            StergereClientToolStripMenuItem_Click(sender, e);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }
        private void BtnAdresa_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewClienti.SelectedRows.Count > 0)
                {
                    PartnerModel client = new PartnerModel();
                    foreach (DataGridViewRow row in dataGridViewClienti.SelectedRows)
                    {
                        client.ClientId = Convert.ToInt32(row.Cells[0].Value.ToString());
                        client.Nume = row.Cells[1].Value.ToString();
                        client.Prenume = row.Cells[2].Value.ToString();
                        client.CodClient = row.Cells[3].Value.ToString();
                        client.Telefon = row.Cells[4].Value.ToString();
                        client.Email = row.Cells[5].Value.ToString();
                        AddressModel adresa = new AddressModel();
                        adresa.PartnerId = Convert.ToInt32(Convert.ToInt32(row.Cells[0].Value.ToString()));
                        EditClientAddressForm form = new EditClientAddressForm(adresa, client);
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Selectati clientul pentru a vedea adresele!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista clieti goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}