using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: CalculadraController
        public ActionResult Index()
        {
            return View();
        }


        public IActionResult Calcular(double numero1, double numero2, string operacion)
        {
            double resultado = 0;
            string mensaje;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero2 != 0 ? numero1 / numero2 : double.NaN;
                    break;
                default:
                    mensaje = "Operación no válida.";
                    ViewBag.Mensaje = mensaje;
                    return View();
            }
            mensaje = $"El resultado de {numero1} {operacion} {numero2} es: {resultado}";
            ViewBag.Mensaje = mensaje;

            return View();
        }

        // GET: CalculadraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CalculadraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculadraController/Create
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

        // GET: CalculadraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculadraController/Edit/5
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

        // GET: CalculadraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculadraController/Delete/5
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
