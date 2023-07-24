using HotelZafiro.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace HotelZafiro.Controllers
{
    public class ProductoController : Controller
    {
        private HotelContext _context;

        public ProductoController(HotelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var producto = _context.Producto.FirstOrDefault();
            return View(producto);
        }

        public IActionResult MultiIndex()
        {
            var ListaProducto = _context.Producto.ToList();
            return View("MultiProducto", ListaProducto);
        }
    }
}
