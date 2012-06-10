using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    /// Class pour gérer la recherche complexe
    /// </summary>
    public class RechercheComplexeModel
    {
        /*[Required(ErrorMessage = "Le champ nom est requis.")]
           [Display(Name = "Nom")]
        public string Nom { get; set; }*/
    }
}