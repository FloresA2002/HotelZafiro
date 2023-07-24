using HotelZafiro.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace HotelZafiro.Controllers
{
    public class Habitacion : Controller
    {
        private HotelContext _context;

        public Habitacion(HotelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var habitacion = _context.Habitacion.FirstOrDefault();
            return View(habitacion);
        }

        public IActionResult MultiIndex()
        {
            var ListaHabitacion = _context.Habitacion.ToList();
            return View("MultiHabitacion", ListaHabitacion);
        }
    }
}
