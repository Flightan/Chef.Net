using System;
using System.Collections;
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
            RecetteModel model = new RecetteModel();
            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList());
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList());
            return View(model);
        }

        [HttpPost]
        public ActionResult Creation(RecetteModel model)
        {
            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList());
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList());

            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = BM.User.GetUserByName(User.Identity.Name);

            DBO.Recette recette = new DBO.Recette()
            {
                Nom = model.Nom,
                idCreateur = user.Id,
                Categorie = BM.Recette.GetCategorieList()[model.CategorieSelected].ToString(),
                Difficulte = BM.Recette.GetDifficulteList()[model.DifficulteSelected].ToString(),
                Intro = model.Intro,
                Photo = model.Photo,
                Realisation = model.Realisation,
                TempsRepos = model.TempsRepos == null ? -1 : model.TempsRepos.Value,
                TempsCuisson = model.TempsCuisson == null ? -1 : model.TempsCuisson.Value,
                TempsPreparation = model.TempsPreparation
            };

            string result = BM.Recette.NewRecette(recette);

            if (result == string.Empty)
            {
                recette = BM.Recette.GetRecetteByNom(model.Nom);
                ////////////
                //ici pour chaque ingredient de la liste des ingredients, faut faire
                //DBO.Ingredient ingredient = new DBO.Ingredient();
                //ingredient.nom = model.Nom;
                //ingredient.idRecette = recette.Id;
                //BM.Ingredient.NewIngredient(ingredient);
                ///////////
                return RedirectToAction("Fiche", "Recette", new { id = recette.Id });
            }

            ModelState.AddModelError("", result);
            return View(model);
        }
    }
}