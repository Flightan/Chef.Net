using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la création d'un ingredient
    /// </summary>
    public class IngredientModel
    {
        [Required(ErrorMessage = "Le champ nom est requis.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        public int recetteId { get; set; }
    }
}