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
        public static string NewIngredient(DBO.Ingredient ingredient)
        {
            try
            {
                using (CuisineEntities cuisineEntities = new CuisineEntities())
                {
                    T_Ingredient item = cuisineEntities.T_Ingredient.SingleOrDefault(e => e.nom == ingredient.Nom);
                    if (item == null)
                    {
                        cuisineEntities.T_Ingredient.AddObject(ConvertToEntity(ingredient));
                        cuisineEntities.SaveChanges();
                    }
                    T_RecetteIngredient ring = new T_RecetteIngredient();
                    ring.ingredientID = cuisineEntities.T_Ingredient.SingleOrDefault(e => e.nom == ingredient.Nom).id;
                    ring.recetteID = ingredient.idRecette;
                    cuisineEntities.T_RecetteIngredient.AddObject(ring);
                    cuisineEntities.SaveChanges();
                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// Retourne les ingredients de cette recette
        /// </summary>
        public static List<DBO.Ingredient> GetIngredientByRecette(DBO.Recette recette)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                List<T_Ingredient> ingredients = new List<T_Ingredient>();
                foreach (T_RecetteIngredient item in cuisineEntities.T_RecetteIngredient.Where(e => e.recetteID == recette.Id).ToList())
                {
                    ingredients.Add(item.T_Ingredient);
                }
                return ConvertToDBO(ingredients);
            }
        }

        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_Ingredient ConvertToEntity(DBO.Ingredient ingredient)
        {
            T_Ingredient entity = new T_Ingredient();

            if (ingredient != null)
            {
                entity.nom = ingredient.Nom;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.Ingredient ConvertToDBO(T_Ingredient ingredient)
        {
            DBO.Ingredient dbo = new DBO.Ingredient();

            if (ingredient != null)
            {
                dbo.Nom = ingredient.nom;
                dbo.Id = Convert.ToInt16(ingredient.id);
            }

            return dbo;
        }

        /// <summary>
        /// Conversion List Entity -> DBO
        /// </summary>
        public static List<DBO.Ingredient> ConvertToDBO(List<T_Ingredient> listIngredient)
        {
            List<DBO.Ingredient> listDbo = new List<DBO.Ingredient>();

            foreach (var item in listIngredient)
            {
                listDbo.Add(ConvertToDBO(item));
            }

            return listDbo;
        }
    }
}