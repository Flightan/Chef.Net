﻿using System;
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
            try
            {
                using (CuisineEntities cuisineEntities = new CuisineEntities())
                {
                    cuisineEntities.T_Recette.AddObject(ConvertToEntity(recette));
                    cuisineEntities.SaveChanges();
                    return string.Empty;
                }
            }
            catch (Exception e)
            {
                return e.InnerException.Message;
            }
        }

        /// <summary>
        /// Retourne toutes les recettes
        /// </summary>
        public static List<DBO.Recette> GetAll()
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.ToList());
            }
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Comprises entre dureeMin et dureeMax)
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDureeWithMinAndMax(int dureeMin, int dureeMax)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.Where(e => e.temps_prepa > dureeMin && e.temps_prepa < dureeMax).ToList());
            }
        }

        /// <summary>
        /// Retourne des recettes selon leurs durees (Supérieures à dureeMin)
        /// </summary>
        public static List<DBO.Recette> GetRecetteByDureeWithMin(int dureeMin)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.Where(e => e.temps_prepa > dureeMin).ToList());
            }
        }

        /// <summary>
        /// Retourne une recette selon son id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.SingleOrDefault(e => e.id == id));
            }
        }

        /// <summary>
        /// Retourne une recette selon son nom
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.SingleOrDefault(e => e.nom == nom));
            }
        }

        /// <summary>
        /// Retourne les recettes d'un utilisateur
        /// </summary>
        public static List<DBO.Recette> GetRecetteByUser(DBO.User user)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Recette.Where(e => e.id == user.Id).ToList());
            }
        }

        /// <summary>
        /// Retourne des recettes qui contiennent ces ingredients
        /// </summary>
        public static List<DBO.Recette> GetRecetteByIngredients(List<string> ingredients)
        {
            return new List<DBO.Recette>();
        }

        /// <summary>
        /// Retourne le top des recettes
        /// </summary>
        public static List<DBO.Recette> GetTopRecetteByRating(int rows)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO((from r in cuisineEntities.T_Recette
                                     from n in cuisineEntities.T_Note
                                     where r.id == n.idRecette
                                     orderby n.note
                                     select r).Take(rows).ToList());
            }
        }

        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_Recette ConvertToEntity(DBO.Recette recette)
        {
            T_Recette entity = new T_Recette();

            if (recette != null)
            {
                entity.nom = recette.Nom;
                entity.introduction = recette.Intro;
                entity.realisation = recette.Realisation;
                entity.temps_cuisson = recette.TempsCuisson;
                entity.temps_prepa = recette.TempsPreparation;
                entity.temps_repos = recette.TempsRepos;
                entity.difficulte = recette.Difficulte;
                entity.photo = recette.Photo;
                entity.categorie = recette.Categorie;
                entity.date = DateTime.Now;
                entity.createurID = recette.idCreateur;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.Recette ConvertToDBO(T_Recette recette)
        {
            DBO.Recette dbo = new DBO.Recette();

            if (recette != null)
            {
                dbo.Nom = recette.nom;
                dbo.Intro = recette.introduction;
                dbo.Realisation = recette.realisation;
                dbo.TempsCuisson = Convert.ToInt16(recette.temps_cuisson);
                dbo.TempsPreparation = recette.temps_prepa;
                dbo.TempsRepos = Convert.ToInt16(recette.temps_repos);
                dbo.Difficulte = recette.difficulte;
                dbo.Photo = recette.photo;
                dbo.Categorie = recette.categorie;
                dbo.idCreateur = Convert.ToInt16(recette.createurID);
                dbo.Id = Convert.ToInt16(recette.id);
            }

            return dbo;
        }

        /// <summary>
        /// Conversion List Entity -> DBO
        /// </summary>
        public static List<DBO.Recette> ConvertToDBO(List<T_Recette> listRecette)
        {
            List<DBO.Recette> listDbo = new List<DBO.Recette>();

            foreach (var item in listRecette)
            {
                listDbo.Add(ConvertToDBO(item));
            }

            return listDbo;
        }
    }
}