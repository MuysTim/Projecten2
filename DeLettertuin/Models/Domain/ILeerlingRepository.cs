using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeLettertuin.Domain;

namespace DeLettertuin.Models.Domain
{
    public interface ILeerlingRepository
    {
        Leerling FindBy(int itemId);
        IQueryable<Leerling> FindAll();
        void Add(Leerling leerling);
        void Delete(Leerling leerling);
        void SaveChanges();
    }
}