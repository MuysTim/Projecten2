using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class DeLettertuinContext : DbContext
    {
        public virtual DbSet<DVD> DvDs { get; set; }
        public virtual DbSet<Spel> Spellen { get; set; }
        public virtual DbSet<CD> CDs { get; set; }
        public virtual DbSet<Verteltas> Verteltassen { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Boek> Boeken { get; set; }

        public virtual DbSet<Lener> Leners { get; set; }
        public virtual DbSet<Uitlening> Uitleningen { get; set; }
        public virtual DbSet<Thema> Themas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Ignore<IItem>();
            base.OnModelCreating(modelBuilder);
        }
    }
}