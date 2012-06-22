using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ChefDotNet.Models;

namespace ChefDotNet.Controllers
{
    public class AccountController : Controller
    {
        #region LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = new DBO.User() { Name = model.UserName, Password = model.Password };

            /* if (!BM.User.IsValid(user))
            {
                ModelState.AddModelError("", "Pseudo ou mot de passe incorrect.");
                return View(model);
            }*/

            FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Accueil");
        }

        #endregion LogOn

        #region LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Accueil");
        }

        #endregion LogOff

        #region Register

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = new DBO.User()
            {
                Name = model.UserName,
                Password = model.Password,
                Email = model.Email
            };

            string result = BM.User.NewUser(user);

            if (result == string.Empty)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, true);
                return RedirectToAction("Index", "Accueil");
            }

            ModelState.AddModelError("", result);
            return View(model);
        }

        #endregion Register

        #region ChangePassword

        [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            DBO.User user = new DBO.User() { Name = User.Identity.Name, Password = model.OldPassword };

            if (BM.User.ChangePassword(user, model.NewPassword))
                return RedirectToAction("ChangePasswordSuccess");

            return View(model);
        }

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

        #endregion ChangePassword
    }
}