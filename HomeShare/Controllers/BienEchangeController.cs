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
        
        public ActionResult Index(bool? sorted)
        {
            IEnumerable<BienEchangeListItem> model = _bienEchangeService.Get().Select(b => b.ToListItem());
            if(!(sorted is null) && sorted == true)
            {
                model = model.OrderBy(e => e.Pays);
            }
            return View(model);
        }

   
        public ActionResult Details(int id)
        {
            BienEchangeDetails model = _bienEchangeService.Get(id).ToDetails();
            model.BienEchanges = _bienEchangeService.GetByPays(id).Select(l => l.ToDetails());
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
        public ActionResult Create(BienEchangeCreateForm collection)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception();
                BienEchange result = new BienEchange()
                {
                    idBien = 0,
                    Titre = collection.titre,
                    DescCourte = collection.DescCourte,
                    DescLong = collection.DescLong,
                    NombrePerson = collection.NombrePerson,
                    Pays = collection.Pays,
                    Ville = collection.Ville,
                    Rue = collection.Rue,
                    Numero = collection.Numero,
                    CodePostal = collection.CodePostal,
                    Photo = collection.Photo,
                    Latitude = collection.Latitude,
                    Longitude = collection.Longitude,
                    AssuranceObligatoire = true,
                    isEnabled=false,
                    DisabledDate=null,
                    idMembre=0,
                    DateCreation=DateTime.Now





                };
                this._bienEchangeService.Insert(result);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View(collection);
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
