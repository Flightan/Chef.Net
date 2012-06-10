using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer les commentaires
    /// </summary>
    public static class Commentaire
    {
        /// <summary>
        /// Création d'un commentaire
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewCommentaire(DBO.Commentaire commentaire)
        {
            return DA.Commentaire.NewCommentaire(commentaire);
        }

        /// <summary>
        /// Retourne les commentaires de cette recette
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByRecette(DBO.Recette recette)
        {
            return DA.Commentaire.GetCommentaireByRecette(recette);
        }

        /// <summary>
        /// Retourne les commentaires de cet utilisateur
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByUser(DBO.User user)
        {
            return DA.Commentaire.GetCommentaireByUser(user);
        }
    }
}