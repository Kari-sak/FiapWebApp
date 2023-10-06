using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.App.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index(string nome, string sobrenome)
        {
            ViewData["chave"] = "Cadastro de Cliente";
            ViewBag.titulo = "Cadastro Cliente";
            TempData["mensagem"] = "Cadastrado com Sucesso!";

            //exercício
            ViewData["nome"] = nome;
            ViewData["sobrenome"] = sobrenome;

            return View();
            //return Content("Olá mundo!");
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
