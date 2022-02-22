﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayRental.Common.Repositories
{
    public interface IGetRepository<TEntity, TId>
    {
        TEntity Get(TId id);
        IEnumerable<TEntity> Get();
    }
}
