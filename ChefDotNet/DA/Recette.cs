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
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewRecette(DBO.Recette recette)
        {
            return string.Empty;
        }

        /// <summary>
        /// Retourne toutes les recettes
        /// </summary>
        public static List<DBO.Recette> GetAll()
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne une recette selon son id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            return TmpTest.GetRecette();
        }

        /// <summary>
        /// Retourne une recette selon son nom
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            return TmpTest.GetRecette();
        }

        /// <summary>
        /// Retourne des recettes selon leurs noms
        /// </summary>
        public static List<DBO.Recette> GetRecetteByContainsNom(string nom)
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

        /// <summary>
        /// Retourne des recettes qui contiennent ces ingredients
        /// </summary>
        public static List<DBO.Recette> GetRecetteByIngredients(List<string> ingredients)
        {
            return new List<DBO.Recette>();
        }
    }
}