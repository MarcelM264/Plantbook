using Microsoft.AspNetCore.Mvc;

namespace Plantbook.Controllers
{
    public class PlantPostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateEditPlant(int id)
        {
            return View();
        }
    }
}
