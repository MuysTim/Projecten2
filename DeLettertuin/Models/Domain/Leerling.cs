using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DeLettertuin.Domain
{
    public class Leerling
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Klas { get; set; }

        public Leerling() { }
        public Leerling(string naam, string voornaam, string adres, string email, string klas)
        {
            Naam = naam;
            Voornaam = voornaam;
            Adres = adres;
            Email = email;
            Klas = klas;
        }

        //public  List<Uitlening> Uitleningen { get; set; }

        //public void LeenUit(Uitlening uitlening)
        //{
        //    if (Uitleningen.Count >= 3)
        //    {
        //        throw new ApplicationException("De lener heeft meer dan 3 uitleningen");
        //    }
        //    Uitleningen.Add(uitlening);
        //}


    }
}
