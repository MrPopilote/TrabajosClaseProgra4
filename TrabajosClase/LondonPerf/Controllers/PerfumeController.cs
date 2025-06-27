using LondonPerf.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LondonPerf.Controllers
{
    public class PerfumeController : Controller
    {
        private Service services;
        public PerfumeController()
        {
            this.services = new Service();
        }
        // GET: PerfumeController
        public ActionResult Index()
        {
            var perfumes = services.mostrarPerfumes();
            return View(perfumes);
        }

        // GET: PerfumeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PerfumeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PerfumeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Perfume perfume)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    services.agregarPerfume(perfume);
                    return RedirectToAction("Index");
                }

            }
            catch
            {

            }
            return View();
        }

        // GET: PerfumeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PerfumeController/Edit/5
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

        // GET: PerfumeController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var perfumeEliminado = services.buscarPerfume(id);
                return View(perfumeEliminado);
                //return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // POST: PerfumeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var perfume = services.buscarPerfume(id);
                services.eliminarPerfume(perfume);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
