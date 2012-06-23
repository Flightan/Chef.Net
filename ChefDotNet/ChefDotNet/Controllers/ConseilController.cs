using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChefDotNet.Models;

namespace ChefDotNet.Controllers
{
    public class ConseilController : Controller
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

            if ((ViewBag.conseil = BM.Conseil.GetConseilById(convId)) != null)
                return View();
            else
                return RedirectToAction("Index", "Erreur");
        }

        public ActionResult Creation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creation(ConseilModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = BM.User.GetUserByName(User.Identity.Name);

            DBO.Conseil conseil = new DBO.Conseil()
            {
                Nom = model.Nom,
                Text = model.Texte,
                DateCreation = DateTime.Now,
                idCreateur = user.Id
            };

            string result = BM.Conseil.NewConseil(conseil);

            if (result == string.Empty)
            {
                conseil = BM.Conseil.GetConseilByNom(model.Nom);
                return RedirectToAction("Fiche", "Conseil", new { id = conseil.Id });
            }

            ModelState.AddModelError("", result);
            return View(model);
        }
    }
}