using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
          List<Place> allPlaces = Place.GetAll();
          return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create()
        {
          Place newPlace = new Place(Request.Form["city"]);
          //set all other form inputs to the object
          newPlace.SetDuration(Request.Form["duration"]);
          newPlace.SetCountry(Request.Form["country"]);
          newPlace.SetActivities(Request.Form["activities"]);
          List<Place> allPlaces = Place.GetAll();
          return View("Index", allPlaces);
        }

        [HttpGet("/places/{id}")]
        public ActionResult Details(int id)
        {
          Place place = Place.Find(id);
          return View(place);
        }
    }
}
