using Microsoft.AspNetCore.Mvc;
using BienFritoWebApp.Models;
using BienFritoWebApp.Datos;

namespace BienFritoWebApp.Controllers
{
    public class ProductosController : Controller
    {

        private readonly AppDbContext _db;

        public ProductosController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Producto> lista = _db.Productos;
            return View(lista);
        }
    }
}