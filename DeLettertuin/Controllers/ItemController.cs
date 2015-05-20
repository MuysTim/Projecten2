using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;
using DeLettertuin.Models.ViewModel;

namespace DeLettertuin.Controllers
{
    public class ItemController : Controller
    {
        public List<Item> Items = new List<Item>();
        public static DeLettertuinContext Context = new DeLettertuinContext();
        private ItemViewModel vm;

        public ActionResult ItemView()
        {
            return View();
        }

	}
}