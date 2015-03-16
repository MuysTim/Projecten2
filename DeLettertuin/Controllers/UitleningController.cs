using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace DeLettertuin.Controllers
{
    public class UitleningController
    {
        private IUitleningenRepository repos;

        public UitleningController(DeLettertuinContext context)
        {
            repos = new UitleningRepository(context);
        }
        
        public Collection<Uitlening> Uitleningen { get; set; }


    }
}