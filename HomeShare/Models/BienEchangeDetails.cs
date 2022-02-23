using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class BienEchangeDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idBien { get; set; }
        public string titre { get; set; }
        [DisplayName("Descrition Courte")]
        [DataType("text")]
        public string DescCourte { get; set; }
        [DisplayName("Descrition Longue")]
        [DataType("text")]
        public string DescLong { get; set; }
        [DisplayName("Nombre de personne")]
        [DataType("number")]
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public int Numero { get; set; }
        [DisplayName("Code Postal")]
        [DataType("number")]
        public int CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool isEnabled { get; set; }
        public DateTime DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int idMembre { get; set; }
        [DisplayName("Date de creation")]
        [DataType("datetime-local")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}")]
        public DateTime DateCreation { get; set; }

    }
}
