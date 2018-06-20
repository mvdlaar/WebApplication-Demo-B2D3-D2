using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AanmakenToets
    {
        public string MaakToetsAan(string naam)
        {
            Toets toets = new Toets();

            toets.Naam = naam;

            return "succes! " + toets.Naam;
        }
    }
}