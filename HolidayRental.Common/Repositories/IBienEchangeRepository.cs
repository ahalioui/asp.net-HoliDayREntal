using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IBienEchangeRepository<TBienEchange> : IRepository<TBienEchange, int> 
    {
        public new IEnumerable<TBienEchange> GetByIdMembre(int Id_membre);
    }
}
