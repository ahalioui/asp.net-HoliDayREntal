using HolidayRental.Common.Repositories;
using HoliDayRental.BLL.Entities;
using HoliDayRental.Handlers;
using HoliDayRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Controllers
{
    public class BienEchangeController : Controller

    {
        private readonly IBienEchangeRepository<BienEchange> _bienEchangeService;
        private readonly IMembreBienEchangeRepository<MembreBienEchange> _membreBienEchangeService;

        public BienEchangeController(IBienEchangeRepository<BienEchange> bienEchangeService, IMembreBienEchangeRepository<MembreBienEchange> membreBienEchangeService)
        {
            _bienEchangeService = bienEchangeService;
            _membreBienEchangeService = membreBienEchangeService;
        }
        
        public ActionResult Index()
        {
            IEnumerable<BienEchangeListItem> model = _bienEchangeService.Get().Select(b => b.ToListItem());
            return View(model);
        }

   
        public ActionResult Details(int id)
        {
            BienEchangeDetails model = _bienEchangeService.Get(id).ToDetails();
            model.BienEchanges = _membreBienEchangeService.GetByBienEchangeid(id).Select(l => l.ToDetails());
            return View(model);
        }

        // GET: BienEchangeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BienEchangeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BienEchangeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BienEchangeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BienEchangeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BienEchangeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
