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
    public partial class InvoiceDetailsForm : Form
    {
        public InvoiceModel factura;
        public int EditDetailId;
        public InvoiceDetailsForm(InvoiceModel factura)
        {
            InitializeComponent();
            this.factura = factura;
            initializareDataGrid(factura.InvoiceId);
            initFactura(factura);
        }
        public void initFactura(InvoiceModel factura)
        {
            try
            {
                BLAddress adr = new BLAddress();
                DataTable adresaFact = adr.GetClientAddresses(factura.client.ClientId);
                tbDatFactura.Text = factura.InvoiceDate.ToString();
                tbNrFactura.Text = factura.InvoiceNumber.ToString();
                tbNumeClient.Text = factura.client.Nume.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("eroare INIT FACTURA! " + ex.Message);
            }
        }
        public void initializareDataGrid(int id)
        {
            try
            {
                BLInvoiceDetails bLInvoiceDetails = new BLInvoiceDetails();
                DataTable dt = new DataTable();
                dt = bLInvoiceDetails.GetDetails(id);
                dataGridViewDetalii.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void initializareComboBox()
        {
            BLItems blItems = new BLItems();
            DataTable articole = blItems.GetItems();
            cbItems.DataSource = articole;
            cbItems.DisplayMember = "ItemName";
            cbItems.ValueMember = "ItemId";
        }
        private InvoiceDetailModel InitEditPanel()
        {
            InvoiceDetailModel detail = new InvoiceDetailModel();
            initializareComboBox();
            foreach (DataGridViewRow row in dataGridViewDetalii.SelectedRows)
            {
                tbAmount.Text = row.Cells[5].Value.ToString();
                detail.InvoiceDetailId = Convert.ToInt32(row.Cells[0].Value.ToString());
                tbObservations.Text = row.Cells[6].Value.ToString();
                tbPrice.Text = row.Cells[4].Value.ToString();
                tbQtty.Text = row.Cells[3].Value.ToString();
                tbAmount.Text = ((Convert.ToDecimal(row.Cells[4].Value.ToString())) *
                    (Convert.ToDecimal(row.Cells[3].Value.ToString()))).ToString();
                DataTable items = new DataTable();
                BLItems blItems = new BLItems();
                try
                {
                    items = blItems.GetItemNameById(Convert.ToInt32(row.Cells[2].Value.ToString()));
                    cbItems.Text = items.Rows[0]["ItemName"].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Eroare INIT PANEL!! " + ex.Message);
                }
            }
            return detail;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            initializareComboBox();
            panel1.Visible = true;
            btnAdd.Visible = false;
            btnEditDetail.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            this.EditDetailId = InitEditPanel().InvoiceDetailId;
        }
        private void BtnAddFact_Click(object sender, EventArgs e)
        {
            initializareComboBox();
            panel1.Visible = true;
            label1.Visible = true;
            btnAdd.Visible = true;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InvoiceDetailModel detaliu = new InvoiceDetailModel();
            BLInvoiceDetails blInvoice = new BLInvoiceDetails();

            if (String.IsNullOrWhiteSpace(tbPrice.Text))
            {
                errorProvider1.SetError(tbPrice, "Camp obligatoriu!");
            }
            else if (String.IsNullOrWhiteSpace(tbQtty.Text))
            {
                errorProvider1.SetError(tbPrice, "Camp obligatoriu!");
            }
            else
            {
                try
                {
                    detaliu.Price = Convert.ToDecimal(tbPrice.Text);
                    detaliu.Qtty = Convert.ToDecimal(tbQtty.Text);
                    detaliu.Amount = Convert.ToDecimal(tbAmount.Text);
                    detaliu.Observations = tbObservations.Text;
                    detaliu.Factura.InvoiceId = factura.InvoiceId;
                    detaliu.Articol.ItemId = Convert.ToInt32(cbItems.SelectedValue);
                    blInvoice.InsertInvoiceDetail(detaliu, out bool status, out string message);
                    MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    panel1.Visible = false;
                    initializareDataGrid(this.factura.InvoiceId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EROARE INSERARE DETALIU! " + ex.Message);
                }
            }
        }
        private void TbPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbQtty != null && !string.IsNullOrWhiteSpace(tbQtty.Text) && tbPrice != null && !string.IsNullOrWhiteSpace(tbPrice.Text))
                {
                    tbAmount.Text = ((float)Convert.ToDouble(tbPrice.Text) *
                     (float)Convert.ToDouble(tbQtty.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("eroare INIT TB AMOUNT !!" + ex.Message);
            }
        }
        private void BtnEditDetail_Click(object sender, EventArgs e)
        {
            InvoiceDetailModel detaliuModificat = new InvoiceDetailModel();
            BLInvoiceDetails bLInvoiceDetails = new BLInvoiceDetails();
            try
            {
                detaliuModificat.InvoiceDetailId = this.EditDetailId;
                detaliuModificat.Price = Convert.ToDecimal(tbPrice.Text);
                detaliuModificat.Qtty = Convert.ToDecimal(tbQtty.Text);
                detaliuModificat.Amount = Convert.ToDecimal(tbAmount.Text);
                detaliuModificat.Observations = tbObservations.Text;
                detaliuModificat.Articol.ItemId = Convert.ToInt32(cbItems.SelectedValue);
                DialogResult dialogResult = MessageBox.Show("Sigur doriti sa modificati detaliul?", "Modificare Detaliu Factura", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bLInvoiceDetails.UpdateInvoiceDetail(detaliuModificat, out bool status, out string message);
                    MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    panel1.Visible = false;
                    initializareDataGrid(this.factura.InvoiceId);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EROARE UPDATE DETAIL! " + ex.Message);
            }
        }
        private void TbQtty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbQtty != null && !string.IsNullOrWhiteSpace(tbQtty.Text) && tbPrice != null && !string.IsNullOrWhiteSpace(tbPrice.Text))
                {
                    tbAmount.Text = ((float)Convert.ToDouble(tbPrice.Text) *
                    (float)Convert.ToDouble(tbQtty.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("eroare INIT TB AMOUNT !!" + ex.Message);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            InvoiceDetailModel detaliuModificat = new InvoiceDetailModel();
            BLInvoiceDetails bLInvoiceDetails = new BLInvoiceDetails();
            int detId = -2;
            foreach (DataGridViewRow row in dataGridViewDetalii.SelectedRows)
            {
                detId = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            DialogResult dialogResult = MessageBox.Show("Sigur doriti sa stergeti detaliul?", "Stergere Detaliu Factura", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bLInvoiceDetails.DeleteSelectedDetail(detId, out string errorMessage);
                MessageBox.Show(errorMessage, "Status", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                initializareDataGrid(this.factura.InvoiceId);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
        }
        private void TbQtty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (tbQtty.TextLength < 1)
                    e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (tbQtty.TextLength < 1)
                    e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}