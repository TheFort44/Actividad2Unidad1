using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        // GET: EvaluacionController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Calificaciones(double nota1, double nota2, double nota3, double nota4)
        {
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            string resultado = "";

            switch (promedio)
            {
                case double p when p >= 70:
                    resultado = "Aprobado";
                    break;

                case double p when p >= 60:
                    resultado = "En recuperación";
                    break;

                default:
                    resultado = "Reprobado";
                    break;
            }

            ViewBag.Promedio = promedio;
            ViewBag.Resultado = resultado;

            return View();
        }

        // GET: EvaluacionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EvaluacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EvaluacionController/Create
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

        // GET: EvaluacionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EvaluacionController/Edit/5
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

        // GET: EvaluacionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EvaluacionController/Delete/5
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
