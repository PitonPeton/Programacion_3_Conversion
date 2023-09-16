using Microsoft.AspNetCore.Mvc;
using Programacion_3_Conversion.Models;

namespace Programacion_3_Conversion.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MonedaViewModel value)
        {

            ViewData["message"] = ConversionViewModel.Convert(value).ToString();
            return View(value);
        }
    }
}
