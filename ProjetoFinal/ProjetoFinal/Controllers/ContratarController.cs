using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Controllers
{
    public class ContratarController : Controller
    {
        // GET: ContratarController
        public ActionResult Index()
        {
            Contratar cardInfo = new Contratar();

            List<Contratar> info = cardInfo.getCardInfo();

            ViewBag.info = info;

            return View();
        }

        // GET: ContratarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContratarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContratarController/Create
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

        // GET: ContratarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContratarController/Edit/5
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

        // GET: ContratarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContratarController/Delete/5
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
