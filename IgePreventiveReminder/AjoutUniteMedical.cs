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
    public partial class AjoutUniteMedical : Form
    {
        public int? i = null;
        public string[] gouvs= { "Ariana", "Béja", "Ben Arous", "Bizerte",
                                "Gabès", "Gafsa", "Jendouba", "Kairouan",
                                "Kasserine", "Kébili", "Le Kef", "Mahdia",
                                "La Manouba","Médenine", "Monastir", "Nabeul",
                                "Sfax","Sidi Bouzid", "Siliana", "Sousse",
                                "Tataouine","Tozeur", "Tunis", "Zaghouan" };
        public string[] Ariana = {"Raoued","Sidi Thabet","Ariana Ville","La Soukra","Kalaat Landlous","Ettadhamen","Mnihla" };
        public string[] Béja = {"Beja Nord","Nefza","Goubellat","Mjez El Beb","Amdoun","Teboursouk","Testour","Thibar","Beja Sud" };
        public string[] Ben_Arous = { "Ezzahra","Mhamadia","Rades","El mourouj","Fouchana","Hammam Chatt","Hammam Lif","Megrine","Nouvelle Medina","Mornag","Boumhel El Bassatine","Ben Arous" };
        public string[] Bizerte = {"Menzel Bourguiba","Utique","Menzel Jemil","Bizerte Nord","Bizerte Sud","El Alia","Sejnane","Ghar El Melh","Ghezala", "Jarzouna", "Joumine","Mateur","Ras Jebel","Tinja" };
        public string[] Gabès = { "El Metouia","Gabes Medina","Gabes Ouest","Gebes Sud","El Hamma","Nouvelle Matmata","Mareth","Ghannouche","Matmata","Menzel Habib" };
        public string[] Gafsa = {"Belkhir","El Guettar","El Ksar","El Mdhila","Sned","Moulares","Redeyef","Sidi Aich","Gafsa Sud","Metlaoui","Gafsa Nord" };
        public string[] Jendouba = { "Fernana","Ghardimaou","Tabarka","Jendouba","Jendouba Nord","Ain Draham","Oued Mliz","Bou Salem","Balta Bou Aouene" };
        public string[] Kairouan = { "Sbikha","Kairouan Sud","Ouselatia","Nasrallah","Kairouan Nord","El Ala","Hajeb El Ayoun","Chbika","Haffouz","Cherarda","Bou Hajla" };
        public string[] Kasserine = {"El Ayoun","Ezzouhour","Fériana","Foussana","Haïdra","Hassi El Ferid","Jedelienne","Kasserine Nord","Kasserine Sud","Majel Bel Abbès","Sbeïtla","Sbiba","Thala" };
        public string[] Kébili = { "Douz Nord","Douz Sud","Faouar","Kébili Nord","Kébili Sud","Souk Lahad"};
        public string[] Le_Kef = { "Dahmani","Jérissa","El Ksour","Sers","Kalâat Khasba","Kalaat Senan","Kef Est","Kef Ouest","Nebeur","Sakiet Sidi Youssef","Tajerouine"};
        public string[] Mahdia = { "Bou Merdes","Chebba","Chorbane","El Jem","Essouassi","Hebira","Ksour Essef","Mahdia","Melloulèche","Ouled Chamekh","Sidi Alouane"};
        public string[] La_Manouba = {"Borj El Amri","Djedeida","Douar Hicher","El Batan","La Manouba","Mornaguia","Oued Ellil","Tebourba" };
        public string[] Médenine = {"Ben Gardane","Beni Khedache","Djerba - Ajim","Djerba - Houmt Souk","Djerba - Midoun","Médenine Nord","Médenine Sud","Sidi Makhlouf","Zarzis" };
        public string[] Monastir = {"Bekalta","Bembla","Beni Hassen","Jemmal","Ksar Hellal","Ksibet el-Médiouni","Moknine","Monastir","Ouerdanine","Sahline","Sayada-Lamta-Bou Hajar","Téboulba","Zéramdine" };
        public string[] Nabeul = { "Béni Khalled","Béni Khiar","Bou Argoub","Dar Chaâbane El Fehri","El Haouaria","El Mida","Grombalia","Hammam Ghezèze","Hammamet","Kélibia","Korba","Menzel Bouzelfa","Menzel Temime","Soliman"};
        public string[] Sfax = {"Agareb","Bir Ali Ben Khalifa","El Amra","El Hencha","Graïba","Jebiniana","Kerkennah","Mahrès","Menzel Chaker","Sakiet Eddaïer","Sakiet Ezzit","Sfax Ouest","Sfax Sud","Sfax Ville","Skhira","Thyna" };
        public string[] Sidi_Bouzid = {"Bir El Hafey","Cebbala Ouled Asker","Jilma","Meknassy","Menzel Bouzaiane","Mezzouna","Ouled Haffouz","Regueb","Sidi Ali Ben Aoun","Sidi Bouzid Est","Sidi Bouzid Ouest","Souk Jedid" };
        public string[] Siliana = {"Bargou","Bou Arada","El Aroussa","El Krib","Gaâfour","Kesra","Makthar","Rouhia","Sidi Bou Rouis","Siliana Nord","Siliana Sud" };
        public string[] Sousse = {"Akouda","Bouficha","Enfida","Hammam Sousse","Hergla","Kalâa Kebira","Kalâa Seghira","Kondar","M'saken","Sidi Bou Ali","Sidi El Hani","Sousse Jawhara","Sousse Médina","Sousse Riadh","Sousse Sidi Abdelhamid" };
        public string[] Tataouine = { "Bir Lahmar","Dehiba","Ghomrassen","Remada","Smâr","Tataouine Nord","Tataouine Sud"};
        public string[] Tozeur = {"Degache","Hazoua","Nefta","Tameghza","Tozeur" };
        public string[] Tunis = { "Bab El Bhar","Bab Souika","Carthage","Cité El Khadra","Djebel Jelloud","El Kabaria","El Menzah","El Omrane","El Omrane supérieur","El Ouardia","Ettahrir","Ezzouhour","Hraïria","La Goulette","La Marsa","Le Bardo","Le Kram","Médina","Séjoumi","Sidi El Béchir","Sidi Hassine"};
        public string[] Zaghouan = {"Bir Mcherga","El Fahs","Nadhour","Saouaf","Zaghouan","Zriba" };
        public UniteMedicalForm uniteMedicalForm;
        public UniteMedical uniteMedical;
        public void SetInputs()
        {
            typeTextBox.Text = this.uniteMedical.type;
            nomTextBox.Text = this.uniteMedical.nom;
            //gouvernoratComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            //villeComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            gouvernoratComboBox.Text = this.uniteMedical.gouv;
            villeComboBox.Text = this.uniteMedical.ville;
            codePostalTextBox.Text = this.uniteMedical.codePostal.ToString();
        }
        public UniteMedical GetInputs()
        {
            UniteMedical uniteMedical = new UniteMedical();
            uniteMedical.title = "Unité Medical";
            uniteMedical.type = typeTextBox.Text;
            uniteMedical.nom = nomTextBox.Text;
            uniteMedical.gouv = gouvernoratComboBox.Text;
            uniteMedical.ville = villeComboBox.Text;
            uniteMedical.codePostal = int.Parse(codePostalTextBox.Text);
            return uniteMedical;
        }
        public AjoutUniteMedical(UniteMedicalForm uniteMedicalForm)
        {
            InitializeComponent();
            this.uniteMedicalForm = uniteMedicalForm;
            gouvernoratComboBox.Items.AddRange(this.gouvs);
        }
        public AjoutUniteMedical(UniteMedicalForm uniteMedicalForm,int i,UniteMedical uniteMedical)
        {
            InitializeComponent();
            this.i = i;
            titleLabel.Text = "Modification Unité Medical";
            this.uniteMedical = uniteMedical;
            this.uniteMedicalForm = uniteMedicalForm;
            SetInputs();
            gouvernoratComboBox.Items.AddRange(this.gouvs);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void gouvernoratComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gouvernoratComboBox.SelectedItem.ToString() == "Ariana")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Ariana);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Béja")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Béja);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Ben Arous")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Ben_Arous);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Bizerte")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Bizerte);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Gabès")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Gabès);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Gafsa")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Gafsa);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Jendouba")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Jendouba);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Kairouan")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Kairouan);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Kasserine")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Kasserine);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Kébili")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Kébili);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Le Kef")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Le_Kef);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Mahdia")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Mahdia);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "La Manouba")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.La_Manouba);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Médenine")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Médenine);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Monastir")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Monastir);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Nabeul")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Nabeul);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Sfax")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Sfax);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Sidi Bouzid")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Sidi_Bouzid);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Siliana")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Siliana);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Sousse")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Sousse);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Tataouine")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Tataouine);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Tozeur")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Tozeur);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Tunis")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Tunis);
            }
            if (gouvernoratComboBox.SelectedItem.ToString() == "Zaghouan")
            {
                villeComboBox.Items.Clear();
                villeComboBox.Items.AddRange(this.Zaghouan);
            }
        }
        private async void confirmerButton_Click(object sender, EventArgs e)
        {
            if (i == null)
            {
                UniteMedical uniteMedical = GetInputs();
                this.UseWaitCursor = true;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                await fireBaseOperations.AddDataUniteMedical(uniteMedical);
                this.UseWaitCursor = false;
                this.uniteMedicalForm.RefreshData();
                this.Dispose();
            }
            else if (i == 1)
            {
                UniteMedical uniteMedical = GetInputs();
                this.UseWaitCursor = true;
                uniteMedical.key = this.uniteMedical.key;
                FireBaseOperations fireBaseOperations = new FireBaseOperations();
                await fireBaseOperations.UpdateDataUniteMedical(uniteMedical);
                this.UseWaitCursor = false;
                this.uniteMedicalForm.RefreshData();
                this.Dispose();
            }
        }
    }
}
