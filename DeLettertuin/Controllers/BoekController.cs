using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.Domain;
using DeLettertuin.ViewModels;

namespace DeLettertuin.Controllers
{
    public class BoekController : Controller
    {
        private IBoekRepository boekRepository;
        public List<Boek> BoekenList = new List<Boek>(); 

        public BoekController() { }
        public BoekController(IBoekRepository boekRepository)
        {
            this.boekRepository = boekRepository;
        }

        public void RemoveBoek(Boek boek)
        {
            boekRepository.Delete(boek);
        }

        public List<Boek> GetBoeken()
        {
            return BoekenList;
        }

        public void AddBoek(Boek boek)
        {
            boekRepository.Add(boek);
            boekRepository.SaveChanges();
        }

        public void EditBoek(Boek boek)
        {
            RemoveBoek(boekRepository.FindBy(boek.Id));
            AddBoek(boek);
        }

        public ActionResult BoekenView()
        {
            return View();
        }

        private void MapToLeerling(BoekViewModel bvm, Boek boek)
        {
            boek.Id = bvm.Id;
            boek.Auteur = bvm.Auteur;
            boek.Titel = bvm.Titel;
            boek.Uitgeverij = bvm.Uitgeverij;
            boek.Korte_Inhoud = bvm.Korte_Inhoud;
            boek.Leeftijd = bvm.Leeftijd;
        }
    

}
}