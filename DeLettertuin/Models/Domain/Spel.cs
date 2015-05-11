using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Spel : Item
    {
        public string Naam { get; set; }
        public string Uitgeverij { get; set; }
        public int Leeftijd { get; set; }
        public string Info { get; set; }

        public Spel(int id, string naam,string uitgeverij,int leeftijd,string info, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving, leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Info = info;

        }

        public ICollection<Thema> Themas { get; set; }
    }
}
