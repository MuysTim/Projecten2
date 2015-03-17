using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.DAL;

namespace DeLettertuin.Models.Domain
{
    public interface IUitleningenRepository
    {
        Uitlening FindBy(int itemId);
        IQueryable<Uitlening> FindAll();
        void Add(Uitlening uitlening);
        void Delete(Uitlening uitlening);
        void SaveChanges();
    }
}