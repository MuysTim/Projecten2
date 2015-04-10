using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Leerling
    {
        public string Voornaam { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Klas { get; set; }

        public Leerling() { }
        public Leerling(string naam,string voornaam,string klas,string email,string adres, int id)
        {
            Naam = naam;
            Id = id;
            Voornaam = voornaam;
            Adres = adres;
            Email = email;
            Klas = klas;
        }

        public ICollection<Uitlening> Uitleningen { get; set; }

        public int Id { get; set; }

        public string Naam { get; set; }

        public void LeenUit()
        {
            throw new System.NotImplementedException();
        }
    }
}
