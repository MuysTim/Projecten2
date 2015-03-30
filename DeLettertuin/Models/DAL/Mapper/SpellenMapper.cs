using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class SpellenMapper : EntityTypeConfiguration<Spel>
    {
        public SpellenMapper()
        {
            HasKey(s => s.Id);
            Property(s => s.Naam).IsRequired();
            Property(s => s.Uitgeverij).IsOptional();
            //Property(s => s.Thema).IsOptional();
            Property(s => s.Leeftijd).IsOptional();
            Property(s => s.Info).IsOptional();
        }
    }
}