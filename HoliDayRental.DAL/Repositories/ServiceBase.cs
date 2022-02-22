using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public abstract class ServiceBase
    {
        protected string _connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = HolyDayRental; Integrated Security = True";

    }
}
