using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DeLettertuin.Models.DAL;

namespace DeLettertuin
{
    public class Mediatheek
    {
        public Mediatheek()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<Gebruiker> Gebruikers { get; set; }

        public ICollection<Item> Items { get; set; }

        public ICollection<Uitlening> Uitleningen { get; set; }

        public ICollection<DeLettertuin.Lener> Leners { get; set; }

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

        public void UitleningToevoegen()
        {
            throw new System.NotImplementedException();
        }
    }
}
