using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index(string variable1, string variable2)
        {

            return View();
        }

        public IActionResult ControladorVista()
        {
            //Enviar informacion simple a la vista
            ViewData["Nombre"] = "Alejandro";
            ViewData["Edad"] = 22;
            ViewBag.DiaSemana = "Lunes";

            return View();
        }
        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alejandro";
            persona.Email = "alejandro@email.com";
            persona.Edad = 22;
            return View(persona);
        }
        public IActionResult VistaControllerGet(string saludo, int? year) 
        {
            
            if (saludo != null && year != null)
            {
                ViewData["DATA"] = "Hola " + saludo + ", año:" + year;
            }
            else if (saludo == null && year == null) 
            {
                ViewData["DATA"] = "No se envianingun parametro";
            }
            else if (saludo == null)
            {
                ViewData["DATA"] = "No se envia el parametro de saludo";
            }
            else 
            {
                ViewData["DATA"] = "No se envia el parametro year";
            }

            return View();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult VistaControllerPost(string cajanombre,string cajaemail,int cajaedad)
        {
            ViewData["DATA"] = "Nombre: " + cajanombre + " Email: " + cajaemail + " Edad: " + cajaedad;
            
            return View(); 
        }
    }
}
