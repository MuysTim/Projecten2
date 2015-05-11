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
        private DeLettertuinContext context;
        private DbSet items;
        private string itemSoort;

        public ItemRepository(DeLettertuinContext context, String itemSoort)
        {
            this.context = context;
            this.items = context.Items;
            this.itemSoort = itemSoort;

            switch (itemSoort)
            {
                case "CD":
                    items = context.CDs;
                    break;
                case "Boeken":
                    items = context.Boeken;
                    break;
                case "DVD":
                    items = context.DvDs;
                    break;
                case "Verteltassen":
                    items = context.Verteltassen;
                    break;
                case "Spellen":
                    items = context.Spellen;
                    break;
                default:
                    throw new Exception("Er is geen Id meegegeven");

        }

        }
        public Item FindBy(int itemId)
        {
            return (Item) items.Find(itemId);
        }

        public IQueryable<Item> FindAll()
        {
            return (IQueryable<Item>) items;
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Delete(Item item)
        {
            items.Remove(item);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}