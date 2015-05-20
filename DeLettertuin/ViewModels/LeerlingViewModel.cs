using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using DeLettertuin.Domain;

namespace DeLettertuin.ViewModels
{
    public class LeerlingViewModel
    {
        public LeerlingViewModel()
        {
            
        }
        public LeerlingViewModel(Leerling l)
        {
            Id = l.Id;
            Naam = l.Naam;
            Voornaam = l.Voornaam;
            Klas = l.Klas;
            Adres = l.Adres;
            Email = l.Email;
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Naam")]
        [Required]
        public string Naam { get; set; }
        [Display(Name = "Voornaam")]
        [Required]
        public string Voornaam { get; set; }
        [Display(Name = "Klas")]
        [Required]
        public string Klas { get; set; }
        [Display(Name = "Adres")]
        [Required]
        public string Adres { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

    }


    public class LeerlingIndexViewModel
    {
        public LeerlingIndexViewModel(Leerling l)
        {
            Id = l.Id;
            Naam = l.Naam;
            Voornaam = l.Voornaam;
            Klas = l.Klas;
            Adres = l.Adres;
            Email = l.Email;
        }
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Voornaam { get; private set; }
        public string Klas { get; private set; }
        public string Adres { get; private set; }
        public string Email { get; private set; }
    }
}