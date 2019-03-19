using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgePreventiveReminder
{
    public partial class UtilisateurCard : UserControl
    {
        public UtilisateursForm utilisateursForm;
        public Utilisateur utilisateur;
        public UtilisateurCard(UtilisateursForm utilisateursForm, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
            this.utilisateursForm = utilisateursForm;
            SetData();
        }
        public void SetData()
        {
            this.emailL.Text = this.utilisateur.email;
            this.pwdL.Text = this.utilisateur.pwd;
            this.posteL.Text = this.utilisateur.poste;
            this.typeL.Text = this.utilisateur.type;
            if (this.utilisateur.uniteMedical == null)
            {
                this.appartientL.Visible = false;
                this.uniteMLabel.Visible = false;
            }
            else
            {
                this.appartientL.Text = this.utilisateur.uniteMedical.nom+" ("+ this.utilisateur.uniteMedical.gouv+")";
            }
            
        }

        private void UtilisateurCard_Click(object sender, EventArgs e)
        {

        }

        private async void SupprimerButton_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            FireBaseOperations a = new FireBaseOperations();
            await a.DeleteDataUtilisateur(this.utilisateur);
            this.UseWaitCursor = false;
            this.utilisateursForm.RefreshData();
        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            AjoutUtilisateur a = new AjoutUtilisateur(this.utilisateursForm, 1, this.utilisateur);
            a.Visible = true;
        }
    }
}
