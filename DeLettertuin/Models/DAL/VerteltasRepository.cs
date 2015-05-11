using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class VerteltasRepository: IVerteltasRepository
    {
        private DeLettertuinContext context;
        private DbSet<Verteltas> Verteltassen;

        public VerteltasRepository(DeLettertuinContext context)
        {
            this.context = context;
            Verteltassen = context.Verteltassen;

        }

        public Verteltas FindBy(int itemId)
        {
            return Verteltassen.Find(itemId);
        }

        public IQueryable<Verteltas> FindAll()
        {
            return Verteltassen;
        }

        public void Add(Verteltas verteltas)
        {
            Verteltassen.Add(verteltas);
        }

        public void Delete(Verteltas verteltas)
        {
            context.Verteltassen.Remove(verteltas);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}