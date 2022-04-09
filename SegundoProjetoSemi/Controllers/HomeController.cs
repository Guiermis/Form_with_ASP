using Microsoft.AspNetCore.Mvc;
using SegundoProjetoSemi.Models;
using System.Diagnostics;

namespace SegundoProjetoSemi.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        public IActionResult SalvarResposta(Resposta r)
        {
            if (ModelState.IsValid)
            {
                Repositorio.respostas.Add(r);

                return View("Index");
            }
            else
            {
                return View("Formulario", r);
            }
        }

        public IActionResult Listar()
        {
            return View(Repositorio.respostas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}