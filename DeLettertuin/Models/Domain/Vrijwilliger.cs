using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using DeLettertuin.Domain;
using DeLettertuin.Models.Domain;

namespace DeLettertuin
{
    public class Vrijwilliger : Gebruiker
    {
        public void Uitlenen(Leerling l, DateTime tot, Item i)
        {
            //Mediatheek.UitleningToevoegen(l, tot, i);
        }

        public void Ontlenen()
        {
            throw new System.NotImplementedException();
        }

        public void LogOut()
        {
            throw new System.NotImplementedException();
        }

        public void UitleningAanpassen()
        {
            throw new System.NotImplementedException();
        }
    }
}
