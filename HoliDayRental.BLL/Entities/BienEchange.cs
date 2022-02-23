using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class BienEchange
    {
        public int idBien { get; set; }
        private string _titre;
        public string Titre
        {
            get { return _titre; }
            set
            {
                string newTitre = value.Trim();
                if (string.IsNullOrEmpty(newTitre)) throw new ArgumentNullException(nameof(newTitre));
                if (newTitre.Length > 128) throw new ArgumentOutOfRangeException(nameof(newTitre));
                _titre = newTitre;
            }
        }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public int Numero { get; set; }
        public int CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool isEnabled { get; set; }
        public DateTime DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int idMembre { get; set; }
        public DateTime DateCreation { get; set; }

        public BienEchange(int id, string titre, string descCourte, string descLong, int nombrePerson, int pays, string ville, string rue, int numero, int codePostal, string photo, bool assuranceObligatoire, bool IsEnabled, DateTime disabledDate, string latitude, string longitude, int IdMembre, DateTime dateCreation)
        {
            idBien = id;
            Titre = titre;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Ville = ville;
            Rue = rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            isEnabled = IsEnabled;
            DisabledDate = disabledDate;
            Latitude = latitude;
            Longitude = longitude;
            idMembre = IdMembre;
            DateCreation = dateCreation;


        }
        public Membre Membre { get; set; }
    }
}
