using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChefDotNet.Models;

namespace ChefDotNet.Controllers
{
    public class PagePersonnelleController : Controller
    {
        [HttpGet]
        [Authorize]
        public ActionResult Index(string id)
        {
            if (id == null)
                ViewBag.user = BM.User.GetUserByName(User.Identity.Name);
            else
            {
                int convId = -1;
                if (!int.TryParse(id, out convId))
                    return RedirectToAction("Index", "Erreur");

                ViewBag.user = BM.User.GetUserById(convId);
            }

            if (ViewBag.user != null)
                return View();
            else
                return RedirectToAction("Index", "Erreur");
        }
    }
}