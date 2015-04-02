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

        public Leerling Leerling { get; set; }
        public Item Item { get; set; }

        public bool IsTerugInMediatheek { get; set; }

        [DisplayName("Van")]
        public DateTime StartDatum { get; set; }
        
        [DisplayName("Tot")]
        public DateTime EindDatum { get; set; }

        public int Id { get; set; }
    }
}
