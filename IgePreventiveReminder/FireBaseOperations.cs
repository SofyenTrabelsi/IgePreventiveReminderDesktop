using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Auth.Payloads;
using System.Windows.Forms;
using Firebase.Database.Query;

namespace IgePreventiveReminder
{
    class FireBaseOperations
    {
        public int pass = 0;
        public AccueilForm accueilForm;
        public FireBaseOperations()
        {

        }
        public async void SignUpNewUser(string email,string password)
        {
            var authOptions = new FirebaseAuthOptions("AIzaSyBguEqhhIDeNMgOGIGGv3sUGAKaQJ2BWq4");

            var firebase = new FirebaseAuthService(authOptions);
            var request = new SignUpNewUserRequest()
            {
                Email = email,
                Password = password
            };

            try
            {
                var response = await firebase.SignUpNewUser(request);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public async void VerifyPassword(string email, string password, AccueilForm accueilForm)
        {
            this.accueilForm = accueilForm;
            var authOptions = new FirebaseAuthOptions("AIzaSyBguEqhhIDeNMgOGIGGv3sUGAKaQJ2BWq4");

            var firebase = new FirebaseAuthService(authOptions);
            var request = new VerifyPasswordRequest()
            {
                Email = email,
                Password = password
            };
            try
            {
                var response = await firebase.VerifyPassword(request);
                HomeAdminForm a = new HomeAdminForm(this.accueilForm)
                {
                    Visible = true
                };
                this.accueilForm.Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
        }
        public async void VerifyPassword(string email, string password, AccueilForm accueilForm,int user)
        {
            var authOptions = new FirebaseAuthOptions("AIzaSyBguEqhhIDeNMgOGIGGv3sUGAKaQJ2BWq4");
            var firebase = new FirebaseAuthService(authOptions);
            var request = new VerifyPasswordRequest()
            {
                Email = email,
                Password = password
            };
            try
            {
                var response = await firebase.VerifyPassword(request);
                Utilisateur utilisateur = new Utilisateur();
                var firebase1 = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase1
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    if (um.Object.email == email && um.Object.pwd == password)
                    {
                        utilisateur = um.Object;
                        break;
                    }
                }
                HomeUserForm a = new HomeUserForm(accueilForm, utilisateur);
                a.Visible = true;
                this.accueilForm.Visible = false;
            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message);
            }
        }
        public async Task<bool> VerifyPassword1(string email, string password)
        {
            bool a = false;
            var authOptions = new FirebaseAuthOptions("AIzaSyBguEqhhIDeNMgOGIGGv3sUGAKaQJ2BWq4");
            var firebase = new FirebaseAuthService(authOptions);
            var request = new VerifyPasswordRequest()
            {
                Email = email,
                Password = password
            };
            try
            {
                var response = await firebase.VerifyPassword(request);
                a = response.Registered;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return a;
        }
        //Unité Medical opérations
        public async Task<bool> AddDataUniteMedical(UniteMedical uniteMedical)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var key = await firebase
                  .Child(uniteMedical.title)
                  .PostAsync(new UniteMedical());
                uniteMedical.key = key.Key;
                await firebase
                  .Child(uniteMedical.title)
                  .Child(uniteMedical.key)
                  .PutAsync(uniteMedical);
                MessageBox.Show("Unité medical ajouté avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<List<UniteMedical>> GetDataUniteMedical(UniteMedicalForm uniteMedicalForm)
        {
            List<UniteMedical> uniteMedicals = new List<UniteMedical>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs=await firebase
                  .Child("Unité Medical")
                  .OnceAsync<UniteMedical>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    uniteMedicals.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            uniteMedicalForm.uniteMedicals =uniteMedicals;
            uniteMedicalForm.Refresh();
            return uniteMedicals;
        }
        public async Task<List<UniteMedical>> GetDataUniteMedical(UniteMedicalForm uniteMedicalForm, string hasText,string textBy)
        {
            List<UniteMedical> uniteMedicals = new List<UniteMedical>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Unité Medical")
                  .OnceAsync<UniteMedical>();
                foreach (var um in uMs)
                {
                    switch (textBy)
                    {
                        case "Type":
                            if (um.Object.type.Contains(hasText))
                            {
                                uniteMedicals.Add(um.Object);
                            }
                            break;
                        case "Nom":
                            if (um.Object.nom.Contains(hasText))
                            {
                                uniteMedicals.Add(um.Object);
                            }
                            break;
                        case "Gouvernorat":
                            if (um.Object.gouv.Contains(hasText))
                            {
                                uniteMedicals.Add(um.Object);
                            }
                            break;
                        case "Ville":
                            if (um.Object.ville.Contains(hasText))
                            {
                                uniteMedicals.Add(um.Object);
                            }
                            break;
                        case "Code Postal":
                            if (um.Object.codePostal.ToString().Contains(hasText))
                            {
                                uniteMedicals.Add(um.Object);
                            }
                            break;
                        case "":
                            uniteMedicals.Add(um.Object);
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            uniteMedicalForm.uniteMedicals = uniteMedicals;
            uniteMedicalForm.Refresh();
            return uniteMedicals;
        }
        public async Task<bool> DeleteDataUniteMedical(UniteMedical uniteMedical)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");

                await firebase
                  .Child(uniteMedical.title)
                  .Child(uniteMedical.key)
                  .DeleteAsync();
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    if (um.Object.uniteMedical.key == uniteMedical.key)
                    {
                        //delete composants
                        await firebase
                            .Child(um.Object.title)
                            .Child(um.Object.key)
                            .DeleteAsync();
                    }
                }

                MessageBox.Show("Unité medical supprimé avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<bool> UpdateDataUniteMedical(UniteMedical uniteMedical)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                await firebase
                  .Child(uniteMedical.title)
                  .Child(uniteMedical.key)
                  .PutAsync(uniteMedical);
                MessageBox.Show("Unité medical modifié avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return true;
        }
        //Utilisateur opérations
        public async Task<bool> AddDataUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var key = await firebase
                  .Child(utilisateur.title)
                  .PostAsync(new UniteMedical());
                utilisateur.key = key.Key;
                await firebase
                  .Child(utilisateur.title)
                  .Child(utilisateur.key)
                  .PutAsync(utilisateur);
                MessageBox.Show("Utilisateur ajouté avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<List<Utilisateur>> GetDataUtilisateur(UtilisateursForm utilisateursForm)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    utilisateurs.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            utilisateursForm.utilisateurs = utilisateurs;
            utilisateursForm.Refresh();
            return utilisateurs;
        }
        public async Task<List<Utilisateur>> GetDataUtilisateur(UtilisateursForm utilisateursForm, string hasText, string textBy)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                foreach (var um in uMs)
                {
                    switch (textBy)
                    {
                        case "E-mail":
                            if (um.Object.email.Contains(hasText))
                            {
                                utilisateurs.Add(um.Object);
                            }
                            break;
                        case "Poste":
                            if (um.Object.poste.Contains(hasText))
                            {
                                utilisateurs.Add(um.Object);
                            }
                            break;
                        case "Type":
                            if (um.Object.type.Contains(hasText))
                            {
                                utilisateurs.Add(um.Object);
                            }
                            break;
                        case "UnitéMedical (Nom)":
                            if (um.Object.uniteMedical != null)
                            {
                                if (um.Object.uniteMedical.nom.Contains(hasText))
                                {
                                    utilisateurs.Add(um.Object);
                                }
                            }
                            if (hasText == "")
                            {
                                utilisateurs.Add(um.Object);
                            }
                            break;
                        case "":
                            utilisateurs.Add(um.Object);
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            utilisateursForm.utilisateurs = utilisateurs;
            utilisateursForm.Refresh();
            return utilisateurs;
        }
        public async Task<List<Utilisateur>> GetDataUtilisateur()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    utilisateurs.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return utilisateurs;
        }
        public async Task<List<UniteMedical>> GetDataUniteMedicalForUsers()
        {
            List<UniteMedical> uniteMedicals = new List<UniteMedical>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Unité Medical")
                  .OnceAsync<UniteMedical>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    uniteMedicals.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return uniteMedicals;
        }
        public async Task<bool> DeleteDataUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");

                await firebase
                  .Child(utilisateur.title)
                  .Child(utilisateur.key)
                  .DeleteAsync();
                MessageBox.Show("utilisateur supprimé avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<bool> UpdateDataUtilisateur(Utilisateur utilisateur)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                await firebase
                  .Child(utilisateur.title)
                  .Child(utilisateur.key)
                  .PutAsync(utilisateur);
                MessageBox.Show("Utilisateur modifié avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return true;
        }
        //Materiel opérations
        public async Task<bool> AddDataComposant(Composant materiel)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var key = await firebase
                  .Child(materiel.title)
                  .PostAsync(new UniteMedical());
                materiel.key = key.Key;
                await firebase
                  .Child(materiel.title)
                  .Child(materiel.key)
                  .PutAsync(materiel);
                MessageBox.Show("Materiel ajouté avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<List<Composant>> GetDataComposant(ComposantsForm composantsForm,UniteMedical uniteMedical)
        {
            List<Composant> materiels = new List<Composant>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    if (um.Object.uniteMedical.key == uniteMedical.key)
                    {
                        materiels.Add(um.Object);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //composantsForm.materiels = materiels;
            composantsForm.Refresh();
            return materiels;
        }
        public async Task<List<Composant>> GetDataComposant(Utilisateur utilisateur)
        {
            List<Composant> materiels = new List<Composant>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var user= await firebase
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach(var u in user)
                {
                    if (u.Object.key == utilisateur.key)
                    {
                        foreach (var um in uMs)
                        {
                            um.Object.key = um.Key;
                            if (u.Object.type == "Utilisateur")
                            {
                                if (u.Object.uniteMedical.key == um.Object.uniteMedical.key)
                                {
                                    materiels.Add(um.Object);
                                }
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return materiels;
        }
        public async Task<List<Composant>> GetDataComposant()
        {
            List<Composant> materiels = new List<Composant>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    materiels.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return materiels;
        }
        public async Task<List<Composant>> GetDataComposant(ComposantsForm composantsForm, string hasText, string textBy)
        {
            List<Composant> composants = new List<Composant>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach (var um in uMs)
                {
                    switch (textBy)
                    {
                        case "Type":
                            if (um.Object.type.Contains(hasText))
                            {
                                composants.Add(um.Object);
                            }
                            break;
                        case "Nom":
                            if (um.Object.nom.Contains(hasText))
                            {
                                composants.Add(um.Object);
                            }
                            break;
                        case "Référence":
                            if (um.Object.reference.Contains(hasText))
                            {
                                composants.Add(um.Object);
                            }
                            break;
                        case "Date de Maintenance (jj/mm/aaaa)":
                            if (um.Object.dateMaintenance.ToShortDateString().Contains(hasText))
                            {
                                composants.Add(um.Object);
                            }
                            break;
                        case "":
                            composants.Add(um.Object);
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            composantsForm.composants = composants;
            composantsForm.Refresh();
            return composants;
        }
        public async Task<List<Composant>> GetDataComposant(HomeUserForm homeUserForm, string hasText, string textBy)
        {
            List<Composant> composants = new List<Composant>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var user = await firebase
                  .Child("Utilisateurs")
                  .OnceAsync<Utilisateur>();
                var uMs = await firebase
                  .Child("Composants")
                  .OnceAsync<Composant>();
                foreach (var u in user)
                {
                    if (u.Object.key == homeUserForm.utilisateur.key)
                    {
                        foreach (var um in uMs)
                        {
                            um.Object.key = um.Key;
                            if (u.Object.type == "Utilisateur")
                            {
                                if (u.Object.uniteMedical.key == um.Object.uniteMedical.key)
                                {
                                    switch (textBy)
                                    {
                                        case "Type":
                                            if (um.Object.type.Contains(hasText))
                                            {
                                                composants.Add(um.Object);
                                            }
                                            break;
                                        case "Nom":
                                            if (um.Object.nom.Contains(hasText))
                                            {
                                                composants.Add(um.Object);
                                            }
                                            break;
                                        case "Référence":
                                            if (um.Object.reference.Contains(hasText))
                                            {
                                                composants.Add(um.Object);
                                            }
                                            break;
                                        case "Date de Maintenance (jj/mm/aaaa)":
                                            if (um.Object.dateMaintenance.ToShortDateString().Contains(hasText))
                                            {
                                                composants.Add(um.Object);
                                            }
                                            break;
                                        case "":
                                            composants.Add(um.Object);
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            homeUserForm.composants = composants;
            homeUserForm.Refresh();
            return composants;
        }
        public async Task<List<UniteMedical>> GetDataUniteMedicalForComposant()
        {
            List<UniteMedical> uniteMedicals = new List<UniteMedical>();
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                var uMs = await firebase
                  .Child("Unité Medical")
                  .OnceAsync<UniteMedical>();
                foreach (var um in uMs)
                {
                    um.Object.key = um.Key;
                    uniteMedicals.Add(um.Object);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return uniteMedicals;
        }
        public async Task<bool> DeleteDataComposant(Composant materiel)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");

                await firebase
                  .Child(materiel.title)
                  .Child(materiel.key)
                  .DeleteAsync();
                MessageBox.Show("Matériel supprimé avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.Substring(52));
            }
            return true;
        }
        public async Task<bool> UpdateDataComposant(Composant materiel)
        {
            try
            {
                var firebase = new FirebaseClient("https://medicalcomposantexpirationdate.firebaseio.com");
                await firebase
                  .Child(materiel.title)
                  .Child(materiel.key)
                  .PutAsync(materiel);
                MessageBox.Show("Matériel modifié avec succés");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return true;
        }
    }
}
