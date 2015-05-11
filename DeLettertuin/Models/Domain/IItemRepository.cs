using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.Domain
{
    public interface IItemRepository
    {
        
    }

    public interface IBoekRepository
    {
        Boek FindBy(int itemId);
        IQueryable<Boek> FindAll();
        void Add(Boek boek);
        void Delete(Boek boek);
        void SaveChanges();
    }

    public interface IDvdRepository
    {
        DVD FindBy(int itemId);
        IQueryable<DVD> FindAll();
        void Add(DVD dvd);
        void Delete(DVD dvd);
        void SaveChanges();
    }

    public interface ICdRepository
    {
        CD FindBy(int itemId);
        IQueryable<CD> FindAll();
        void Add(CD cd);
        void Delete(CD cd);
        void SaveChanges();
    }

    public interface ISpelRepository
    {
        Spel FindBy(int itemId);
        IQueryable<Spel> FindAll();
        void Add(Spel spel);
        void Delete(Spel spel);
        void SaveChanges();
    }

    public interface IVerteltasRepository
    {
        Verteltas FindBy(int itemId);
        IQueryable<Verteltas> FindAll();
        void Add(Verteltas vt);
        void Delete(Verteltas vt);
        void SaveChanges();
    }
}