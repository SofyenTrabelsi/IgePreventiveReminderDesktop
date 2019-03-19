using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgePreventiveReminder
{
    public partial class UniteMedicalForm : Form
    {
        public HomeAdminForm homeAdminForm;
        public List<UniteMedical> uniteMedicals=new List<UniteMedical>();
        public UniteMedicalCard[] uniteMedicalCards;
        public async void AddData()
        {
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            uniteMedicals = await fireBaseOperations.GetDataUniteMedical(this);
            uMCardFlowLayoutPanel.AutoScroll = true;
            this.uniteMedicalCards = new UniteMedicalCard[uniteMedicals.Count];
            for (int i = 0; i < uniteMedicals.Count; i++)
            {
                uniteMedicalCards[i] = new UniteMedicalCard(this, uniteMedicals[i]);
                uMCardFlowLayoutPanel.Controls.Add(uniteMedicalCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public async void RefreshData()
        {
            this.UseWaitCursor = true;
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            uniteMedicals = await fireBaseOperations.GetDataUniteMedical(this);
            uMCardFlowLayoutPanel.Controls.Clear();
            uMCardFlowLayoutPanel.AutoScroll = true;
            this.uniteMedicalCards = new UniteMedicalCard[uniteMedicals.Count];
            for (int i = 0; i < uniteMedicals.Count; i++)
            {
                uniteMedicalCards[i] = new UniteMedicalCard(this, uniteMedicals[i]);
                uMCardFlowLayoutPanel.Controls.Add(uniteMedicalCards[i]);
            }
            this.UseWaitCursor = false;
        }
        public UniteMedicalForm(HomeAdminForm homeAdminForm)
        {
            InitializeComponent();
            this.UseWaitCursor = true;
            this.homeAdminForm = homeAdminForm;
            AddData();
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.homeAdminForm.accueilForm.Visible = true;
            this.homeAdminForm.accueilForm.UseWaitCursor = false;
            //Log out
            this.Dispose();
        }
        private void AccueilButton_Click(object sender, EventArgs e)
        {
            this.homeAdminForm.Visible = true;
            this.Dispose();
        }
        private void UniteMButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void UsersButton_Click(object sender, EventArgs e)
        {
            UtilisateursForm a = new UtilisateursForm(this.homeAdminForm)
            {
                Visible = true
            };
            this.Dispose();
        }
        private void AddUMButton_Click(object sender, EventArgs e)
        {
            AjoutUniteMedical a = new AjoutUniteMedical(this)
            {
                Visible = true
            };
        }
        private async void RechercheTextBox_TextChanged(object sender, EventArgs e)
        {
            indexLabel.Visible = false;
            if (rechercherComboBox.Text != "")
            {
                this.UseWaitCursor = true;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                uniteMedicals = await fireBaseOperations.GetDataUniteMedical(this, this.rechercheTextBox.Text, this.rechercherComboBox.Text);
                uMCardFlowLayoutPanel.Controls.Clear();
                uMCardFlowLayoutPanel.AutoScroll = true;
                this.uniteMedicalCards = new UniteMedicalCard[uniteMedicals.Count];
                for (int i = 0; i < uniteMedicals.Count; i++)
                {
                    uniteMedicalCards[i] = new UniteMedicalCard(this, uniteMedicals[i]);
                    uMCardFlowLayoutPanel.Controls.Add(uniteMedicalCards[i]);
                }
                this.UseWaitCursor = false;
            }
            if(rechercherComboBox.Text == "" && rechercheTextBox.Text!="")
            {
                indexLabel.Visible = true;
            }
        }
    }
}