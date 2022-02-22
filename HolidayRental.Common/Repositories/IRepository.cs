using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IRepository<TEntity, TId> : IGetRepository<TEntity, TId>
    {
        TId Insert(TEntity entity);
        void Delete(TId id);
        void Update(TId id, TEntity entity);

    }
}
