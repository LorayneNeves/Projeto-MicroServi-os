using Microsoft.AspNetCore.Mvc;

namespace Vendas.API.Controllers
{
    public class VandaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
