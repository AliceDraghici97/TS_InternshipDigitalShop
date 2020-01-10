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
    public partial class EditClientAddressForm : Form
    {
        public int partnerId;
        public int partnerAddressId;
        public PartnerModel client;

        public EditClientAddressForm(AddressModel adresa, PartnerModel client)
        {
            InitializeComponent();
            this.partnerId = adresa.PartnerId; 
            this.partnerAddressId = adresa.PartnerAddressId;
            this.client = client;
            initializareDataGrid(adresa.PartnerId);
            InitClientData(this.client);
        }
        public EditClientAddressForm()
        {

        }
        public void initializareDataGrid(int id)
        {
            try
            {
                BLAddress blAdresa = new BLAddress();
                DataTable dt = new DataTable();
                dt = blAdresa.GetAddresses(id);
                dataGridViewAdrese.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitClientData(PartnerModel client)
        {
            tbCod.Text = client.CodClient.ToString();
            tbNume.Text = client.Nume.ToString();
            tbPrenume.Text = client.Prenume.ToString();
        }
        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = "Adaugare Adresa Noua";
            btnAddAddress.Visible = true;
            btnSaveEdits.Visible = false;
            initComboBoxes();
        }
        public void initComboBoxes()
        {
            BLAddress bLAddress = new BLAddress();
            List<CityModel> listOrase = bLAddress.GetCities();
            comboBoxOrase.DataSource = listOrase;
            comboBoxOrase.DisplayMember = "CityName";
            comboBoxOrase.ValueMember = "CityId";

            List<CountyModel> judete = bLAddress.GetCounties();
            comboBoxJudete.DataSource = judete;
            comboBoxJudete.DisplayMember = "CountyName";
            comboBoxJudete.ValueMember = "CountyId";
        }
        private void BtnSaveADRS_Click(object sender, EventArgs e)
        {
            AddressModel adresa = new AddressModel();
            BLAddress bLAddress = new BLAddress();
            if (String.IsNullOrWhiteSpace(tbStreet.Text))
            {
                errorProvider1.SetError(tbStreet, "Camp obligatoriu!");
            }
            else if (String.IsNullOrWhiteSpace(tbNumar.Text))
            {
                errorProvider1.SetError(tbNumar, "Camp obligatoriu!");
            }
            else
            {
                try
                {
                    string strada = tbStreet.Text;
                    adresa.Street = strada;
                    string numar = tbNumar.Text;
                    adresa.Number = numar;
                    adresa.PartnerId = this.partnerId;
                    adresa.County.CountyId = Convert.ToInt32(comboBoxJudete.SelectedValue.ToString());
                    adresa.Oras.CityId = Convert.ToInt32(comboBoxOrase.SelectedValue.ToString());
                    bLAddress.InsertAdress(adresa, out bool status, out string message);
                    MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    initializareDataGrid(this.partnerId);
                    panel1.Visible = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            BLInvoices blInvoice = new BLInvoices();
            int adrsId = -2;
            BLAddress blADR = new BLAddress();
            foreach (DataGridViewRow row in dataGridViewAdrese.SelectedRows)
            {
                adrsId = Convert.ToInt32(row.Cells[1].Value.ToString());
            }
            DataTable facturiClient = blInvoice.GetInvoicesById(this.partnerId);
            if (facturiClient.Rows.Count > 0 && facturiClient != null)
            {
                MessageBox.Show("Nu se poate sterge adresa, deoarece are facturi inregistrate!", "Status", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                initializareDataGrid(partnerId);
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Sigur doriti sa stergeti adresa?", "Stergere Adresa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    blADR.DeleteSelectedAddress(adrsId, out string message);
                    MessageBox.Show(message, "Status", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    initializareDataGrid(partnerId);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
        }
        
        private AddressModel InitPanel()
        {
            AddressModel adresa = new AddressModel();
            BLAddress bLAddress = new BLAddress();
            DataTable oras = new DataTable();
            DataTable judet = new DataTable();
            btnSaveADRS.Visible = false;
            btnSaveEdits.Visible = true;
            foreach (DataGridViewRow row in dataGridViewAdrese.SelectedRows)
            {
                adresa.PartnerAddressId = Convert.ToInt32(row.Cells[1].Value.ToString());
                adresa.Oras.CityId = Convert.ToInt32(row.Cells[2].Value.ToString());
                adresa.County.CountyId = Convert.ToInt32(row.Cells[3].Value.ToString());
                adresa.Street = row.Cells[4].Value.ToString();
                adresa.Number = row.Cells[5].Value.ToString();
                try
                {
                    panel1.Visible = true;
                    initComboBoxes();
                    tbNumar.Text = adresa.Number.ToString();
                    tbStreet.Text = adresa.Street.ToString();
                    oras = bLAddress.GetCityNameById(adresa.Oras.CityId);
                    comboBoxOrase.Text = oras.Rows[0]["CityName"].ToString();
                    judet = bLAddress.GetCountyNameById(adresa.County.CountyId);
                    comboBoxJudete.Text = judet.Rows[0]["CountyName"].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return adresa;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            AddressModel adresaVeche = InitPanel();
            this.partnerAddressId = adresaVeche.PartnerAddressId;
            panel1.Visible = true;
            label1.Text = "Modificare Adresa";
            btnSaveADRS.Visible = false;
            btnSaveEdits.Visible = true;
        }
        private void BtnSaveEdits_Click(object sender, EventArgs e)
        {
            AddressModel adresaNoua = new AddressModel();
            BLAddress bLAddress = new BLAddress();
            try
            {
                string strada = tbStreet.Text;
                adresaNoua.Street = strada;
                string numar = tbNumar.Text;
                adresaNoua.Number = numar;
                adresaNoua.PartnerId = this.partnerId;
                adresaNoua.PartnerAddressId = this.partnerAddressId;
                adresaNoua.County.CountyId = Convert.ToInt32(comboBoxJudete.SelectedValue.ToString());
                adresaNoua.Oras.CityId = Convert.ToInt32(comboBoxOrase.SelectedValue.ToString());
                DialogResult dialogResult = MessageBox.Show("Sigur doriti sa modificati adresa?", "Adresa Client", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bLAddress.UpdateSelectedAddress(adresaNoua, out string error);
                    MessageBox.Show(error, "Status", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    initializareDataGrid(this.partnerId);                    
                    panel1.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
