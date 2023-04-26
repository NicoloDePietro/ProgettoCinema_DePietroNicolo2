using Microsoft.AspNetCore.Mvc;

namespace ProgettoCinema_DePietroNicolò2.Controllers
{
    public class UtenteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
