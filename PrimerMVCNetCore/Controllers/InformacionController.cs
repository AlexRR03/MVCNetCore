using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult VistaControllerPost(string nombre,string email,int edad)
        //{
        //    ViewData["DATA"] = "Nombre: " + nombre + " Email: " + email + " Edad: " + edad;

        //    return View(); 
        //}
        public IActionResult VistaControllerPost(Persona persona,string aficiones) 
        {
            ViewData["DATA"] = "Nombre: " + persona.Nombre+ " Email: " + persona.Email + " Edad: " + persona.Edad +"\n y sus afiones son: "+ aficiones;

            return View();
        }
    }
}
