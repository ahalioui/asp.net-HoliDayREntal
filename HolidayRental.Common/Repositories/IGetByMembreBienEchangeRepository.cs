using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IGetByMembreBienEchangeRepository<TEntity>
    {
        public TEntity GetByMembreBienEnchange(int bienEchangeId);
    }
}
