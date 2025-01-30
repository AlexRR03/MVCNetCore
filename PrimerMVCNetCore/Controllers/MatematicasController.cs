using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VistaMatematicasGet(int num1,int num2) {
            ViewData["SUMA"] = num1+num2;
            return View();  
        }
        
        public IActionResult VistaMatematicasPost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VistaMatematicasPost(int num1,int num2)
        {
            ViewData["SUMA"] = num1 + num2;
            return View();
        }

        public IActionResult VistaConjeturaCollatz()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VistaConjeturaCollatz(int numero)
        {
            List<int> listaNumeros = new List<int>();
            while (numero != 1) 
            {
                if(numero %2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                listaNumeros.Add(numero);
                
            }
            return View(listaNumeros);
        }
        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            
            List<int> tabla = new List<int>();
            for (int i = 1; i<=10; i++)
            {
                int resultado = i * numero;
                tabla.Add(resultado);
            }

            return View(tabla);
        }
        public IActionResult TablaMultiplicarModel() {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> filas = new List<FilaTablaMultiplicar>();

            for (int i = 1; i <=10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion= i+" x "+numero+ " = ";
                fila.Resultado = i*numero;
                filas.Add(fila);
            }
            return View(filas);
        }
    }
}
