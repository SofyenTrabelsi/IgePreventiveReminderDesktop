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
    public partial class HomeUserForm : Form
    {
        public List<Composant> composants = new List<Composant>();
        public Utilisateur utilisateur;
        public ComposantCard[] composantCards;
        public AccueilForm accueilForm;
        public async void AddData()
        {
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            composants = await fireBaseOperations.GetDataComposant(this.utilisateur);
            composantsCardFlowLayoutPanel.AutoScroll = true;
            this.composantCards = new ComposantCard[composants.Count];
            for (int i = 0; i < composants.Count; i++)
            {
                composantCards[i] = new ComposantCard(this, composants[i], this.utilisateur.uniteMedical);
                composantCards[i].SetData();
                composantsCardFlowLayoutPanel.Controls.Add(composantCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public async void RefreshData()
        {
            this.UseWaitCursor = true;
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            composants = await fireBaseOperations.GetDataComposant(this.utilisateur);
            composantsCardFlowLayoutPanel.Controls.Clear();
            composantsCardFlowLayoutPanel.AutoScroll = true;
            this.composantCards = new ComposantCard[composants.Count];
            for (int i = 0; i < composants.Count; i++)
            {
                composantCards[i] = new ComposantCard(this, composants[i], this.utilisateur.uniteMedical);
                composantCards[i].SetData();
                composantsCardFlowLayoutPanel.Controls.Add(composantCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public HomeUserForm(AccueilForm accueilForm, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.UseWaitCursor = true;
            this.accueilForm = accueilForm;
            this.utilisateur = utilisateur;
            AddData();
        }
        private void AddComposantButton_Click(object sender, EventArgs e)
        {
            AjoutComposant a = new AjoutComposant(this,this.utilisateur.uniteMedical);
            a.Visible = true;
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.accueilForm.Visible = true;
            this.Dispose();
        }
        private async void rechercheTextBox_TextChanged(object sender, EventArgs e)
        {
            indexLabel.Visible = false;
            if (rechercheComboBox.Text != "")
            {
                this.UseWaitCursor = true;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                composants = await fireBaseOperations.GetDataComposant(this, this.rechercheTextBox.Text, this.rechercheComboBox.Text);
                composantsCardFlowLayoutPanel.Controls.Clear();
                composantsCardFlowLayoutPanel.AutoScroll = true;
                this.composantCards = new ComposantCard[composants.Count];
                for (int i = 0; i < composants.Count; i++)
                {
                    composantCards[i] = new ComposantCard(composants[i]);
                    composantsCardFlowLayoutPanel.Controls.Add(composantCards[i]);
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
