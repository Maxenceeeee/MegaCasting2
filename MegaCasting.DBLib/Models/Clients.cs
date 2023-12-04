using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.DBLib.Models
{
    internal class Clients
    {
        #region Attributes

        private int _id;

        private string _nomEntreprise;

        private string _adresseEntreprise;

        private string _ville;

        private int _codePostal;

        private int _numeroTelephone;

        private string _adresseMail;

        private int _sirenEntreprise;

        private int _siretEntreprise;

        #endregion

        #region Properties 

        public int Id { get => _id; set => _id = value; }
        public string NomEntreprise { get => _nomEntreprise; set => _nomEntreprise = value; }
        public string AdresseEntreprise { get => _adresseEntreprise; set => _adresseEntreprise = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int CodePostal { get => _codePostal; set => _codePostal = value; }
        public int NumeroTelephone { get => _numeroTelephone; set => _numeroTelephone = value; }
        public string AdresseMail { get => _adresseMail; set => _adresseMail = value; }
        public int SirenEntreprise { get => _sirenEntreprise; set => _sirenEntreprise = value; }
        public int SiretEntreprise { get => _siretEntreprise; set => _siretEntreprise = value; }

        #endregion


    }
}
