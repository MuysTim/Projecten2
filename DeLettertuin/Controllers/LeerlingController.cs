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
        private ILenerRepository repos;

        public LeerlingController(DeLettertuinContext context)
        {
            repos = new LenerRepository(context);
        }
        
        public Collection<Lener> Leners { get; set; }

        public void EditLener(Lener lener)
        {

        }

        public void RemoveLener(Lener lener)
        {
            repos.Delete(lener);
        }

        public Uitlening GetLener()
        {
            throw new System.NotImplementedException();
        }

        public Collection<Lener> GetLeners()
        {
            throw new System.NotImplementedException();
        }

        public void AddLener(Lener leerling, DateTime tot, Item item)
        {
            throw new System.NotImplementedException();
        }

        public Lener GeefLeningAanLener(Lener lener, Uitlening uitlening)
        {
            throw new System.NotImplementedException();
        }
	}
}