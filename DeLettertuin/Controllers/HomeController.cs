using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;

namespace DeLettertuin.Controllers
{
    public class HomeController : Controller
    {
        private DeLettertuinContext context = new DeLettertuinContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


	}
}