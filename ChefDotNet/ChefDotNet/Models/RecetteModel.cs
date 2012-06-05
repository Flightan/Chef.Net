using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la création d'une recette
    /// </summary>
    public class RecetteModel
    {
        [Required(ErrorMessage = "Le champ nom est requis.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le champ introduction est requis.")]
        [Display(Name = "Introduction")]
        public string Intro { get; set; }

        [Required(ErrorMessage = "Le champ réalisation est requis.")]
        [Display(Name = "Réalisation")]
        public string Realisation { get; set; }

        [Required(ErrorMessage = "Le champ temps est requis.")]
        [Display(Name = "Temps")]
        public string Temps { get; set; }

        [Required(ErrorMessage = "Le champ difficulté est requis.")]
        [Display(Name = "Difficulté")]
        public string Difficulte { get; set; }

        [Required(ErrorMessage = "Le champ catégorie est requis.")]
        [Display(Name = "Catégorie")]
        public string Categorie { get; set; }

        [Display(Name = "Url de la photo")]
        public string Photo { get; set; }
    }
}