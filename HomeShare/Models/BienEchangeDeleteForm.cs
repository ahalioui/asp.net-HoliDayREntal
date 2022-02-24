using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class BienEchangeDeleteForm
    {
        [Required]
        [DisplayName("Tire")]
        public string titre { get; set; }
        [Required]
        [DisplayName("Description Courte")]
        public string DescCourte { get; set; }
        [Required]
        [DisplayName("Pays")]
        public int Pays { get; set; }
        [Required]
        [DisplayName("Ville")]
        public string Ville { get; set; }
        [Required]
        [DisplayName("Êtes-vous sûr de vouloir supprimer ce bien")]
        public bool Validate { get; set; }


    }
}
