using HolidayRental.Common.Repositories;
using HoliDayRental.BLL.Entities;
using HoliDayRental.Handlers;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class MembreController : Controller
    {
        private readonly IMembreRepository<Membre> _membreService;
        private readonly IBienEchangeRepository<BienEchange> _bienEchangeService;
        public MembreController(IMembreRepository<Membre> membreService, IBienEchangeRepository<BienEchange> bienEchangeService)
        {
            _membreService = membreService;
            _bienEchangeService = bienEchangeService;

        }

        public IActionResult Index()
        {
            IEnumerable<MembreListItem> model = _membreService.Get().Select(m => m.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            MembreDetails model = _membreService.Get(id).ToDetails();
            model.BienEchange = _bienEchangeService.GetByIdMembre(id).Select(b => b.ToDetails());
            return View(model);
        }
    }
}
