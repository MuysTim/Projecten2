﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace DeLettertuin
{
    public class Boek : Item
    {
        public string Auteur { get; set; }
        public string Titel { get; set;}
        public string Uitgeverij { get; set;}
        public string Korte_Inhoud { get; set;}
        public int Leeftijd { get; set;}

        public Boek(int id, string naam,string uitgeverij,string korte_inhoud, string auteur,int leeftijd, bool inMediatheek, string omschrijving)
            : base(id, naam, inMediatheek, omschrijving)
        {
            Auteur = auteur;
            Titel = naam;
            Uitgeverij = uitgeverij;
            Korte_Inhoud = korte_inhoud;
            Leeftijd = leeftijd;

        }
        public ICollection<Thema> Themas { get; set; }

    }
}
