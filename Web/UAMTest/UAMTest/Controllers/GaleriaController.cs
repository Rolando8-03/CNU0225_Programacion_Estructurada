using Microsoft.AspNetCore.Mvc;

namespace UAMTest.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
