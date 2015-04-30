using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;
using DeLettertuin.ViewModels;

namespace DeLettertuin.Controllers
{
    public class LeerlingController : Controller
    {
        public IEnumerable<Leerling> LeerlingenList = new List<Leerling>(); 
        private ILeerlingRepository leerlingRepository;

        public LeerlingController() { }
        public LeerlingController(ILeerlingRepository leerlingRepository)
        {
            this.leerlingRepository = leerlingRepository;
        }

        public ActionResult LeerlingenView()
        {
            IEnumerable<Leerling> leerlingen = leerlingRepository.FindAll().OrderBy(l => l.Naam);
            IEnumerable<LeerlingIndexViewModel> vms =
                leerlingen.Select(l => new LeerlingIndexViewModel(l)).ToList();
            return View(vms);

        }

        public LeerlingController(DeLettertuinContext context)
        {
            leerlingRepository = new LeerlingRepository(context);
        }
        
        public Collection<Leerling> Leerlingen { get; set; }

        public void RemoveLeerling(Leerling leerling)
        {
            leerlingRepository.Delete(leerling);
        }

        public Uitlening GetLeerling()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Leerling> GetLeerlingen()
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