using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class DvdRepository :IDvdRepository
    {
        private DeLettertuinContext context;
        private DbSet<DVD> Dvds;

        public DvdRepository(DeLettertuinContext context)
        {
            this.context = context;
            Dvds = context.DvDs;

        }

        public DVD FindBy(int itemId)
        {
            return Dvds.Find(itemId);
        }

        public IQueryable<DVD> FindAll()
        {
            return Dvds;
        }

        public void Add(DVD dvd)
        {
            Dvds.Add(dvd);
        }

        public void Delete(DVD dvd)
        {
            context.DvDs.Remove(dvd);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}