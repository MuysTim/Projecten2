using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DeLettertuin.Domain;

namespace DeLettertuin.ViewModels
{
    public class BoekViewModel
    {
        public BoekViewModel()
        {
            
        }
        public BoekViewModel(Boek b)
        {
            Id = b.Id;
            Titel = b.Titel;
            Auteur = b.Auteur;
            Uitgeverij = b.Uitgeverij;
            Korte_Inhoud = b.Korte_Inhoud;
            Leeftijd = b.Leeftijd;
        }

        [Key]
        public int Id { get; set; }
        [Display(Name = "Titel")]
        [Required]
        public string Titel { get; set; }
        [Display(Name = "Auteur")]
        [Required]
        public string Auteur { get; set; }
        [Display(Name = "Uitgeverij")]
        [Required]
        public string Uitgeverij { get; set; }
        [Display(Name = "Korte_Inhoud")]
        [Required]
        public string Korte_Inhoud { get; set; }
        [Display(Name = "Leeftijd")]
        [Required]
        public int Leeftijd { get; set; }

    }
}