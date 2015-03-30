using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class BoekenMapper:EntityTypeConfiguration<Boek>
    {
        public BoekenMapper() 
        {
            HasKey(b => b.Id);
            Property(b => b.Titel).IsRequired();
            Property(b => b.Auteur).IsOptional();
            Property(b => b.Uitgeverij).IsOptional();
            Property(b => b.Korte_Indhoud).IsOptional();
            Property(b => b.Leeftijd).IsOptional();

        }

    }
}