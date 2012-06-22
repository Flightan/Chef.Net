using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les conseils
    /// </summary>
    public static class Conseil
    {
        /// <summary>
        /// Création d'un conseil
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewConseil(DBO.Conseil conseil)
        {
            try
            {
                using (CuisineEntities cuisineEntities = new CuisineEntities())
                {
                    cuisineEntities.T_Conseil.AddObject(ConvertToEntity(conseil));
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
        /// Retourne tout les conseils
        /// </summary>
        public static List<DBO.Conseil> GetAll()
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Conseil.ToList());
            }
        }

        /// <summary>
        /// Retourne le conseil qui possède cet id
        /// </summary>
        public static DBO.Conseil GetConseilById(int id)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Conseil.SingleOrDefault(e => e.id == id));
            }
        }

        /// <summary>
        /// Retourne le conseil qui possède ce nom
        /// </summary>
        public static DBO.Conseil GetConseilByNom(string nom)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Conseil.SingleOrDefault(e => e.nom == nom));
            }
        }

        /// <summary>
        /// Retourne les conseils créés par cet utilisateur
        /// </summary>
        public static List<DBO.Conseil> GetConseilByUser(DBO.User user)
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Conseil.Where(e => e.idCreateur == user.Id).ToList());
            }
        }

        /// <summary>
        /// Retourne les 20 derniers conseils
        /// </summary>
        public static List<DBO.Conseil> GetConseilByDate()
        {
            using (CuisineEntities cuisineEntities = new CuisineEntities())
            {
                return ConvertToDBO(cuisineEntities.T_Conseil.OrderByDescending(e => e.dateCreation).Take(20).ToList());
            }
        }

        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_Conseil ConvertToEntity(DBO.Conseil conseil)
        {
            T_Conseil entity = new T_Conseil();

            if (conseil != null)
            {
                entity.nom = conseil.Nom;
                entity.idCreateur = conseil.idCreateur;
                entity.texte = conseil.Text;
                entity.dateCreation = conseil.DateCreation;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.Conseil ConvertToDBO(T_Conseil conseil)
        {
            DBO.Conseil dbo = new DBO.Conseil();

            if (conseil != null)
            {
                dbo.Nom = conseil.nom;
                dbo.idCreateur = Convert.ToInt16(conseil.idCreateur);
                dbo.Id = Convert.ToInt16(conseil.id);
                dbo.Text = conseil.texte;
                dbo.DateCreation = Convert.ToDateTime(conseil.dateCreation);
            }

            return dbo;
        }

        /// <summary>
        /// Conversion List Entity -> DBO
        /// </summary>
        public static List<DBO.Conseil> ConvertToDBO(List<T_Conseil> listConseil)
        {
            List<DBO.Conseil> listDbo = new List<DBO.Conseil>();

            foreach (var item in listConseil)
            {
                listDbo.Add(ConvertToDBO(item));
            }

            return listDbo;
        }
    }
}