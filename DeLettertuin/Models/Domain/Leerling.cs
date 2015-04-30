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
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Klas { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public ICollection<Uitlening> Uitleningen { get; set; }

        public Leerling() { }
        public Leerling(int id, string naam,string voornaam,string klas,string email,string adres)
        {
            Id = id;
            Naam = naam;
            Voornaam = voornaam;
            Klas = klas;
            Email = email;
            Adres = adres;
        }

        public void LeenUit()
        {
            throw new System.NotImplementedException();
        }
    }
}
