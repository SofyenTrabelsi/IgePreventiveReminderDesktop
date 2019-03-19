using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgePreventiveReminder
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void EmailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "E-mail")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }
        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "E-mail";
                emailTextBox.ForeColor = Color.Gray;
            }
        }
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Mot de passe")
            {
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
            }
        }
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.UseSystemPasswordChar=false;
                passwordTextBox.Text = "Mot de passe";
                passwordTextBox.ForeColor = Color.Gray;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            int a=0,b=0;
            this.UseWaitCursor = true;
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            utilisateurs = await fireBaseOperations.GetDataUtilisateur();
            foreach(Utilisateur u in utilisateurs)
            {
                if (u.email.Equals(this.emailTextBox.Text))
                {
                    if (u.type == "Admin")
                    {
                        a = 1;
                        break;
                    }
                    if (u.type == "Utilisateur")
                    {
                        b = 1;
                        break;
                    }
                }
            }
            FireBaseOperations c = new FireBaseOperations();
            if (a==1)
            {
                c.VerifyPassword(this.emailTextBox.Text, this.passwordTextBox.Text, this);
            }
            else if (b==1)
            {
                c.VerifyPassword(this.emailTextBox.Text, this.passwordTextBox.Text,this,1);
            }
            else
            {
                MessageBox.Show("L'utilisateur n'existe pas!");
            }
            this.UseWaitCursor = false;
        }
    }
}
