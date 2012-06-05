using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les ingredients
    /// </summary>
    public static class Ingredient
    {
        /// <summary>
        /// Création d'un ingrédient
        /// </summary>
        public static bool NewIngredient(DBO.Ingredient ingredient)
        {
            return true;
        }

        /// <summary>
        /// Retourne les ingredients de cette recette
        /// </summary>
        public static List<DBO.Ingredient> GetIngredientByRecette(DBO.Recette recette)
        {
            return new List<DBO.Ingredient>();
        }
    }
}