using HolidayRental.Common.Repositories;
using HoliDayRental.BLL.Entities;
using HoliDayRental.BLL.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.BLL.Services
{
    public class BienEchangeService : IBienEchangeRepository<BienEchange>
    {
        private readonly IBienEchangeRepository<DAL.Entities.BienEchange> _bienEchangeRepository;
        public BienEchangeService(IBienEchangeRepository<DAL.Entities.BienEchange> repository)
        {
            _bienEchangeRepository = repository;
        }

        public void Delete(int id)
        {
            _bienEchangeRepository.Delete(id);
        }

        public BienEchange Get(int id)
        {
            return _bienEchangeRepository.Get(id).ToBLL();
        }

        public IEnumerable<BienEchange> Get()
        {
            return _bienEchangeRepository.Get().Select(b => b.ToBLL());
        }

        public IEnumerable<BienEchange> GetByIdMembre(int Id_membre)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<BienEchange> GetByBienEchangeid(int bienEchange_id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<BienEchange> GetByPays(int pays_id)
        //{
        //    return _bienEchangeRepository.GetByPays(pays_id).Select(b => b.ToBLL());
        //}

        public int Insert(BienEchange entity)
        {
            return _bienEchangeRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, BienEchange entity)
        {
            _bienEchangeRepository.Update(id, entity.ToDAL());
        }

        IEnumerable<TBienEchange> IRepository<BienEchange, int>.GetByIdMembre(int Id_membre)
        {
            throw new NotImplementedException();
        }
    }
}
