using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class temporaire pour simuler l'envoie de données
    /// </summary>
    public static class TmpTest
    {
        public static DBO.Recette GetRecette()
        {
            return new DBO.Recette()
            {
                Nom = "Paris Brest",
                Intro = "intro intro intro intro intro intro intro intro intro",
                Realisation = "réa réa réa réa réa réa réa réa réa réa",
                TempsPreparation = 3,
                TempsCuisson = 2,
                TempsRepos = 1,
                Difficulte = 5,
                Categorie = "cat",
                Photo = "http://www.conseilsnutrition.tv/images/capsules/CN_57.jpg",
                idCreateur = 12
            };
        }

        public static DBO.User GetUser(string name)
        {
            return new DBO.User()
            {
                Email = "romain@gmail.com",
                Info = "blablabla",
                Name = name,
                Password = "pass"
            };
        }

        public static DBO.Ingredient GetIngredient()
        {
            return new DBO.Ingredient()
            {
                idRecette = 1,
                Nom = "pinprenelle"
            };
        }

        public static DBO.Commentaire GetCommentaire()
        {
            return new DBO.Commentaire()
            {
                Text = "Un commentaire super cool"
            };
        }
    }
}