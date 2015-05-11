﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeLettertuin.Models.DAL;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Controllers
{
    public class UitleningController : Controller
    {
        public List<Uitlening> UitleningenList = new List<Uitlening>(); 
        private IUitleningenRepository uitleningenRepository;

        public UitleningController(IUitleningenRepository uitleningenRepository)
        {
            this.uitleningenRepository = uitleningenRepository;
        }
        public ActionResult UitleningenView()
        {
            var model = GetUitleningen();
            return View(model);
        }

        public UitleningController(DeLettertuinContext context)
        {
            uitleningenRepository = new UitleningRepository(context);
        }
        
        public void EditUitlening(Uitlening uitlening)
        {

        }

        public void RemoveUitlening(Uitlening uitlening)
        {
            uitleningenRepository.Delete(uitlening);
        }

        public Uitlening GetUitlening()
        {
            throw new System.NotImplementedException();
        }

        public List<Uitlening> GetUitleningen()
        {
            return UitleningenList;
        }

        public void CheckOutUitlening(Uitlening uitlening)
        {
            throw new System.NotImplementedException();
        }

        public void AddUitlening(Uitlening uitlening)
        {
            uitleningenRepository.Add(uitlening);
            uitleningenRepository.SaveChanges();
        }
    }
}