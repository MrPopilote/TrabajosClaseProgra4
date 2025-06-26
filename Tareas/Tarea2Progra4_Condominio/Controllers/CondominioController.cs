using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea2Progra4_Condominio.Models;

namespace Tarea2Progra4_Condominio.Controllers
{
    public class CondominioController : Controller
    {
        private Service services;
        public CondominioController() { 
            this.services = new Service(); //conexion con services
        }

        // GET: CondominioController
        public ActionResult Index()
        {
            var condominios = services.mostrarCondominios();
            return View(condominios);
        }

        // GET: CondominioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CondominioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CondominioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Condominio condominio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    services.agregarCondominio(condominio);
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
          
            }
            return View();
        }

        // GET: CondominioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CondominioController/Edit/5
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

        // GET: CondominioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CondominioController/Delete/5
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
