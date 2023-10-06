using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.App.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
