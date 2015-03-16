using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.Domain
{
    public class IUitleningRepository
    {
        Uitlening FindBy(int idItem);

        IQueryable<Uitlening> FindAll();
        void Add(Uitlening uitlening);
        void Delete(Uitlening uitlening);
        void SaveChanges();
    }
}