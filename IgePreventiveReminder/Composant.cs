using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgePreventiveReminder
{
    public class Composant
    {
        public string key;
        public string title;
        public string type;
        public string nom;
        public string reference;
        public DateTime dateMaintenance;
        public UniteMedical uniteMedical;
        public Composant()
        {

        }
        public Composant(string key, string title, string type, string nom, string reference, DateTime dateMaintenance, UniteMedical uniteMedical)
        {
            this.key = key;
            this.title = title;
            this.type = type;
            this.nom = nom;
            this.reference = reference;
            this.dateMaintenance = dateMaintenance;
            this.uniteMedical = uniteMedical;
        }
        public Composant(string title, string type, string nom, string reference, DateTime dateMaintenance, UniteMedical uniteMedical)
        {
            this.title = title;
            this.type = type;
            this.nom = nom;
            this.reference = reference;
            this.dateMaintenance = dateMaintenance;
            this.uniteMedical = uniteMedical;
        }
    }
}
