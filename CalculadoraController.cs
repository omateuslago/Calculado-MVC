using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: mostra o formulário vazio
        public IActionResult Index()
        {
            return View(new CalculadoraModel());
        }

        // POST: processa os números enviados
        [HttpPost]
        public IActionResult Index(double numero1, double numero2)
            {

            var model = new CalculadoraModel
            {
                Numero1 = numero1,
                Numero2 = numero2,
                Resultado = numero1 + numero2
            };

            return View(model);
        }
    }
}
