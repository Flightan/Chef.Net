using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer la recherche
    /// </summary>
    public static class Recherche
    {
        public static List<DBO.Recette> GetRecetteByContainsNom(string recherche)
        {
            return new List<DBO.Recette>();
        }

        public static List<DBO.User> GetUserByContainsName(string recherche)
        {
            return new List<DBO.User>();
        }

        public static List<DBO.Conseil> GetConseilByContainsNom(string recherche)
        {
            return new List<DBO.Conseil>();
        }
    }
}