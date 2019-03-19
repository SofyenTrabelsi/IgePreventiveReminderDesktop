using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgePreventiveReminder
{
    public class UniteMedical
    {
        public string key;
        public string title;
        public string type;
        public string nom;
        public string gouv;
        public string ville;
        public int codePostal;
        public UniteMedical()
        {

        }
        public UniteMedical(string key,string title, string type, string nom,string gouv,string ville,int codePostal)
        {
            this.key = key;
            this.title = title;
            this.type = type;
            this.nom = nom;
            this.gouv = gouv;
            this.ville = ville;
            this.codePostal = codePostal;
        }
        public UniteMedical(string title, string type, string nom, string gouv, string ville, int codePostal)
        {
            this.title = title;
            this.type = type;
            this.nom = nom;
            this.gouv = gouv;
            this.ville = ville;
            this.codePostal = codePostal;
        }
    }
}
