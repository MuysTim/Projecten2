using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Verteltas : Item
    {
        public Verteltas(int id, string naam, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving)
        {

        }

        public ICollection<Spel> Spellen { get; set; }

        public ICollection<DVD> DVDs { get; set; }

        public ICollection<CD> CDs { get; set; }

        public ICollection<Boek> Boeken { get; set; }

        public ICollection<Thema> Themas { get; set; }
    }
}
