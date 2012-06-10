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
        /// <summary>
        /// Création d'un commentaire
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewCommentaire(DBO.Commentaire commentaire)
        {
            return string.Empty;
        }

        /// <summary>
        /// Retourne les commentaires de cette recette
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByRecette(DBO.Recette recette)
        {
            List<DBO.Commentaire> commentaires = new List<DBO.Commentaire>();

            commentaires.Add(TmpTest.GetCommentaire());
            commentaires.Add(TmpTest.GetCommentaire());
            commentaires.Add(TmpTest.GetCommentaire());
            commentaires.Add(TmpTest.GetCommentaire());

            return commentaires;
        }

        /// <summary>
        /// Retourne les commentaires de cet utilisateur
        /// </summary>
        public static List<DBO.Commentaire> GetCommentaireByUser(DBO.User user)
        {
            return new List<DBO.Commentaire>();
        }
    }
}