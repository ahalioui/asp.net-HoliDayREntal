using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IMembreBienEchangeRepository<TMembreBienEchange> : IRepository<TMembreBienEchange, int>

    {
        public IEnumerable<TMembreBienEchange> Get(DateTime dateDebut);
        public IEnumerable<TMembreBienEchange> GetByMemberId(int membre_id);
        public IEnumerable<TMembreBienEchange> GetByBienEchangeid(int bienEchange_id);



    }
}
