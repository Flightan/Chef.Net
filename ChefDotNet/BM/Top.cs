using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer les top affichés dans l'accueil
    /// </summary>
    public static class Top
    {
        /// <summary>
        /// Retourne les 10 meilleurs recettes
        /// </summary>
        public static List<DBO.Recette> GetTopRecettes()
        {
            List<DBO.Recette> list = DA.Recette.GetAll();
            List<DBO.Recette> topList = new List<DBO.Recette>();

            foreach (DBO.Recette recette in list)
            { }

            return topList;
        }

        /// <summary>
        /// Retourne les 10 meilleurs cuisiniers
        /// </summary>
        public static List<DBO.User> GetTopCuisiniers()
        {
            List<DBO.User> list = DA.User.GetAll();
            List<DBO.User> topList = new List<DBO.User>();

            foreach (DBO.User user in list)
            { }

            return topList;
        }
    }
}