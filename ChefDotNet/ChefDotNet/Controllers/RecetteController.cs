using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChefDotNet.Models;

namespace ChefDotNet.Controllers
{
    public class RecetteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Fiche(string id)
        {
            int convId = -1;
            if (id == null || !int.TryParse(id, out convId))
                return RedirectToAction("Index", "Erreur");

            if ((ViewBag.recette = BM.Recette.GetRecetteById(convId)) != null)
                return View();
            else
                return RedirectToAction("Index", "Erreur");
        }

        public ActionResult Creation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creation(RecetteModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = BM.User.GetUserByName(User.Identity.Name);

            DBO.Recette recette = new DBO.Recette()
            {
                Nom = model.Nom,
                idCreateur = user.Id,
                Categorie = model.Categorie,
                Difficulte = model.Difficulte,
                Intro = model.Intro,
                Photo = model.Photo,
                Realisation = model.Realisation,
                TempsRepos = model.TempsRepos,
                TempsCuisson = model.TempsCuisson,
                TempsPreparation = model.TempsPreparation
            };

            if (BM.Recette.NewRecette(recette))
                return RedirectToAction("Fiche", "Recette", new { id = model.Nom });

            return View(model);
        }
    }
}