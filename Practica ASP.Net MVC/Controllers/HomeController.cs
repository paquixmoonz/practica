using Microsoft.AspNetCore.Mvc;
using Practica_ASP.Net_MVC.Models;
using System;
using System.Diagnostics;

namespace Practica_ASP.Net_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new negativo()); 
        }

       
        [HttpPost]
        public IActionResult Index(negativo es_negativo)
        {

            if (es_negativo.num < 0)
            {
                es_negativo.result = "El numero es negativo";
            }
            else
            {
                es_negativo.result = "El numero no es negativo";
            }

            return View(es_negativo); 
        }
        
        [HttpGet]
        public IActionResult Ejer4()
        {
            return View(new suma1_100()); 
        }

       
        [HttpPost]
        public IActionResult Ejer4(suma1_100 suma)
        {
           
            for (int i = 0; i <= 100; i++)
            {
                suma.result += i;
            }

            return View(suma); 
        }
        
        [HttpGet]
        public IActionResult Ejer7()
        {
            return View(new ordenarNumeros()); 
        }

       
        [HttpPost]
        public IActionResult Ejer7(ordenarNumeros model)
        {
            int[] numeros = { model.num1, model.num2, model.num3 };

          
            Array.Sort(numeros);

            model.result = $"Los números en orden son: {numeros[0]}, {numeros[1]}, {numeros[2]}";

            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Ejer8()
        {
            return View(new digitos()); 
        }

       
        [HttpPost]
        public IActionResult Ejer8(digitos model)
        {
            

          model.result = Math.Abs(model.num).ToString().Length;
            

            
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Ejer12()
        {
            return View(new potencia()); 
        }

       
        [HttpPost]
        public IActionResult Ejer12(potencia model)
        {


            model.result = Math.Pow(model.baseX, model.potenciaN);



            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
