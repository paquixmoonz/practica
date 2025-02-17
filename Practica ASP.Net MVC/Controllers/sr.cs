using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class sr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult multiplicacion(operacion model)
        {
            model.result = model.num1 * model.num2;
            return View(model);
        }
        [HttpPost]
        public IActionResult division(operacion model)
        {
            model.result = model.num1 / model.num2;
            return View(model);
        }
    }
}
