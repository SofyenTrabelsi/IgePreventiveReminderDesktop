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
    public partial class ComposantsForm : Form
    {
        public UniteMedicalForm uniteMedicalForm;
        public UniteMedical uniteMedical;
        public List<Composant> composants = new List<Composant>();
        public ComposantCard[] composantCards;
        public async void AddData()
        {
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            composants = await fireBaseOperations.GetDataComposant(this,this.uniteMedical);
            composantsCardFlowLayoutPanel.AutoScroll = true;
            this.composantCards = new ComposantCard[composants.Count];
            for (int i = 0; i < composants.Count; i++)
            {
                composantCards[i] = new ComposantCard(this, composants[i],this.uniteMedical);
                composantCards[i].SetData();
                composantsCardFlowLayoutPanel.Controls.Add(composantCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public async void RefreshData()
        {
            this.UseWaitCursor = true;
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            composants = await fireBaseOperations.GetDataComposant(this,this.uniteMedical);
            composantsCardFlowLayoutPanel.Controls.Clear();
            composantsCardFlowLayoutPanel.AutoScroll = true;
            this.composantCards = new ComposantCard[composants.Count];
            for (int i = 0; i < composants.Count; i++)
            {
                composantCards[i] = new ComposantCard(this, composants[i],this.uniteMedical);
                composantCards[i].SetData();
                composantsCardFlowLayoutPanel.Controls.Add(composantCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public ComposantsForm(UniteMedicalForm uniteMedicalForm,UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.UseWaitCursor = true;
            this.uniteMedicalForm = uniteMedicalForm;
            this.uniteMedical = uniteMedical;
            AddData();
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.uniteMedicalForm.Visible = true;
            this.uniteMedicalForm.uMCardFlowLayoutPanel.Dispose();
            this.uniteMedicalForm.RefreshData();
            this.Dispose();
        }
        private void AccueilButton_Click(object sender, EventArgs e)
        {
            this.uniteMedicalForm.homeAdminForm.Visible = true;
            this.Dispose();
        }
        private void UniteMButton_Click(object sender, EventArgs e)
        {
            this.uniteMedicalForm.Visible = true;
            this.Dispose();
        }
        private void UsersButton_Click(object sender, EventArgs e)
        {
            UtilisateursForm a = new UtilisateursForm(this.uniteMedicalForm.homeAdminForm)
            {
                Visible = true
            };
            this.Dispose();
        }
        private void AddComposantButton_Click(object sender, EventArgs e)
        {
            AjoutComposant a = new AjoutComposant(this,this.uniteMedical);
            a.Visible = true;
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.uniteMedicalForm.homeAdminForm.accueilForm.Visible = true;
            this.uniteMedicalForm.homeAdminForm.accueilForm.UseWaitCursor = false;
            //Log out
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
                    composantCards[i] = new ComposantCard(this, composants[i],this.uniteMedical);
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
