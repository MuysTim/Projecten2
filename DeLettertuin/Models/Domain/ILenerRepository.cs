using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.Domain
{
    public interface ILenerRepository
    {
        Lener FindBy(int itemId);
        IQueryable<Lener> FindAll();
        void Add(Lener leerling);
        void Delete(Lener leerling);
        void SaveChanges();
    }
}