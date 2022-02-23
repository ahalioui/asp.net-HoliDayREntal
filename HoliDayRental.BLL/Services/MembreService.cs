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
    public class MembreService : IMembreRepository<Membre>
    {
        private readonly IMembreRepository<DAL.Entities.Membre> _membreRepository;
        public MembreService(IMembreRepository<DAL.Entities.Membre> repository)
        {
            _membreRepository = repository;
        }
        public void Delete(int id)
        {
            _membreRepository.Delete(id);
        }

        public Membre Get(int id)
        {
            return _membreRepository.Get(id).ToBLL();
        }

        public IEnumerable<Membre> Get()
        {
            return _membreRepository.Get().Select(m => m.ToBLL());
        }

        public IEnumerable<Membre> GetByBienEchange(int id_bienEchange)
        {
            return _membreRepository.GetByBienEchange(id_bienEchange).Select(m => m.ToBLL());
        }

        public IEnumerable<Membre> GetByMembreBienEchange(int id_bienEchange)
        {
            throw new NotImplementedException();
        }

        public Membre GetByMembreBienEnchange(int bienEchangeId)
        {
            throw new NotImplementedException();
        }

        public int Insert(Membre entity)
        {
            return _membreRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Membre entity)
        {
            _membreRepository.Update(id, entity.ToDAL());
        }
    }
}
