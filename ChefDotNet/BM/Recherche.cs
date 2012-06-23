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
            List<DBO.Recette> list = BM.Recette.GetAll();
            List<DBO.Recette> newList = new List<DBO.Recette>();

            foreach (DBO.Recette recette in list)
                if (recherche != null && recette.Nom.Contains(recherche))
                    newList.Add(recette);

            return newList;
        }

        public static List<DBO.User> GetUserByContainsName(string recherche)
        {
            List<DBO.User> list = BM.User.GetAll();
            List<DBO.User> newList = new List<DBO.User>();

            foreach (DBO.User user in list)
                if (recherche != null && user.Name.Contains(recherche))
                    newList.Add(user);

            return newList;
        }

        public static List<DBO.Conseil> GetConseilByContainsNom(string recherche)
        {
            List<DBO.Conseil> list = BM.Conseil.GetAll();
            List<DBO.Conseil> newList = new List<DBO.Conseil>();

            foreach (DBO.Conseil conseil in list)
                if (recherche != null && conseil.Nom.Contains(recherche))
                    newList.Add(conseil);

            return newList;
        }

        public static List<DBO.Recette> RechercheAvancee(string recherche, Nullable<int> temps, string categorie, string difficulte)
        {
            List<DBO.Recette> list = BM.Recette.GetAll();

            // Recherche sur le texte
            List<DBO.Recette> newList1 = new List<DBO.Recette>();
            if (recherche != null)
            {
                foreach (DBO.Recette recette in list)
                    if (recherche != null && recette.Nom.Contains(recherche))
                        newList1.Add(recette);
            }
            else
                newList1 = list;

            // Recherche sur la categorie
            List<DBO.Recette> newList2 = new List<DBO.Recette>();
            if (categorie != null && categorie != "Toutes")
            {
                foreach (DBO.Recette recette in newList1)
                    if (categorie != null && recette.Categorie.Contains(categorie))
                        newList2.Add(recette);
            }
            else
                newList2 = newList1;

            // Recherche sur la difficulte
            List<DBO.Recette> newList3 = new List<DBO.Recette>();
            if (difficulte != null && difficulte != "Toutes")
            {
                foreach (DBO.Recette recette in newList2)
                    if (difficulte != null && recette.Difficulte.Contains(difficulte))
                        newList3.Add(recette);
            }
            else
                newList3 = newList2;

            // Recherche sur le temps
            List<DBO.Recette> newList4 = new List<DBO.Recette>();
            if (temps != null)
            {
                foreach (DBO.Recette recette in newList3)
                    if (temps > 0 && BM.Recette.GetTempsTotal(recette) > temps - 20 && BM.Recette.GetTempsTotal(recette) < temps + 20)
                        newList4.Add(recette);
            }
            else
                newList4 = newList3;

            return newList4;
        }
    }
}