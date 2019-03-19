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
    public partial class AjoutUtilisateur : Form
    {
        public int? i = null;
        public UtilisateursForm utilisateursForm;
        public Utilisateur utilisateur;
        public string[] uniteMNom;
        public List<UniteMedical> uniteMedicals = new List<UniteMedical>();
        public void SetInputs()
        {
            emailTextBox.Text = this.utilisateur.email;
            posteTextBox.Text = this.utilisateur.poste;
            if (this.utilisateur.type == "Admin")
                adminRadioButton.Checked=true;
            if (this.utilisateur.type == "Utilisateur")
                userRadioButton.Checked=true;
        }
        public Utilisateur GetInputs()
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.title = "Utilisateurs";
            utilisateur.email = emailTextBox.Text;
            utilisateur.pwd = pwdTextBox.Text;
            utilisateur.poste = posteTextBox.Text;
            if(adminRadioButton.Checked)
                utilisateur.type = "Admin";
            if (userRadioButton.Checked)
            {
                utilisateur.type = "Utilisateur";
                utilisateur.uniteMedical = uniteMedicals[uniteMComboBox.SelectedIndex];
            }
            return utilisateur;
        }
        public async void GetData()
        {
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            uniteMedicals = await fireBaseOperations.GetDataUniteMedicalForUsers();
            uniteMNom = new string[uniteMedicals.Count];
            for (int i = 0; i < uniteMedicals.Count; i++)
            {
                uniteMNom[i] = uniteMedicals[i].nom +" ("+ uniteMedicals[i].gouv+")";
        }
            uniteMComboBox.Items.AddRange(uniteMNom);
        }
        public AjoutUtilisateur(UtilisateursForm utilisateursForm)
        {
            InitializeComponent();
            this.utilisateursForm = utilisateursForm;
        }
        public AjoutUtilisateur(UtilisateursForm utilisateursForm, int i, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.i = i;
            titleLabel.Text = "Modification Utilisateur";
            this.utilisateur = utilisateur;
            this.utilisateursForm = utilisateursForm;
            SetInputs();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void confirmerButton_Click(object sender, EventArgs e)
        {
            if (i == null)
            {
                Utilisateur utilisateur = GetInputs();
                this.UseWaitCursor = true;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                fireBaseOperations.SignUpNewUser(utilisateur.email, utilisateur.pwd);
                await fireBaseOperations.AddDataUtilisateur(utilisateur);
                this.UseWaitCursor = false;
                this.utilisateursForm.RefreshData();
                this.Dispose();
            }
            else if (i == 1)
            {
                Utilisateur utilisateur = GetInputs();
                this.UseWaitCursor = true;
                utilisateur.key = this.utilisateur.key;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                bool a = await fireBaseOperations.VerifyPassword1(utilisateur.email, utilisateur.pwd);
                if (a)
                {
                    await fireBaseOperations.UpdateDataUtilisateur(utilisateur);
                    this.UseWaitCursor = false;
                    this.utilisateursForm.RefreshData();
                    this.Dispose();
                }
                else
                {
                    fireBaseOperations.SignUpNewUser(utilisateur.email, utilisateur.pwd);
                    await fireBaseOperations.UpdateDataUtilisateur(utilisateur);
                    this.UseWaitCursor = false;
                    this.utilisateursForm.RefreshData();
                    this.Dispose();
                }
            }
        }
        private void adminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (adminRadioButton.Checked)
            {
                uniteMLabel.Visible = false;
                uniteMComboBox.Visible = false;
            }
        }
        private void userRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userRadioButton.Checked)
            {
                GetData();
                uniteMLabel.Visible = true;
                uniteMComboBox.Visible = true;
            }
        }
    }
}
