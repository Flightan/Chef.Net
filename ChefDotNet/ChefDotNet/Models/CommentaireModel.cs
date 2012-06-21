using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChefDotNet.Models
{
    /// <summary>
    /// Class pour gérer la création d'un commentaire
    /// </summary>
    public class CommentaireModel
    {
        [Required(ErrorMessage = "Le champ texte est requis.")]
        [Display(Name = "Texte")]
        public string Texte { get; set; }

        public int recetteId { get; set; }
    }
}