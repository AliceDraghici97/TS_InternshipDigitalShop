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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            ClientsForm clienti = new ClientsForm();
            clienti.Show();
            this.Hide();
        }

        private void BtnFacturi_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            InvoicesForm facturi = new InvoicesForm();
            facturi.Show();
            this.Hide();
        }

        private void BtnArticole_Click(object sender, EventArgs e)
        {
            ItemsForm articole = new ItemsForm();
            articole.Show();
            this.Hide();
        }
    }
}
