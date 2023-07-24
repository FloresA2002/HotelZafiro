using HotelZafiro.DatosDB;
using Microsoft.AspNetCore.Mvc;

namespace HotelZafiro.Controllers
{
    public class TipoPersonaController : Controller
    {
        private HotelContext _context;

        public TipoPersonaController(HotelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var TipoPersonaModel = _context.Tipo.FirstOrDefault();
            return View(TipoPersonaModel);
        }

        public IActionResult MultiIndex()
        {
            var ListaTipoPersona = _context.Tipo.ToList();
            return View("MultiTipoPersonas",ListaTipoPersona);
        }
    }
}
