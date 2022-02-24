using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Entities
{
    public class BienEchange
    {
        public int idBien { get; set; }
        public string titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool isEnabled { get; set; }

        private DateTime? disabledDate;

        public DateTime? GetDisabledDate()
        {
            return disabledDate;
        }

        public void SetDisabledDate(DateTime? value)
        {
            disabledDate = value;
        }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int idMembre { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DisabledDate { get; internal set; }
    }
}
