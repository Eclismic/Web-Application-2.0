using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Applicatie.Models;


namespace Web_Applicatie.Controllers
{
    public class KoppelController : Controller
    {
        // GET: Koppel
        public ViewResult Start()
        {

            var viewResult = new ViewResult();
            return View(GetSoftwareLijst());
        }

        public IEnumerable<Software> GetSoftwareLijst()
        {
            var softwareLijst = new List<Software>
            {
                new Software { Naam = "Exact", Description = "Exact is een onderneming die software ontwikkelt gericht op de ondersteuning van met name het midden- en kleinbedrijf. Het bedrijf vindt zijn oorsprong in Exact Software, een Nederlands softwarebedrijf dat is opgericht in 1984." },
                new Software { Naam = "SnelStart", Description = "SnelStart is een van de eerste boekhoud- en facturatiepakketten in Nederland. Sinds begin jaren tachtig ontwikkelen wij boekhoudsoftware voor ondernemers. Al die jaren was de insteek om boekhouden eenvoudig en begrijpelijk te maken voor elke ondernemer. Het is dan ook geen wonder dat het aantal gebruikers van onze software na ruim 35 jaar nog steeds groeit." }
            };

            return softwareLijst;
        }
    }
}