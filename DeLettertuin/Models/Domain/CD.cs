using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class CD : Item
    {
        public string Titel { get; set;}
        public string Soort { get; set;}

        public CD(int id, string naam, string soort, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving)
        {
            Titel = naam;
            Soort = soort;
        }

        public ICollection<Thema> Themas { get; set; }
        
    }
}
