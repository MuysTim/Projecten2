using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Boek : Item
    {
        public string Auteur { get; set; }

        public Boek(int id, string naam, string auteur, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving)
        {
            Auteur = auteur;
        }
        public ICollection<Thema> Themas { get; set; }

    }
}
