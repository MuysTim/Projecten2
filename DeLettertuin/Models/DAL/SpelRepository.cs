using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class SpelRepository: ISpelRepository
    {
        private DeLettertuinContext context;
        private DbSet<Spel> Spellen;

        public SpelRepository(DeLettertuinContext context)
        {
            this.context = context;
            Spellen = context.Spellen;

        }

        public Spel FindBy(int itemId)
        {
            return Spellen.Find(itemId);
        }

        public IQueryable<Spel> FindAll()
        {
            return Spellen;
        }

        public void Add(Spel spel)
        {
            Spellen.Add(spel);
        }

        public void Delete(Spel spel)
        {
            context.Spellen.Remove(spel);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}