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
    public partial class AjoutComposant : Form
    {
        public int? i = null;
        public HomeUserForm homeUserForm;
        public ComposantsForm composantsForm;
        public Composant composant;
        public UniteMedical uniteMedical;
        public void SetInputs()
        {
            typeTextBox.Text = this.composant.type;
            nomTextBox.Text = this.composant.nom;
            refTextBox.Text = this.composant.reference;
            dateMTimePicker.Text = this.composant.dateMaintenance.ToShortDateString();
        }
        public Composant GetInputs()
        {
            Composant composant = new Composant();
            composant.title = "Composants";
            composant.type = typeTextBox.Text;
            composant.nom =nomTextBox.Text;
            composant.reference = refTextBox.Text;
            composant.dateMaintenance = dateMTimePicker.Value;
            composant.uniteMedical = this.uniteMedical;
            return composant;
        }
        public AjoutComposant(ComposantsForm composantsForm,UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.composantsForm = composantsForm;
            this.uniteMedical = uniteMedical;
        }
        public AjoutComposant(HomeUserForm homeUserForm, UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.homeUserForm = homeUserForm;
            this.uniteMedical = uniteMedical;
        }
        public AjoutComposant(HomeUserForm homeUserForm,int i, Composant composant, UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.homeUserForm = homeUserForm;
            this.i = i;
            this.composant = composant;
            this.uniteMedical = uniteMedical;
            titleLabel.Text = "Modification Composant";
            SetInputs();
        }
        public AjoutComposant(ComposantsForm composantsForm, int i, Composant composant,UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.i = i;
            titleLabel.Text = "Modification Composant";
            this.composant = composant;
            this.composantsForm = composantsForm;
            this.uniteMedical = uniteMedical;
            SetInputs();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void confirmerButton_Click(object sender, EventArgs e)
        {
            if (homeUserForm != null)
            {
                if (i == null)
                {
                    Composant composant = GetInputs();
                    this.UseWaitCursor = true;
                    FireBaseOperations fireBaseOperations = new FireBaseOperations();
                    await fireBaseOperations.AddDataComposant(composant);
                    this.UseWaitCursor = false;
                    this.homeUserForm.RefreshData();
                    this.Dispose();
                }
                else if (i == 1)
                {
                    Composant composant = GetInputs();
                    this.UseWaitCursor = true;
                    composant.key = this.composant.key;
                    FireBaseOperations fireBaseOperations = new FireBaseOperations();
                    await fireBaseOperations.UpdateDataComposant(composant);
                    this.UseWaitCursor = false;
                    this.homeUserForm.RefreshData();
                    this.Dispose();
                }
            }
            else
            {
                if (i == null)
                {
                    Composant composant = GetInputs();
                    this.UseWaitCursor = true;
                    FireBaseOperations fireBaseOperations = new FireBaseOperations();
                    await fireBaseOperations.AddDataComposant(composant);
                    this.UseWaitCursor = false;
                    this.composantsForm.RefreshData();
                    this.Dispose();
                }
                else if (i == 1)
                {
                    Composant composant = GetInputs();
                    this.UseWaitCursor = true;
                    composant.key = this.composant.key;
                    FireBaseOperations fireBaseOperations = new FireBaseOperations();
                    await fireBaseOperations.UpdateDataComposant(composant);
                    this.UseWaitCursor = false;
                    this.composantsForm.RefreshData();
                    this.Dispose();
                }
            }
        }
    }
}
