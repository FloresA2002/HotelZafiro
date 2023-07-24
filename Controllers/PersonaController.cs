using HotelZafiro.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace HotelZafiro.Controllers
{
    public class PersonaController : Controller
    {
        private HotelContext _context;

        public PersonaController(HotelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var persona = _context.Persona.FirstOrDefault();
            return View(persona);
        }

        public IActionResult MultiIndex()
        {
            var listaPersona = _context.Persona.ToList();
            return View("MultiPersona", listaPersona);
        }
    }
}
