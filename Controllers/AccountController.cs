using HotelZafiro.DatosDB;
using HotelZafiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelZafiro.Controllers;

public class AccountController : Controller
{
    private HotelContext _context;

    public AccountController(HotelContext context)
    {
        _context = context;
    }

    [HttpGet]
    //PARA QUE ME MUESTRE EL FORMULARIO
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Index(PersonaModel persona)
    {
        
        if(!String.IsNullOrEmpty(persona.Correo.ToString()) && (!String.IsNullOrEmpty(persona.Clave.ToString())))
        {
            var user = _context.Persona.SingleOrDefault(u =>
                u.Correo == persona.Correo
                &&
                u.Clave == persona.Clave
            );

            if(user != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.AlertMessage = "¡No se encuentra el usuario Ingresado!";
                return View();
            }
        }
        else
        {
            return View();
        }
    }
}

