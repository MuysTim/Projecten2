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
        private DeLettertuinContext context;
        private DbSet<Uitlening> uitleningen;

        public UitleningRepository(DeLettertuinContext context)
        {
            this.context = context;
            this.uitleningen = context.Uitleningen;
        }
        public Uitlening FindBy(int itemId)
        {
            return uitleningen.Find(itemId);
        }

        public IQueryable<Uitlening> FindAll()
        {
            return uitleningen;
        }

        public void Add(Uitlening uitlening)
        {
            uitleningen.Add(uitlening);
        }

        public void Delete(Uitlening uitlening)
        {
            uitleningen.Remove(uitlening);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}