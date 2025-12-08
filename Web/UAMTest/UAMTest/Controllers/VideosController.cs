using Microsoft.AspNetCore.Mvc;

namespace UAMTest.Controllers
{
    public class VideosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
