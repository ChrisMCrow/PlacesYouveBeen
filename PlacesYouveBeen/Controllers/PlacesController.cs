using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;

namespace PlacesYouveBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        // [HttpPost("/places")]

    }
}
