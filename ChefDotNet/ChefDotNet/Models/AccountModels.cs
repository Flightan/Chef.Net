using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la connexion d'un utilisateur
    /// </summary>
    public class LogOnModel
    {
        [Required(ErrorMessage = "Le champ pseudo est requis.")]
        [Display(Name = "Pseudo")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Le champ mot de passe est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Display(Name = "Se souvenir de moi ?")]
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// Class pour gérer l'enregistrement d'un utilisateur
    /// </summary>
    public class RegisterModel
    {
        [Required(ErrorMessage = "Le champ pseudo est requis.")]
        [Display(Name = "Pseudo")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Le champ email est requis.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adresse email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le champ mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "Le mot de passe doit être de 6 caractères minimum.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer mot de passe")]
        [Compare("Password", ErrorMessage = "Le mot de passe et sa confirmation sont différents.")]
        public string ConfirmPassword { get; set; }
    }

    /// <summary>
    /// Class pour gérer le changement de mot de passe
    /// </summary>
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Le champ mot de passe actuel est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe actuel")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Le champ nouveau mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "Le nouveaumot de passe doit être de 6 caractères minimum.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nouveau mot de passe")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer nouveau mot de passe")]
        [Compare("NewPassword", ErrorMessage = "Le mot de passe et sa confirmation sont différents.")]
        public string ConfirmPassword { get; set; }
    }
}