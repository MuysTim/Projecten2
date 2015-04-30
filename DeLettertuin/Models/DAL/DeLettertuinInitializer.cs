using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using DeLettertuin.Models.Domain;

namespace DeLettertuin.Models.DAL
{
    public class DeLettertuinInitializer : System.Data.Entity.DropCreateDatabaseAlways<DeLettertuinContext>
    {
        protected override void Seed(DeLettertuinContext context)
        {
            try
            {
                Leerling leerling1 = new Leerling {Id = 1, Naam = "Akhtar",Voornaam = "Hussain", Klas = "1KA", Email = "", Adres = "Dendermondsesteenweg 2"};
                Leerling leerling2 = new Leerling {Id = 2, Naam = "Laporte",Voornaam = "Lora", Klas = "2KB", Email = "", Adres = "Scheldestraat 150"};
                var leerling3 = new Leerling {Id = 3, Naam = "Yordanova",Voornaam= "Azhda", Klas = "3KC", Email = "", Adres = "Afrikalaan 176"};
                Leerling[] leerlingen = new Leerling[] {leerling1,leerling2,leerling3};

                context.Leerlingen.Add(leerling1);
                context.SaveChanges();
                context.Leerlingen.Add(leerling2);
                context.SaveChanges();
                context.Leerlingen.Add(leerling3);
                context.SaveChanges();
                context.Leerlingen.AddRange(leerlingen);
                context.SaveChanges();
            }

            catch (DbEntityValidationException e)
            {
                string s = "Fout creatie database ";
                foreach (var eve in e.EntityValidationErrors)
                {
                    s += String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                         eve.Entry.Entity.GetType().Name, eve.Entry.GetValidationResult());
                    foreach (var ve in eve.ValidationErrors)
                    {
                        s += String.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw new Exception(s);
            }

        }
    }
}
