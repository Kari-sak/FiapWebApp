using Fiap.Web.App.Data;
using Fiap.Web.App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.App.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly LojaContext _context;
        public ProdutoController(LojaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            Produto produto = new Produto()
            {
                Nome = "Falar para liderar",
                Descricao = "Qualquer descrição aqui",
                Valor = 39,
                Estado = Estado.SP,
                Importado = false
            };
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return View();
        }
    }
}
