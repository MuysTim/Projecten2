using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class CdsMapper:EntityTypeConfiguration<CD>
    {
        public CdsMapper()
        {
            HasKey(c => c.Id);
            Property(c => c.Titel).IsRequired();
            Property(c => c.Soort).IsOptional();

        }
    }
}