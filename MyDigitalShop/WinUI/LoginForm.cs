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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        public static int UserId;
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Utilizator necompletat", "EROARE", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text)){
                MessageBox.Show("Parola necompletata", "EROARE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            BLLogin blLogin = new BLLogin();
            UserModel user = new UserModel();
            user = blLogin.CheckUser(userName, password, out bool status, out string errorMessage);
            
            if (status)//s-a gasit userul
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;
                UserId = user.UserId;
            }
            else
            {
                MessageBox.Show(errorMessage, "EROARE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        public void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Utilizator necompletat", "EROARE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parola necompletata", "EROARE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            BLLogin blLogin = new BLLogin();
            UserModel user = new UserModel();

            blLogin.InsertUser(userName, password, out bool status, out string error);
            if (status)//userul nu s-a inserat
            {
                MessageBox.Show(error, "EROARE", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else//userul s-a inserat
            {
                MessageBox.Show(error, "SUCCES!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;
                return;
            }
        }
    }
}
