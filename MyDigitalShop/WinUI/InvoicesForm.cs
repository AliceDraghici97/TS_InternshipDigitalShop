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
    public partial class InvoicesForm : Form
    {
        public bool filled = false;
        public InvoicesForm()
        {
            InitializeComponent();
        }
        public void initializareDataGridView()
        {
            int id = LoginForm.UserId;
            try
            {
                BLInvoices blFacturi = new BLInvoices();
                DataTable dt = new DataTable();
                dt = blFacturi.GetInvoices(id);
                dataGridViewFacturi.DataSource = dt;
                filled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCautaFacturi_Click(object sender, EventArgs e)
        {
            initializareDataGridView();
        }
        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            AddInvoiceForm form = new AddInvoiceForm();
            form.Show();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewFacturi.SelectedRows.Count > 0)
                {
                    InvoiceModel factura = new InvoiceModel();
                    foreach (DataGridViewRow row in dataGridViewFacturi.SelectedRows)
                    {
                        factura.InvoiceId = Convert.ToInt32(row.Cells[0].Value.ToString());
                        factura.InvoiceNumber = row.Cells[1].Value.ToString();
                        factura.InvoiceDate = Convert.ToDateTime(row.Cells[2].Value.ToString());
                        factura.client.ClientId = Convert.ToInt32(row.Cells[3].Value.ToString());
                        factura.adresa.PartnerAddressId = Convert.ToInt32(row.Cells[4].Value.ToString());
                        factura.user.UserId = Convert.ToInt32(row.Cells[5].Value.ToString());
                        factura.Observations = row.Cells[6].Value.ToString();
                    }
                    EditInvoiceForm form = new EditInvoiceForm(factura, this);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Selectati o factura pentru editare!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista facturi goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewFacturi.SelectedRows.Count > 0)
                {
                    int invoiceId = -2;
                    BLInvoices blInvoices = new BLInvoices();
                    BLInvoiceDetails bLInvoiceDetails = new BLInvoiceDetails();
                    foreach (DataGridViewRow row in dataGridViewFacturi.SelectedRows)
                    {
                        invoiceId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }
                    DialogResult dialogResult = MessageBox.Show("Sigur doriti sa stergeti datele facturii selectate?",
                        "Stergere Factura", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bLInvoiceDetails.DeleteAllDetails(invoiceId, out string errormessage);
                        blInvoices.DeleteInvoice(invoiceId, out string message);
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
                    MessageBox.Show("Selectati o factura pentru stergere!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista facturi goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (filled)
            {
                if (dataGridViewFacturi.SelectedRows.Count > 0)
                {
                    InvoiceModel factura = new InvoiceModel();
                    foreach (DataGridViewRow row in dataGridViewFacturi.SelectedRows)
                    {
                        factura.InvoiceId = Convert.ToInt32(row.Cells[0].Value.ToString());
                        factura.InvoiceNumber = row.Cells[1].Value.ToString();
                        factura.InvoiceDate = Convert.ToDateTime(row.Cells[2].Value.ToString());
                        factura.client.ClientId = Convert.ToInt32(row.Cells[3].Value.ToString());
                        factura.adresa.PartnerAddressId = Convert.ToInt32(row.Cells[4].Value.ToString());
                        factura.user.UserId = Convert.ToInt32(row.Cells[5].Value.ToString());
                        factura.Observations = row.Cells[6].Value.ToString();
                        factura.client.Nume = row.Cells[7].Value.ToString();
                    }
                    InvoiceDetailsForm form = new InvoiceDetailsForm(factura);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Selectati o factura pentru a putea vedea detalii!", "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lista facturi goala! Efectuati o cautare!", "Status", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
