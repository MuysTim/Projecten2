using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class DvdsMapper : EntityTypeConfiguration<DVD>
    {
        public DvdsMapper() 
        {
            HasKey(d => d.Id);
            Property(d => d.Titel).IsRequired();
            Property(d => d.Soort).IsOptional();
        }
    }
}