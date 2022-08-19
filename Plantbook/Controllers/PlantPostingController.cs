using Microsoft.AspNetCore.Mvc;
using Plantbook.Models;

namespace Plantbook.Controllers
{
    public class PlantPostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateEditPlantPosting(int id)
        {
            return View();
        }

        public IActionResult CreateEditPlant(PlantPosting plantPosting, IFormFile file)
        {
            if(file != null)
            {
                using ( var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var bytes = ms.ToArray();
                    plantPosting.PlantImage = bytes;
                }
            }
            //TODO: write plantposting to db

            return RedirectToAction("Index");
        }
    }
}
