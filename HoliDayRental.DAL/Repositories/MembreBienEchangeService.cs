using HolidayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public class MembreBienEchangeService : ServiceBase, IMembreBienEchangeRepository<MembreBienEchange>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MembreBienEchange> Get(DateTime dateDebut)
        {
            throw new NotImplementedException();
        }

        public MembreBienEchange Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MembreBienEchange> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MembreBienEchange> GetByBienEchangeid(int bienEchange_id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TBienEchange> GetByIdMembre(int Id_membre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MembreBienEchange> GetByMemberId(int membre_id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MembreBienEchange entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, MembreBienEchange entity)
        {
            throw new NotImplementedException();
        }
    }
}
