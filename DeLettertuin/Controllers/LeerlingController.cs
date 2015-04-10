using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Controllers
{
    public class LeerlingController : Controller
    {
        public List<Leerling> LeerlingenList = new List<Leerling>(); 
        private ILeerlingRepository repos;

        public LeerlingController() { }

        public ActionResult LeerlingenView()
        {
            var model = GetLeerlingen();
            return View(model);
        }

        public LeerlingController(DeLettertuinContext context)
        {
            repos = new LeerlingRepository(context);
        }
        
        public Collection<Leerling> Leerlingen { get; set; }

        public void RemoveLeerling(Leerling leerling)
        {
            repos.Delete(leerling);
        }

        public Uitlening GetLeerling()
        {
            throw new System.NotImplementedException();
        }

        public List<Leerling> GetLeerlingen()
        {
            return LeerlingenList;

        }

        public void AddLeerling(Leerling leerling, DateTime tot, Item item)
        {
            throw new System.NotImplementedException();
        }

        public Leerling GeefLeningAanLeerling(Leerling leerling, Uitlening uitlening)
        {
            throw new System.NotImplementedException();
        }
	}
}