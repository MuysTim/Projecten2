using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;
using Microsoft.Ajax.Utilities;

namespace DeLettertuin.Models.DAL
{
    public class BoekRepository:IBoekRepository
    {
        private DeLettertuinContext context;
        private DbSet<Boek> boeken;

        public BoekRepository(DeLettertuinContext context)
        {
            this.context = context;
            boeken = context.Boeken;

        }

        public Boek FindBy(int itemId)
        {
            return boeken.Find(itemId);
        }

        public IQueryable<Boek> FindAll()
        {
            return boeken;
        }

        public void Add(Boek boek)
        {
            boeken.Add(boek);
        }

        public void Delete(Boek boek)
        {
            context.Boeken.Remove(boek);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}