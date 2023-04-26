using Microsoft.AspNetCore.Mvc;
using ProgettoCinema_DePietroNicolò2.Data;
using ProgettoCinema_DePietroNicolò2.Models;

namespace ProgettoCinema_DePietroNicolò2.Controllers
{
    public class UtenteController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UtenteController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET
        public IActionResult Index()
        {
            IEnumerable<Utente> objCategoryList = _db.Utenti;
            return View(objCategoryList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
    }

}

