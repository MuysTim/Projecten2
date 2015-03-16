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
    public class UitleningController : Controller
    {
        private IUitleningenRepository repos;

        public UitleningController(DeLettertuinContext context)
        {
            repos = new UitleningRepository(context);
        }
        
        public Collection<Uitlening> Uitleningen { get; set; }

        public void EditUitlening(Uitlening uitlening)
        {

        }

        public void RemoveUitlening(Uitlening uitlening)
        {
            repos.Delete(uitlening);
        }

        public Uitlening GetUitlening()
        {
            throw new System.NotImplementedException();
        }

        public Collection<Uitlening> GetUitleningen()
        {
            throw new System.NotImplementedException();
        }

        public void CheckOutUitlening(Uitlening uitlening)
        {
            throw new System.NotImplementedException();
        }

        public void AddUitlening(Lener leerling, DateTime tot, Item item)
        {
            throw new System.NotImplementedException();
        }
    }
}