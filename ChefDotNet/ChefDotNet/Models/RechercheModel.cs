using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la recherche simple
    /// </summary>
    public class RechercheSimpleModel
    {
        public string Recherche { get; set; }
    }

    /// <summary>
    /// Class pour gérer la recherche avancée
    /// </summary>
    public class RechercheAvanceeModel
    {
        [Display(Name = "Texte")]
        public string RechercheComplexe { get; set; }

        [Display(Name = "Temps de confection (en minute)")]
        public Nullable<int> Temps { get; set; }

        [Display(Name = "Difficulté")]
        public SelectList DifficulteList { get; set; }

        public int DifficulteSelected { get; set; }

        [Display(Name = "Catégorie")]
        public SelectList CategorieList { get; set; }

        public int CategorieSelected { get; set; }
    }
}