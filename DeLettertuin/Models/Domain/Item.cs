using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Item
    {
        protected Item()
        {

        }

        protected Item(int id, string naam, bool inMediatheek, string omschrijving, int leeftijd)
        {
            Id = id;
            Naam = naam;
            InMediatheek = inMediatheek;
            Omschrijving = omschrijving;
            Leeftijd = leeftijd;
        }



        public bool InMediatheek { get; set; }

        public string Omschrijving { get; set; }

        public string Naam { get; set; }

        public int Id { get; set; }

        public int Leeftijd { get; set; }

        public void IsUitgeleend()
        {
            throw new System.NotImplementedException();
        }
    }
}
