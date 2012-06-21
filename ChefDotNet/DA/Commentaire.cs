using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les commentaires
    /// </summary>
    public static class Commentaire
    {
        private static CuisineEntities cuisineEntities = new CuisineEntities();

        /// <summary>
        /// Création d'un commentaire
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewCommentaire(DBO.Commentaire commentaire)
        {
            try
            {
                cuisineEntities.AddToT_Commentaire(ConvertToEntity(commentaire));
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
        /// Retourne les commentaires de cette recette
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByRecette(DBO.Recette recette)
        {
            return ConvertToDBO(cuisineEntities.T_Commentaire.Where(e => e.recetteID == recette.Id).ToList());
        }

        /// <summary>
        /// Retourne les commentaires de cet utilisateur
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByUser(DBO.User user)
        {
            return ConvertToDBO(cuisineEntities.T_Commentaire.Where(e => e.utilisateurID == user.Id).ToList());
        }


        /// <summary>
        /// Conversion DBO -> Entity
        /// </summary>
        public static T_Commentaire ConvertToEntity(DBO.Commentaire commentaire)
        {
            T_Commentaire entity = new T_Commentaire();

            if (commentaire != null)
            {
                entity.texte = commentaire.Text;
                entity.utilisateurID = commentaire.idUser;
                entity.recetteID = commentaire.idRecette;
            }

            return entity;
        }

        /// <summary>
        /// Conversion Entity -> DBO
        /// </summary>
        public static DBO.Commentaire ConvertToDBO(T_Commentaire commentaire)
        {
            DBO.Commentaire dbo = new DBO.Commentaire();

            if (commentaire != null)
            {
                dbo.Id = Convert.ToInt16(commentaire.id);
                dbo.Text = commentaire.texte;
                dbo.idRecette = Convert.ToInt16(commentaire.recetteID);
                dbo.idUser = Convert.ToInt16(commentaire.utilisateurID);
            }

            return dbo;
        }

        /// <summary>
        /// Conversion List Entity -> DBO
        /// </summary>
        public static List<DBO.Commentaire> ConvertToDBO(List<T_Commentaire> listCommentaire)
        {
            List<DBO.Commentaire> listDbo = new List<DBO.Commentaire>();

            foreach (var item in listCommentaire)
            {
                listDbo.Add(ConvertToDBO(item));
            }

            return listDbo;
        }
    }
}