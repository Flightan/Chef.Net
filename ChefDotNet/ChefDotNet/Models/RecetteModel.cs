using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        [Required(ErrorMessage = "Le champ temps de préparation est requis.")]
        [Display(Name = "Temps de préparation (en minute)")]
        public int TempsPreparation { get; set; }

        [Display(Name = "Temps de cuisson (en minute)")]
        public Nullable<int> TempsCuisson { get; set; }

        [Display(Name = "Temps de repos (en minute)")]
        public Nullable<int> TempsRepos { get; set; }

        [Display(Name = "Difficulté")]
        public SelectList DifficulteList { get; set; }

        [Required]
        public int DifficulteSelected { get; set; }

        [Display(Name = "Catégorie")]
        public SelectList CategorieList { get; set; }

        [Required]
        public int CategorieSelected { get; set; }

        [Display(Name = "Url de la photo")]
        public string Photo { get; set; }
    }
}