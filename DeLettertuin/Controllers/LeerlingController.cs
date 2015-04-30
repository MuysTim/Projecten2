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
        private ILeerlingRepository repos;
        private DeLettertuinContext context;

        public LeerlingController() { }
        public LeerlingController(ILeerlingRepository leerlingRepository)
        {
            repos = leerlingRepository;
        }

        public Collection<Leerling> Leerlingen { get; set; }

        public void RemoveLeerling(Leerling leerling)
        {
            repos.Delete(leerling);
        }

        public List<Leerling> GetLeerlingen()
        {
            return repos.FindAll().ToList();
        }

        public Uitlening GetLeerling()
        {
            throw new System.NotImplementedException();
        }

        public void AddLeerling(Leerling leerling)
        {
            repos.Add(leerling);
            repos.SaveChanges();
        }

        public void EditLeerling(Leerling leerling)
        {
            RemoveLeerling(repos.FindBy(leerling.Id));
            AddLeerling(leerling);
        }

        public void GeefLeningAanLeerling(Leerling leerling, Uitlening uitlening)
        {
            repos.FindBy(leerling.Id).LeenUit(uitlening);
            repos.SaveChanges();
        }

    }

}