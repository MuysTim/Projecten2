using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class ItemMapper:EntityTypeConfiguration<Item>

    {
        public ItemMapper()
        {
            HasKey(i => i.Id);
            Map<Boek>(m => m.MapInheritedProperties().ToTable("boeken"));
            Map<CD>(m => m.MapInheritedProperties().ToTable("cds"));
            Map<DVD>(m => m.MapInheritedProperties().ToTable("dvds"));
            //Map<Verteltas>(m => m.MapInheritedProperties().ToTable("Verteltassen"));
            Map<Spel>(m => m.MapInheritedProperties().ToTable("Spellen"));

        }

    }
}