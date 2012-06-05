using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la création d'un conseil
    /// </summary>
    public class ConseilModel
    {
        [Required(ErrorMessage = "Le champ nom est requis.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le texte nom est requis.")]
        [Display(Name = "Texte")]
        public string Texte { get; set; }
    }
}