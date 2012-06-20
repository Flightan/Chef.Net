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
        private static CuisineEntities cuisineEntities = new CuisineEntities();

        /// <summary>
        /// Création d'une recette
        /// </summary>
        public static bool NewRecette(DBO.Recette recette)
        {
            try
            {
                T_Recette t_recette = ConvertToEntity(recette);
                t_recette.T_User = cuisineEntities.T_User.SingleOrDefault(e => e.id == recette.idCreateur);
                cuisineEntities.AddToT_Recette(t_recette);
                cuisineEntities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Création d'une recette
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewRecette(DBO.Recette recette)
        {
            try
            {
                T_Recette t_recette = ConvertToEntity(recette);
                t_recette.T_User = cuisineEntities.T_User.SingleOrDefault(e => e.id == recette.idCreateur);
                cuisineEntities.AddToT_Recette(t_recette);
                cuisineEntities.SaveChanges();
                return string.Empty;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// Retourne toutes les recettes
        /// </summary>
        public static List<DBO.Recette> GetAll()
        {
            return ConvertToDBO(cuisineEntities.T_Recette.ToList());
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
        /// Retourne une recette selon son id
        /// </summary>
        public static DBO.Recette GetRecetteById(int id)
        {
            return ConvertToDBO(cuisineEntities.T_Recette.SingleOrDefault(e => e.id == id));
        }

        /// <summary>
        /// Retourne une recette selon son nom
        /// </summary>
        public static DBO.Recette GetRecetteByNom(string nom)
        {
            return ConvertToDBO(cuisineEntities.T_Recette.SingleOrDefault(e => e.nom == nom));
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
                dbo.Difficulte = Convert.ToInt16(recette.difficulte);
                dbo.Photo = recette.photo;
                dbo.Categorie = recette.categorie;
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