using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer les recettes
    /// </summary>
    public static class Recette
    {
        /// <summary>
        /// Création d'une recette
        /// </summary>
        public static bool NewRecette(DBO.Recette recette)
        {
            return DA.Recette.NewRecette(recette);
        }

        /// <summary>
        /// Retourne des recettes selon leurs id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            return DA.Recette.GetRecetteById(id);
        }

        /// <summary>
        /// Retourne des recettes selon leurs noms
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            return DA.Recette.GetRecetteByNom(nom);
        }

        /// <summary>
        /// Retourne des recettes qui contiennent ces ingredients
        /// </summary>
        public static List<DBO.Recette> GetRecetteByIngredients(List<string> ingredients)
        {
            return DA.Recette.GetRecetteByIngredients(ingredients);
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Comprises entre dureeMin et dureeMax)
        /// Si dureeMin < 0 , il n'y a pas de minimum
        /// Si dureeMax < 0 , il n'y a pas de maximum
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDuree(int dureeMin, int dureeMax)
        {
            if (dureeMin > 0 && dureeMax > 0)
                return DA.Recette.GetRecetteByDureeWithMinAndMax(dureeMin, dureeMax);

            if (dureeMin > 0)
                return DA.Recette.GetRecetteByDureeWithMin(dureeMin);

            if (dureeMax > 0)
                return DA.Recette.GetRecetteByDureeWithMax(dureeMax);

            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs difficultes
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDifficulte(int difficulte)
        {
            return DA.Recette.GetRecetteByDifficulte(difficulte);
        }

        /// <summary>
        /// Retourne des recettes selon leurs categories
        /// </summary>
        public static List<DBO.Recette> GetRecetteByCategories(List<string> categories)
        {
            return DA.Recette.GetRecetteByCategories(categories);
        }

        /// <summary>
        /// Retourne des recettes selon leur créateur
        /// </summary>
        public static List<DBO.Recette> GetRecetteByUser(DBO.User user)
        {
            return DA.Recette.GetRecetteByUser(user);
        }
    }
}