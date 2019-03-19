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
    public partial class HomeAdminForm : Form
    {
        public AccueilForm accueilForm;
        public List<Composant> composants;
        public void ShowNotification(string composantName,string composantRef, string composantLocation, int diff,int type)
        {
            notifyIcon1.Text = "Vous avez un notification";
            switch (type)
            {
                case 1:
                    notifyIcon1.BalloonTipText = "Il y a encore " + diff + " jours pour maintenir ' " + composantName + " ' de Référence ' " + composantRef + " 'à ' "+ composantLocation + " '";
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipTitle = "Information";
                    break;
                case 2:
                    notifyIcon1.BalloonTipText = "Aujourd'hui il faut maintenir ' " + composantName + " ' de Référence ' " + composantRef + " ' à ' " + composantLocation + " '";
                    notifyIcon1.Icon = SystemIcons.Warning;
                    notifyIcon1.BalloonTipTitle = "Attention";
                    break;
                case 3:
                    notifyIcon1.BalloonTipText = "Il y a " + diff + " jours passé sans maintenir ' " + composantName + " ' de Référence ' " + composantRef + " ' à ' " + composantLocation + " '";
                    notifyIcon1.Icon = SystemIcons.Error;
                    notifyIcon1.BalloonTipTitle = "Erreur";
                    break;
            }
            notifyIcon1.ShowBalloonTip(2000);
        }
        public async void GetNotifications()
        {
            this.composants = new List<Composant>();
            FireBaseOperations fireBaseOperations = new FireBaseOperations();
            List<Composant> composants = await fireBaseOperations.GetDataComposant();
            DateTime now = DateTime.Now;
            foreach(Composant c in composants)
            {
                int diff = (c.dateMaintenance - now).Days;
                if (diff<4)
                {
                    if (diff>0)
                    {
                        ShowNotification(c.nom, c.reference, c.uniteMedical.nom + " (" + c.uniteMedical.gouv + " , " + c.uniteMedical.ville + ")", diff,1);
                    }
                    if (diff == 0)
                    {
                        ShowNotification(c.nom, c.reference, c.uniteMedical.nom + " (" + c.uniteMedical.gouv + " , " + c.uniteMedical.ville + ")", diff, 2);
                    }
                    if (diff < 0)
                    {
                        ShowNotification(c.nom, c.reference, c.uniteMedical.nom + " (" + c.uniteMedical.gouv + " , " + c.uniteMedical.ville + ")", Math.Abs(diff), 3);
                    }
                    this.composants.Add(c);
                }
            }
        }
        public HomeAdminForm(AccueilForm accueilForm)
        {
            InitializeComponent();
            this.accueilForm = accueilForm;
            //GetNotifications();
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.accueilForm.Visible = true;
            this.accueilForm.UseWaitCursor = false;
            this.Dispose();
        }
        private void accueilButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void uMButton_Click(object sender, EventArgs e)
        {
            UniteMedicalForm a = new UniteMedicalForm(this);
            a.Visible = true;
            this.Visible = false;
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            UtilisateursForm a = new UtilisateursForm(this);
            a.Visible = true;
            this.Visible = false;
        }
        private void uniteMButton_Click(object sender, EventArgs e)
        {
            UniteMedicalForm a = new UniteMedicalForm(this);
            a.Visible = true;
            this.Visible = false;
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            UtilisateursForm a = new UtilisateursForm(this);
            a.Visible = true;
            this.Visible = false;
        }
    }
}
