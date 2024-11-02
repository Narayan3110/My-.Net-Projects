using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodOrderSys_ModelView_.Models;

namespace FoodOrderSys_ModelView_.Controllers
{
    public class HomeController : Controller
    {
        static List<FoodForm>order = new List<FoodForm>();
        // GET: Home
        public ActionResult Index()

        {
            ViewBag.Message = "Zomato";
            FoodForm foodForm = new FoodForm ();
            ViewBag.FoodForm = order;
            return View();
        }
        [HttpPost]
        public ActionResult Index(FoodForm foodForm)
        {
            if(!ModelState.IsValid)
             ViewBag.FoodForm = order;
            return View();
            order.Add(foodForm);


            return View("Thanks",foodForm);

        }

    }
}