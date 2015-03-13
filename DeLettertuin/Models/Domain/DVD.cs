﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class DVD : Item
    {

        public DVD(int id, string naam, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving)
        {
            
        }

        public ICollection<Thema> Themas { get; set; }
        
    }
}
