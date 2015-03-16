using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.Domain
{
    public interface IItem
    {
         bool InMediatheek { get; set; }

         string Omschrijving { get; set; }

         string Naam { get; set; }

         int Id { get; set; }
    }
}