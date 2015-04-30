using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;

namespace DeLettertuin
{
    public class Mediatheek
    {
        public Mediatheek()
        {
            Gebruikers = new List<Gebruiker>();
            Items = new List<Item>();
            Uitleningen = new List<Uitlening>();
            Leerlingen = new List<Leerling>();
            Themas = new List<Thema>();


        }

        public ICollection<Gebruiker> Gebruikers { get; set; }

        public ICollection<Item> Items { get; set; }

        public static ICollection<Uitlening> Uitleningen { get; set; }

        public ICollection<Leerling> Leerlingen { get; set; }

        public ICollection<Thema> Themas { get; set; }

        public UitleningRepository UitleningRepository { get; set; }

        public void ThemaAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void GebruikerAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void ItemAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void UitleningAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Item> ZoekAlleBeschikbareItemsVan()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Item> ZoekAlleItemsOp()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Item> ZoekAlleItemsVan()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Uitlening> ZoekAlleUitleningenOp()
        {
            throw new System.NotImplementedException();
        }

        public void ThemaVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void GebruikerVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void ItemVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void LenerVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void UitleningVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void ThemaToevoegen()
        {
            throw new System.NotImplementedException();
        }

        public void GebruikerToevoegen()
        {
            throw new System.NotImplementedException();
        }

        public void ItemToevoegen()
        {
            throw new System.NotImplementedException();
        }

        public void LenerToevoegen()
        {
            throw new System.NotImplementedException();
        }

        public static void UitleningToevoegen(Leerling l, DateTime tot, Item i)
        {
            if(!KanUitlenen(l))
                throw new ApplicationException("Leerling heeft al 3 uitleningen");
            Uitlening nieuweUitlening = new Uitlening(i,tot);
            if (Uitleningen.Contains(nieuweUitlening))
                throw new ApplicationException("Uitlening bestaat al");

            Uitleningen.Add(nieuweUitlening);

        }

        public static bool KanUitlenen(Leerling l)
        {
            if (l.Uitleningen.Count >= 3) throw new ApplicationException("Lener heeft al 3 uitleningen");
                return false;

        }
    }
}
