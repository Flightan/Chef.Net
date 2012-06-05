using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
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
            return true;
        }

        /// <summary>
        /// Retourne des recettes selon leurs id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            return TmpTest.GetRecette();
        }

        /// <summary>
        /// Retourne des recettes selon leurs noms
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            return TmpTest.GetRecette();
        }

        /// <summary>
        /// Retourne des recettes qui contiennent ces ingredients
        /// </summary>
        public static List<DBO.Recette> GetRecetteByIngredients(List<string> ingredients)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Comprises entre dureeMin et dureeMax)
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDureeWithMinAndMax(int dureeMin, int dureeMax)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Supérieures à dureeMin)
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDureeWithMin(int dureeMin)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Inférieures à dureeMax)
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDureeWithMax(int dureeMax)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs difficultes
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDifficulte(int difficulte)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leurs categories
        /// </summary>
        public static List<DBO.Recette> GetRecetteByCategories(List<string> categories)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne des recettes selon leur créateur
        /// </summary>
        public static List<DBO.Recette> GetRecetteByUser(DBO.User user)
        {
            return new List<DBO.Recette>();
        }
    }
}