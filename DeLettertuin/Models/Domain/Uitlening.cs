using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Uitlening
    {

        public Uitlening()
        {

        }

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
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool IsTerugInMediatheek
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        [DisplayName("Van")]
        public DateTime StartDatum
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        [DisplayName("Tot")]
        public DateTime EindDatum
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
