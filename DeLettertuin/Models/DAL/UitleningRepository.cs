using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class UitleningRepository : IUitleningenRepository
    {
        private DeLettertuinContext Context;
        private DbSet<Uitlening> Uitleningen;

        public UitleningRepository(DeLettertuinContext context)
        {
            Context = context;
            Uitleningen = Context.Uitleningen;
        }
        public Uitlening FindBy(int itemId)
        {
            return Uitleningen.Find(itemId);
        }

        public IQueryable<Uitlening> FindAll()
        {
            return Uitleningen;
        }

        public void Add(Uitlening uitlening)
        {
            Uitleningen.Add(uitlening);
        }

        public void Delete(Uitlening uitlening)
        {
            Uitleningen.Remove(uitlening);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}