using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, int>, IGetByMembreBienEchangeRepository<TMembre>
    {
        IEnumerable<TMembre> GetByMembreBienEchange(int id_bienEchange);
        IEnumerable<TMembre> GetByBienEchange(int id_bienEchange);
    }
}
