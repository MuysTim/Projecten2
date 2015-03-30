using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.DAL.Mapper
{
    public class LeerlingMapper : EntityTypeConfiguration<Leerling>
    {
        public LeerlingMapper()
        {
            this.HasKey(l => l.Id);
            Property(l => l.Naam).IsRequired();
            Property(l => l.Voornaam).IsRequired();
            Property(l => l.Adres).IsOptional();
            Property(l => l.Email).IsOptional();
            Property(l => l.Klas).IsRequired();
            //HasMany(u => u.Uitleningen);
            
        }

    }
}