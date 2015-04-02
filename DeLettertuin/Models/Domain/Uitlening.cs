using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Uitlening
    {
        public Uitlening(int id, bool isTerugInMediatheek, DateTime van, DateTime tot, Item item)
        {
            Id = id;
            IsTerugInMediatheek = isTerugInMediatheek;
            StartDatum = van;
            EindDatum = tot;
            Item = item;
        }

        public Uitlening (Item i, DateTime tot)
        {
            Item = i;
            StartDatum = DateTime.Today;
            EindDatum = tot;
            IsTerugInMediatheek = false;
        }

        public Item Item
        {
            get { return Item; }
            set
            {
            }
        }

        public bool IsTerugInMediatheek
        {
            get { return IsTerugInMediatheek; }
            set { }
        }

        public DateTime StartDatum
        {
            get { return StartDatum; }
            private set { StartDatum = value.Date; }

        }

        public DateTime EindDatum
        {
            get { return EindDatum; }
            private set { EindDatum = value.Date; }
        }

        public int Id
        {
            get { return Id; }
            set { }
        }
    }
}
