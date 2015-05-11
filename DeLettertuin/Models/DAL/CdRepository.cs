using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class CdRepository:ICdRepository
    {
        private DeLettertuinContext context;
        private DbSet<CD> Cds;

        public CdRepository(DeLettertuinContext context)
        {
            this.context = context;
            Cds = context.CDs;

        }

        public CD FindBy(int itemId)
        {
            return Cds.Find(itemId);
        }

        public IQueryable<CD> FindAll()
        {
            return Cds;
        }

        public void Add(CD cd)
        {
            Cds.Add(cd);
        }

        public void Delete(CD cd)
        {
            context.CDs.Remove(cd);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}