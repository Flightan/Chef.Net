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
            {
                DBO.User user = BM.User.GetUserByName(User.Identity.Name);
                ViewBag.Note = BM.Note.GetNoteByUserForRecette(user, ViewBag.recette);
                return View();
            }
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

            ViewBag.Note = BM.Note.GetNoteByUserForRecette(user, ViewBag.recette);

            string result = BM.Commentaire.NewCommentaire(commentaire);

            if (result == string.Empty)
                return RedirectToAction("Fiche", model.recetteId);

            ModelState.AddModelError("", result);
            return View(model);
        }

        public ActionResult Creation()
        {
            RecetteModel model = new RecetteModel();
            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList(), "Id", "Value");
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList(), "Id", "Value");
            return View(model);
        }

        [HttpPost]
        public ActionResult Creation(RecetteModel model)
        {
            model.DifficulteList = new SelectList(BM.Recette.GetDifficulteList(), "Id", "Value");
            model.CategorieList = new SelectList(BM.Recette.GetCategorieList(), "Id", "Value");

            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = BM.User.GetUserByName(User.Identity.Name);

            DBO.Recette recette = new DBO.Recette()
            {
                Nom = model.Nom,
                idCreateur = user.Id,
                Categorie = BM.Recette.GetCategorieList().ElementAt(model.CategorieSelected - 1).Value,
                Difficulte = BM.Recette.GetDifficulteList().ElementAt(model.DifficulteSelected - 1).Value,
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
                string[] ingredients = model.Ingredients.Split(',');
                foreach (string ingredient in ingredients)
                {
                    DBO.Ingredient ing = new DBO.Ingredient();
                    ing.Nom = ingredient;
                    ing.idRecette = recette.Id;
                    BM.Ingredient.NewIngredient(ing);
                }
                return RedirectToAction("Fiche", "Recette", new { id = recette.Id });
            }

            ModelState.AddModelError("", result);
            return View(model);
        }
    }
}