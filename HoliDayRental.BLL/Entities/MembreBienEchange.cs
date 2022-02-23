using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Entities
{
    public class MembreBienEchange
    {
        public int idMembre { get; set; }
        public int idBien { get; set; }
        public DateTime DateDebEchange { get; set; }
        public DateTime DateFinEchange { get; set; }
        public bool Assurance { get; set; }
        public bool Valide { get; set; }
        public Membre Membre { get; set; }
        public BienEchange BienEchange { get; set; }

        public MembreBienEchange(int IdMembre, int IdBien, DateTime dateDebEchange, DateTime dateFinEchange, bool assurance, bool valide)
        {
            idMembre = IdMembre;
            idBien = IdBien;
            DateDebEchange = dateDebEchange;
            DateFinEchange = dateFinEchange;
            Assurance = assurance;
            Valide = valide;


        }

    }
}
