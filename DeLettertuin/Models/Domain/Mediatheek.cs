using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DeLettertuin.Domain;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.DAL.Mapper;
using DeLettertuin.Models.Domain;

namespace DeLettertuin
{
    public class Mediatheek
    {
        public Mediatheek()
        {
            //Gebruikers = new List<Gebruiker>();
            Items = new List<Item>();
            Uitleningen = new List<Uitlening>();
            Leerlingen = new List<Leerling>();
            Themas = new List<Thema>();
            Cds = new List<CD>();
            Dvds = new List<DVD>();
            Spellen = new List<Spel>();
            Verteltassen = new List<Verteltas>();
            Boeken = new List<Boek>();
        }

        public int Id { get; set; }

        //public ICollection<Gebruiker> Gebruikers { get; set; }

        public ICollection<Item> Items { get; set; }

        public static ICollection<Uitlening> Uitleningen { get; set; }

        public ICollection<Leerling> Leerlingen { get; set; }

        public ICollection<Thema> Themas { get; set; }

        public virtual ICollection<Boek> Boeken { get; set; }

        public virtual ICollection<CD> Cds { get; set; }

        public virtual ICollection<DVD> Dvds { get; set; }

        public virtual ICollection<Verteltas> Verteltassen { get; set; }
        
        public virtual ICollection<Spel> Spellen { get; set; } 


        #region Thema
        public void ThemaAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void ThemaVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void ThemaToevoegen()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region gebruiker
        public void GebruikerAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void GebruikerVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void GebruikerToevoegen()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Item
        public void ItemAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void ItemVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void ItemToevoegen(Item item)
        {
            Boeken.Add((Boek)item);
        }
        #endregion

        #region uitlening
        public void UitleningAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void UitleningVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public Uitlening UitleningToevoegen(Leerling l, DateTime tot, Item i)
        {
            if (!KanUitlenen(l))
                throw new ApplicationException("Leerling heeft al 3 uitleningen");
            Uitlening nieuweUitlening = new Uitlening(i, tot);
            if (Uitleningen.Contains(nieuweUitlening))
                throw new ApplicationException("Uitlening bestaat al");

            Uitleningen.Add(nieuweUitlening);
            return nieuweUitlening;
        }
        #endregion

        #region Leerling
        public void LeerlingVerwijderen()
        {
            throw new System.NotImplementedException();
        }

        public void LeerlingAanpassen()
        {
            throw new System.NotImplementedException();
        }

        public void LeerlingToevoegen()
        {
            throw new System.NotImplementedException();
        }
#endregion


        public ICollection<Item> ZoekAlleBeschikbareItemsVan()
        {
            return null;
        }

        public ICollection<Item> ZoekAlleItemsOp()
        {
            return null;
        }

        public ICollection<Item> ZoekAlleItemsVan()
        {
            return null;
        }

        public ICollection<Uitlening> ZoekAlleUitleningenOp()
        {
            return null;
        }

        public static bool KanUitlenen(Leerling l)
        {
            if (l.Uitleningen.Count >= 3) throw new ApplicationException("Lener heeft al 3 uitleningen");
                return false;
        }

        public Leerling LeenAanLeerling(Leerling leerling, Uitlening uitlening)
        {
            var uitlener = Leerlingen.First(l => l.Id == leerling.Id);
            uitlener.LeenUit(uitlening);
            return uitlener;

        }
    }
}
