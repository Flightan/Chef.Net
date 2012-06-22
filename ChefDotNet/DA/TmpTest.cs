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
                Intro = "Introduction à la recette. Description brève, idées d’accompagnement, occasion de la réaliser... La noix de Saint-Jacques sur son lit de poireaux la noix de Saint-Jacques sur son lit la noix de Saint-Jacques sur son lit de poireaux fondus. La noix de Saint-Jacques sur son lit de poireaux fondus. La noix de Jacques sur son lit de poireaux fondus a noix de Saint-Jacques sur son lit de poireaux fondus.",
                Realisation = "1. Débarrasser le poisson de la peau et des arrêtes puis émietter la chaire dans une jatte. Ajouter le fromage frais et la sauce au raifort, puis mélanger soigneusement jusqu’à ce que le mélange soit homogène. 2. Ajouter le jus de citron consciencieusement et le poivre du moulin selon la convenance. 3. Garnir de citron vert et de brins de romarin. Servir avec une salade verte et de fines tranches de pain grillé.",
                TempsPreparation = 3,
                Difficulte = 3,
                Categorie = "Dessert",
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
                Nom = "pimprenelle"
            };
        }

        public static DBO.Commentaire GetCommentaire()
        {
            return new DBO.Commentaire()
            {
                Text = "Un commentaire super cool",
                idUser = 0
            };
        }
    }
}