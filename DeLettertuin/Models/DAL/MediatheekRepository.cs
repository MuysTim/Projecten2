using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class MediatheekRepository: IMediatheekRepository
    {
        private DeLettertuinContext Context;
        private DbSet<Mediatheek> Mediatheken;
        public MediatheekRepository(DeLettertuinContext context)
        {
           
            Context = context;
            Mediatheken = context.Mediatheken;
            
            Mediatheken.Add(new Mediatheek());
            SaveChanges();
        }
        public Mediatheek GetMediatheek()
        {
            return Mediatheken.First();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
    
}