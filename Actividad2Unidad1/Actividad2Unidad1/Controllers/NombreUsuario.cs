using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NombreUsuario : Controller
    {
        // GET: NombreUsuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: NombreUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Usuario(String nombre)
        {
            ViewBag.Mensaje = $"Hola, {nombre}, bienvenido a ASP.NET MVC.";
            return View();
        }

        // GET: NombreUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NombreUsuario/Create
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

        // GET: NombreUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NombreUsuario/Edit/5
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

        // GET: NombreUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NombreUsuario/Delete/5
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
