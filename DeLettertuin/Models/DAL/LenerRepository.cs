using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class LenerRepository : ILenerRepository
    {
        private DeLettertuinContext Context;
        private DbSet<Lener> Leners;

        public LenerRepository(DeLettertuinContext context)
        {
            Context = context;
            Leners = Context.Leners;
        }
        public Lener FindBy(int itemId)
        {
            return Leners.Find(itemId);
        }

        public IQueryable<Lener> FindAll()
        {
            return Leners;
        }

        public void Add(Lener lener)
        {
            Leners.Add(lener);
        }

        public void Delete(Lener lener)
        {
            Leners.Remove(lener);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}