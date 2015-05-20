using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Domain;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;
using DeLettertuin.ViewModels;
using Ninject.Infrastructure.Language;

namespace DeLettertuin.Controllers
{
    public class LeerlingController : Controller
    {
        private ILeerlingRepository leerlingRepository;
        public List<Leerling> LeerlingenList = new List<Leerling>(); 

        public LeerlingController() { }
        public LeerlingController(ILeerlingRepository leerlingRepository)
        {
            this.leerlingRepository = leerlingRepository;
        }

        public void RemoveLeerling(Leerling leerling)
        {
            leerlingRepository.Delete(leerling);
        }

        public List<Leerling> GetLeerlingen()
        {
            return LeerlingenList;
        }

        public Uitlening GetLeerling()
        {
            throw new System.NotImplementedException();
        }

        public void AddLeerling(Leerling leerling)
        {
            leerlingRepository.Add(leerling);
            leerlingRepository.SaveChanges();
        }

        public void EditLeerling(Leerling leerling)
        {
            RemoveLeerling(leerlingRepository.FindBy(leerling.Id));
            AddLeerling(leerling);
        }

        public void GeefLeningAanLeerling(Leerling leerling, Uitlening uitlening)
        {
            leerlingRepository.FindBy(leerling.Id).LeenUit(uitlening);
            leerlingRepository.SaveChanges();
        }

        public ActionResult LeerlingenView()
        {
            var leerlingen = leerlingRepository.FindAll();
            return View(leerlingen);
        }

        private void MapToLeerling(LeerlingViewModel lvm, Leerling leerling)
        {
            leerling.Naam = lvm.Naam;
            leerling.Voornaam = lvm.Voornaam;
            leerling.Adres = lvm.Adres;
            leerling.Email = lvm.Email;
            leerling.Klas = lvm.Klas;
        }
    }

}