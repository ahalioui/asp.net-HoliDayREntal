using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class BienEchangeCreateForm
    {
        [Required]
        [DisplayName("Tire")]
        public string titre { get; set; }
        [Required]
        [DisplayName("Description Courte")]
        public string DescCourte { get; set; }
        [Required]
        [DisplayName("Description complète")]
        public string DescLong { get; set; }
        [Required]
        [DisplayName("Nombre de personne")]
        public int NombrePerson { get; set; }
        [Required]
        [DisplayName("Pays")]
        public int Pays { get; set; }
        [Required]
        [DisplayName("Ville")]
        public string Ville { get; set; }
        [Required]
        [DisplayName("Rue")]
        public string Rue { get; set; }
        [Required]
        [DisplayName("Numéro")]
        public string Numero { get; set; }
        [Required]
        [DisplayName("Code Postal")]
        public string CodePostal { get; set; }
        [Required]
        [DisplayName("Photo")]
        public string Photo { get; set; }
        [Required]
        [DisplayName("Latitude")]
        public string Latitude { get; set; }
        [Required]
        [DisplayName("Longitude")]
        public string Longitude { get; set; }



        
    }
}

