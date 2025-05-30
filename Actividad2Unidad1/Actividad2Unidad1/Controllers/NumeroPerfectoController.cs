using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        // GET: NumeroPerfectoController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult PerfectoONo(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            ViewBag.Mensaje = (suma == numero) ? "Es perfecto" : "No es perfecto";

            return View();
        }

        // GET: NumeroPerfectoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NumeroPerfectoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NumeroPerfectoController/Create
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

        // GET: NumeroPerfectoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NumeroPerfectoController/Edit/5
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

        // GET: NumeroPerfectoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NumeroPerfectoController/Delete/5
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
