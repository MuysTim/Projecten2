using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.ViewModels
{
    public class LeerlingViewModel
    {
        public LeerlingViewModel()
        {
            
        }
        public LeerlingViewModel(Leerling l)
        {
            Id = l.Id;
            Naam = l.Naam;
            Voornaam = l.Voornaam;
            Klas = l.Klas;
            Adres = l.Adres;
            Email = l.Email;
        }
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Klas { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }

    }


    public class LeerlingIndexViewModel
    {
        public LeerlingIndexViewModel(Leerling l)
        {
            Id = l.Id;
            Naam = l.Naam;
            Voornaam = l.Voornaam;
            Klas = l.Klas;
            Adres = l.Adres;
            Email = l.Email;
        }
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Voornaam { get; private set; }
        public string Klas { get; private set; }
        public string Adres { get; private set; }
        public string Email { get; private set; }
    }
}