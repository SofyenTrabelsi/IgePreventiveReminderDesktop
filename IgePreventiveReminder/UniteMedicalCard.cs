using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IgePreventiveReminder
{
    public partial class UniteMedicalCard : UserControl
    {
        public UniteMedicalForm uniteMedicalForm;
        public UniteMedical uniteMedical;
        public UniteMedicalCard(UniteMedicalForm uniteMedicalForm, UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.uniteMedical = uniteMedical;
            this.uniteMedicalForm = uniteMedicalForm;
            SetData();
        }
        public void SetData()
        {
            this.typeL.Text = this.uniteMedical.type;
            this.nomL.Text = this.uniteMedical.nom;
            this.adresseL.Text = this.uniteMedical.gouv+" "+ this.uniteMedical.ville + " "+this.uniteMedical.codePostal;
        }

        private void UniteMedicalCard_Click(object sender, EventArgs e)
        {
            ComposantsForm a= new ComposantsForm(this.uniteMedicalForm,this.uniteMedical);
            a.Visible = true;
            this.uniteMedicalForm.Visible = true;
        }

        private async void SupprimerButton_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            FireBaseOperations a = new FireBaseOperations();
            await a.DeleteDataUniteMedical(this.uniteMedical);
            this.UseWaitCursor = false;
            this.uniteMedicalForm.RefreshData();
        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            AjoutUniteMedical a = new AjoutUniteMedical(this.uniteMedicalForm, 1,this.uniteMedical);
            a.Visible = true;
        }
    }
}
