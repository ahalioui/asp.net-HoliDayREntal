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
       

        public BienEchangeController(IBienEchangeRepository<BienEchange> bienEchangeService)
        {
            _bienEchangeService = bienEchangeService;
            
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
            BienEchangeEditForm model = _bienEchangeService.Get(id).ToEditForm();
            return View();
        }

        // POST: BienEchangeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BienEchangeEditForm entity)

        {
            BienEchange result = _bienEchangeService.Get(id);

            try
            {
                if (result is null) throw new Exception("Pas de Bien avec cette identifiant");
                if (!(ModelState.IsValid)) throw new Exception();//test de validation

                result.Titre = entity.titre;
                result.DescCourte = entity.DescCourte;
                result.DescLong = entity.DescLong;
                result.NombrePerson = entity.NombrePerson;
                result.Pays = entity.Pays;
                result.Ville = entity.Ville;
                result.Rue = entity.Rue;
                result.Numero = entity.Numero;
                result.CodePostal = entity.CodePostal;
                result.Photo = entity.Photo;
                result.AssuranceObligatoire = entity.AssuranceObligatoire;
                result.isEnabled = entity.isEnabled;
                result.Latitude = entity.Latitude;
                result.Longitude = entity.Longitude;
                result.idMembre = entity.idMembre;
                result.DateCreation = entity.DateCreation;
                _bienEchangeService.Update(id, result);
                return RedirectToAction(nameof(Index));//Mise à jour du bien 
            }
            catch(Exception e)
            {
                ViewBag.Error = e.Message;
                if (result is null) return RedirectToAction(nameof(Index));
                return View(result.ToEditForm());
            }
        }

        // GET: BienEchangeController/Delete/5
        public ActionResult Delete(int id)
        {

            BienEchangeDeleteForm model = _bienEchangeService.Get(id).ToDeleteForm();
            return View(model);
        }

        // POST: BienEchangeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, BienEchangeDeleteForm collection)
        {
            BienEchange result = _bienEchangeService.Get(id);
            try
            {
                if (result is null) throw new Exception("Pas de bien avec cet identifiant");
                if (!ModelState.IsValid) throw new Exception();
                if (!collection.Validate) throw new Exception("Cetteaction n'est pas valide");
                _bienEchangeService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
