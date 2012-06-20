using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChefDotNet.Controllers
{
    public class RechercheController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.RechercheSimpleModel model)
        {
            ViewBag.Recherche = model.Recherche;
            return View();
        }

        public ActionResult Avancee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Avancee(Models.RechercheAvanceeModel model)
        {
            return View();
        }
    }
}