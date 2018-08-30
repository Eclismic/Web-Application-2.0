using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Applicatie.Models;

namespace Web_Applicatie.Controllers
{
    public class ConnectieController : Controller
    {
        Software _software = null;

        // GET: Connectie
        public ActionResult Connectie(Software software)
        {
            _software = software;
            return Redirect("https://web.snelstart.nl/couplings/activate/testKoppeling?successUrl=https%3A%2F%2Fweb.snelstart.nl&referenceKey=1");
        }

        public ActionResult AuthOntvangst()
        {
            ActieveKoppeling actieveKoppeling = new ActieveKoppeling { Software = _software, ClientKey = GetClientKeyOutRespons() };
            return View();
        } 
        
        
        private string GetClientKeyOutRespons()
        {
            throw new NotImplementedException();
        }
    }
}