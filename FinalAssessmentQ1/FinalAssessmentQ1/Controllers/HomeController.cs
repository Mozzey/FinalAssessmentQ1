using FinalAssessmentQ1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalAssessmentQ1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Result(AddNumbersModel model)
        {
            ViewBag.Result = model.NumberOne + model.NumberTwo;
            if (model.NumberOne <= 0 || model.NumberOne > 1000 || model.NumberOne.Equals(null))
            {
                ModelState.AddModelError("NumberOne", "Number must be between 1 and 100");
            }
            if (model.NumberTwo <= 0 || model.NumberTwo > 1000 || model.NumberTwo.Equals(null))
            {
                ModelState.AddModelError("NumberTwo", "Number must be between 1 and 100");
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult About(AddNumbersModel model)
        {
            return RedirectToAction("Result");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}