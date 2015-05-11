using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class LeerlingRepository : ILeerlingRepository
    {
        private DeLettertuinContext context;
        private DbSet<Leerling> Leerlingen;

        public LeerlingRepository(DeLettertuinContext context)
        {
            this.context = context;
            Leerlingen = context.Leerlingen;
        }
        public Leerling FindBy(int id)
        {
            return Leerlingen.Find(id);
        }

        public IQueryable<Leerling> FindAll()
        {
            return Leerlingen;
        }

        public void Add(Leerling leerling)
        {
            Leerlingen.Add(leerling);
        }

        public void Delete(Leerling leerling)
        {
            Leerlingen.Remove(leerling);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}