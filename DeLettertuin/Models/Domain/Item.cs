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

        protected Item(int id, string naam, bool inMediatheek, string omschrijving)
        {
            Id = id;
            Naam = naam;
            InMediatheek = inMediatheek;
            Omschrijving = omschrijving;
        }



        public bool InMediatheek { get; set; }

        public string Omschrijving { get; set; }

        public string Naam { get; set; }

        public int Id { get; set; }

        public bool IsUitgeleend()
        {
            throw new System.NotImplementedException();
        }
    }
}
