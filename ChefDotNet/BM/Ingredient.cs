using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
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
            return DA.Ingredient.NewIngredient(ingredient);
        }

        /// <summary>
        /// Retourne les ingredients de cette recette
        /// </summary>
        public static List<DBO.Ingredient> GetIngredientByRecette(DBO.Recette recette)
        {
            return DA.Ingredient.GetIngredientByRecette(recette);
        }
    }
}