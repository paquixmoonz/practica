using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    public class md : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult sumar(operacion model)
        {
            model.result=model.num1+model.num2;
            return View(model);
        }
        [HttpPost]
        public IActionResult restar(operacion model)
        {
            model.result = model.num1 - model.num2;
            return View(model);
        }
       
    }
}
