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
    public partial class UtilisateursForm : Form
    {
        public HomeAdminForm homeAdminForm;
        public List<Utilisateur> utilisateurs = new List<Utilisateur>();
        public UtilisateurCard[] utilisateurCards;
        public async void AddData()
        {
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            utilisateurs = await fireBaseOperations.GetDataUtilisateur(this);
            usersCardFlowLayoutPanel.AutoScroll = true;
            this.utilisateurCards = new UtilisateurCard[utilisateurs.Count];
            for (int i = 0; i < utilisateurs.Count; i++)
            {
                utilisateurCards[i] = new UtilisateurCard(this, utilisateurs[i]);
                utilisateurCards[i].SetData();
                usersCardFlowLayoutPanel.Controls.Add(utilisateurCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public async void RefreshData()
        {
            this.UseWaitCursor = true;
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            utilisateurs = await fireBaseOperations.GetDataUtilisateur(this);
            usersCardFlowLayoutPanel.Controls.Clear();
            usersCardFlowLayoutPanel.AutoScroll = true;
            this.utilisateurCards = new UtilisateurCard[utilisateurs.Count];
            for (int i = 0; i < utilisateurs.Count; i++)
            {
                utilisateurCards[i] = new UtilisateurCard(this, utilisateurs[i]);
                utilisateurCards[i].SetData();
                usersCardFlowLayoutPanel.Controls.Add(utilisateurCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public UtilisateursForm(HomeAdminForm homeAdminForm)
        {
            InitializeComponent();
            this.UseWaitCursor = true;
            this.homeAdminForm = homeAdminForm;
            AddData();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.homeAdminForm.accueilForm.Visible = true;
            this.homeAdminForm.accueilForm.UseWaitCursor = false;
            //Log out
            this.Dispose();
        }
        private void accueilButton_Click(object sender, EventArgs e)
        {
            this.homeAdminForm.Visible = true;
            this.Dispose();
        }
        private void uniteMButton_Click(object sender, EventArgs e)
        {
            UniteMedicalForm a = new UniteMedicalForm(this.homeAdminForm);
            a.Visible = true;
            this.Dispose();
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            AjoutUtilisateur a = new AjoutUtilisateur(this);
            a.Visible = true;
        }
        private async void rechercheTextBox_TextChanged(object sender, EventArgs e)
        {
            indexLabel.Visible = false;
            if (rechercheComboBox.Text != "")
            {
                this.UseWaitCursor = true;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                utilisateurs  = await fireBaseOperations.GetDataUtilisateur(this, this.rechercheTextBox.Text, this.rechercheComboBox.Text);
                usersCardFlowLayoutPanel.Controls.Clear();
                usersCardFlowLayoutPanel.AutoScroll = true;
                this.utilisateurCards = new UtilisateurCard[utilisateurs.Count];
                for (int i = 0; i < utilisateurs.Count; i++)
                {
                    utilisateurCards[i] = new UtilisateurCard(this, utilisateurs[i]);
                    usersCardFlowLayoutPanel.Controls.Add(utilisateurCards[i]);
                }
                this.UseWaitCursor = false;
            }
            if (rechercheComboBox.Text == "" && rechercheTextBox.Text != "")
            {
                indexLabel.Visible = true;
            }
        }
    }
}
