using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgePreventiveReminder
{
    public class Utilisateur
    {
        public string key;
        public string title;
        public string email;
        public string pwd;
        public string poste;
        public string type;
        public UniteMedical uniteMedical;
        public Utilisateur()
        {

        }
        public Utilisateur(string key,string title,string email,string pwd,string poste,string type,UniteMedical uniteMedical)
        {
            this.key = key;
            this.title = title;
            this.email = email;
            this.pwd = pwd;
            this.poste = poste;
            this.type = type;
            this.uniteMedical = uniteMedical;
        }
        public Utilisateur(string title, string email, string pwd, string poste, string type, UniteMedical uniteMedical)
        {
            this.title = title;
            this.email = email;
            this.pwd = pwd;
            this.poste = poste;
            this.type = type;
            this.uniteMedical = uniteMedical;
        }
    }
}
