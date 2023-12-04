using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.Wpf.Models
{
    internal class Offre
    {
        #region Attributes

        private int _id;

        private string _intitulé;

        private int _reference;

        private string _domaineMetier;

        private string _metier;

        private string _typeContrat;

        private DateTime _dateDebutPublication;

        private int _duréeDiffusion;

        private DateTime _dateDebutContrat;

        private int _nombrePoste;

        private string _localisation;

        private string _descriptionPoste;

        private string _descriptionProfil;

        private string _coordonnees;

        #endregion

        #region Properties

        public int Id { get => _id; set => _id = value; }
        public string Intitulé { get => _intitulé; set => _intitulé = value; }
        public int Reference { get => _reference; set => _reference = value; }
        public string DomaineMetier { get => _domaineMetier; set => _domaineMetier = value; }
        public string Metier { get => _metier; set => _metier = value; }
        public string TypeContrat { get => _typeContrat; set => _typeContrat = value; }
        public DateTime DateDebutPublication { get => _dateDebutPublication; set => _dateDebutPublication = value; }
        public int DuréeDiffusion { get => _duréeDiffusion; set => _duréeDiffusion = value; }
        public DateTime DateDebutContrat { get => _dateDebutContrat; set => _dateDebutContrat = value; }
        public int NombrePoste { get => _nombrePoste; set => _nombrePoste = value; }
        public string Localisation { get => _localisation; set => _localisation = value; }
        public string DescriptionPoste { get => _descriptionPoste; set => _descriptionPoste = value; }
        public string DescriptionProfil { get => _descriptionProfil; set => _descriptionProfil = value; }
        public string Coordonnees { get => _coordonnees; set => _coordonnees = value; }

        #endregion


    }
}
