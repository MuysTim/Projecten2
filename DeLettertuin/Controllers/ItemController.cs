using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Controllers
{
    public class ItemController : Controller
    {
        private IItemRepository repos;

        public ItemController()
        {

        }
        
        public Collection<Item> Items { get; set; }

        public void EditItem(Item item)
        {

        }

        public void RemoveItem(Item item)
        {
            repos.Delete(item);
        }

        public Item GetItem()
        {
            throw new System.NotImplementedException();
        }

        public Collection<Item> GetItems()
        {
            throw new System.NotImplementedException();
        }

        public void AddItem(string naam, bool inMediatheek, string omschrijving)
        {
            throw new System.NotImplementedException();
        }

        public Item IsUitgeleend(Item item)
        {
            throw new System.NotImplementedException();
        }

	}
}