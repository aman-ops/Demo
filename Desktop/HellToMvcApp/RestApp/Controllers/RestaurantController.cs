using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestApp.Controllers
{
    public class RestaurantController : Controller
    {
        RestaurantRepositoty db = new RestaurantRepositoty();
        // GET: Restaurant
        public ActionResult Index()
        {
            var res = db.GetAllRestaurant();
            return View(res);
        }
        public ActionResult Details(int x)
        {
            var res = db.GetRestaurantById(x);
            return View(res);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add( FormCollection fc )
        {
            Restaurant rest = new Restaurant() { Id = int.Parse( fc["Id"]), Title = fc["Title"], City = fc["City"], Rating = int.Parse( fc["Rating"]) };
            if (ModelState.IsValid)
            {
                db.AddRestaurant(rest);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var res = db.GetRestaurantById(id);
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(int id, Restaurant rest)
        {
            db.EditRestaurant(id,rest);
            return RedirectToAction("index");
        }
    }
}