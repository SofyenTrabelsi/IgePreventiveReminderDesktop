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
    public partial class ComposantCard : UserControl
    {
        public ComposantsForm composantsForm;
        public HomeUserForm homeUserForm;
        public Composant composant;
        public UniteMedical uniteMedical;
        public ComposantCard(ComposantsForm composantsForm,Composant composant, UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.composantsForm = composantsForm;
            this.composant = composant;
            this.uniteMedical = uniteMedical;
            SetData();
        }
        public ComposantCard(Composant composant)
        {
            InitializeComponent();
            this.composant = composant;
            SetData();
        }
        public ComposantCard(HomeUserForm homeUserForm, Composant composant, UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.homeUserForm = homeUserForm;
            this.composant = composant;
            this.uniteMedical = uniteMedical;
            SetData();
        }
        public void SetData()
        {
            this.typeL.Text = this.composant.type;
            this.nomL.Text = this.composant.nom;
            this.refL.Text = this.composant.reference;
            this.dateML.Text= this.composant.dateMaintenance.ToShortDateString();
        }
        private async void SupprimerButton_Click(object sender, EventArgs e)
        {
            if (this.homeUserForm != null)
            {
                this.UseWaitCursor = true;
                FireBaseOperations a = new FireBaseOperations();
                await a.DeleteDataComposant(this.composant);
                this.UseWaitCursor = false;
                this.homeUserForm.RefreshData();
            }
            else
            {
                this.UseWaitCursor = true;
                FireBaseOperations a = new FireBaseOperations();
                await a.DeleteDataComposant(this.composant);
                this.UseWaitCursor = false;
                this.composantsForm.RefreshData();
            }
        }
        private void ModifierButton_Click(object sender, EventArgs e)
        {
            if (homeUserForm != null)
            {
                AjoutComposant a = new AjoutComposant(this.homeUserForm, 1, this.composant, this.uniteMedical);
                a.Visible = true;
            }
            else
            {
                AjoutComposant a = new AjoutComposant(this.composantsForm, 1, this.composant, this.uniteMedical);
                a.Visible = true;
            }
        }
    }
}
