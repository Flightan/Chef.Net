using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChefDotNet.Models;

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
            RechercheAvanceeModel model = new RechercheAvanceeModel();
            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList(), "Id", "Value");
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList(), "Id", "Value");
            ViewBag.First = true;
            return View(model);
        }

        [HttpPost]
        public ActionResult Avancee(Models.RechercheAvanceeModel model)
        {
            string categorie = model.CategorieSelected == 0 ? "Toutes" :
                               BM.Recette.GetCategorieList().ElementAt(model.CategorieSelected - 1).Value;

            string difficulte = model.DifficulteSelected == 0 ? "Toutes" :
                               BM.Recette.GetDifficulteList().ElementAt(model.DifficulteSelected - 1).Value;

            ViewBag.Recettes = BM.Recherche.RechercheAvancee(model.RechercheComplexe, model.Temps, categorie, difficulte);

            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList(), "Id", "Value");
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList(), "Id", "Value");
            ViewBag.First = false;

            return View(model);
        }
    }
}