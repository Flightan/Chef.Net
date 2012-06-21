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

        [HttpPost]
        public ActionResult Fiche(CommentaireModel model)
        {
            if ((ViewBag.recette = BM.Recette.GetRecetteById(model.recetteId)) == null)
                return RedirectToAction("Index", "Erreur");

            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = BM.User.GetUserByName(User.Identity.Name);

            DBO.Commentaire commentaire = new DBO.Commentaire()
            {
                Text = model.Texte,
                Note = model.Note,
                idUser = user.Id,
                idRecette = model.recetteId
            };

            string result = BM.Commentaire.NewCommentaire(commentaire);

            if (result == string.Empty)
                return RedirectToAction("Fiche", model.recetteId);

            ModelState.AddModelError("", result);
            return View(model);
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

            string result = BM.Recette.NewRecette(recette);

            if (result == string.Empty)
            {
                recette = BM.Recette.GetRecetteByNom(model.Nom);
                return RedirectToAction("Fiche", "Recette", new { id = recette.Id });
            }

            ModelState.AddModelError("", result);
            return View(model);
        }
    }
}