using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Lener
    {
        public Lener(string naam, int id)
        {
            Naam = naam;
            Id = id;
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
