using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class ItemRepository : IItemRepository
    {
        private DeLettertuinContext Context;
        private DbSet Items;
        private string ItemSoort;

        public ItemRepository(DeLettertuinContext context)
        {
            Context = context;
        }

        public ItemRepository(DeLettertuinContext context, String itemSoort)
        {
            Context = context;
            Items = context.Items;
            ItemSoort = itemSoort;

            switch (ItemSoort)
            {
                case "CD":
                    Items = Context.CDs;
                    break;
                case "Boeken":
                    Items = Context.Boeken;
                    break;
                case "DVD":
                    Items = Context.DvDs;
                    break;
                case "Verteltassen":
                    Items = Context.Verteltassen;
                    break;
                case "Spellen":
                    Items = Context.Spellen;
                    break;
                default:
                    throw new Exception("Er is geen Id meegegeven");

        }

        }
        public Item FindBy(int itemId)
        {
            return (Item) Items.Find(itemId);
        }

        public IQueryable<Item> FindAll()
        {
            return (IQueryable<Item>) Items;
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Delete(Item item)
        {
            Items.Remove(item);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}