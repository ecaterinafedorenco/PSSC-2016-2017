using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    //[Authorize] - start with login
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /*Students thePerson = new Students("12");
        public ActionResult Index()
        {
            return View(thePerson);
        }*/

        /*public ActionResult Students()
        {
            ViewBag.Message = "Students situation.";

            return View();
        }*/

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
 