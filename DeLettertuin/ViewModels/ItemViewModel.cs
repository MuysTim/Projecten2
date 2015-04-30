using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeLettertuin.Models.ViewModel
{
    public class ItemViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Display(Name = "Naam")]
        [Required]
        public String Naam { get; set; }

        [Display(Name = "In Mediatheek")]
        public bool InMediatheek { get; set; }

        [Display(Name="Omschrijving")]
        public string Omschrijving { get; set; }

        public string Auteur { get; set; }

        public string Titel { get; set; }
        
        public string Uitgeverij { get; set; }

        public string Korte_Inhoud { get; set; }

        [Range(1, 16, ErrorMessage = "{0} mag niet 0 of negatief zijn!!")]
        [Required(ErrorMessage = "{0} is verplicht!!")]
        public int Leeftijd { get; set; }

        public string Soort { get; set; }

        [Display(Name="Thema")]
        public ICollection<Thema> Themas { get; set; }

        public string Info { get; set; }

        public ItemViewModel()
        {
        }

        public ItemViewModel(Boek boek)
        {
            Auteur = boek.Auteur;
            Titel = boek.Naam;
            Uitgeverij = boek.Uitgeverij;
            Korte_Inhoud = boek.Korte_Inhoud;
            Leeftijd = boek.Leeftijd;
        }

        public ItemViewModel(CD cd)
        {
            Titel = cd.Naam;
            Soort = cd.Soort;
        }

        public ItemViewModel(DVD dvd)
        {
            Titel = dvd.Naam;
            Soort = dvd.Soort;
        }

        public ItemViewModel(Item item)
        {
            Id = item.Id;
            Naam = item.Naam;
            Omschrijving = item.Omschrijving;
            InMediatheek = item.InMediatheek;
            Leeftijd = item.Leeftijd;
        }

        public ItemViewModel(Spel spel)
        {
            Naam = spel.Naam;
            Leeftijd = spel.Leeftijd;
            Info = spel.Info;
        }

        public ItemViewModel(Verteltas verteltas)
        {
            Id = verteltas.Id;
            Naam = verteltas.Naam;
            Omschrijving = verteltas.Omschrijving;
            InMediatheek = verteltas.InMediatheek;
            Leeftijd = verteltas.Leeftijd;
        }
    }
}