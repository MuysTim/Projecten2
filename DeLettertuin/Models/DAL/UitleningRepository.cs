using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL
{
    public class UitleningRepository
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
    }
}