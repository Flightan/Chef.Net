using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    /// <summary>
    /// Class pour gérer les utilisateurs
    /// </summary>
    public static class User
    {
        /// <summary>
        /// Création d'un utilisateur
        /// Retourne un string vide si tout s'est bien passé, une string contenant les erreurs sinon
        /// </summary>
        public static string NewUser(DBO.User user)
        {
            return DA.User.NewUser(user);
        }

        /// <summary>
        /// Retourne tout les utilisateurs (Utilisé pour le top cuisinier)
        /// </summary>
        public static List<DBO.User> GetAll()
        {
            return DA.User.GetAll();
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède cet id
        /// </summary>
        public static DBO.User GetUserById(int id)
        {
            return DA.User.GetUserById(id);
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède ce nom
        /// </summary>
        public static DBO.User GetUserByName(string name)
        {
            return DA.User.GetUserByName(name);
        }

        /// <summary>
        /// Retourne les utilisateurs qui possède ce nom
        /// </summary>
        public static List<DBO.User> GetUserByContainsName(string name)
        {
            return DA.User.GetUserByContainsName(name);
        }

        /// <summary>
        /// Retourne true si le pseudo et le mot de passe sont valide
        /// </summary>
        public static bool IsValid(DBO.User user)
        {
            return DA.User.IsValid(user);
        }

        /// <summary>
        /// Change le mot de passe de l'utilisateur
        /// </summary>
        public static bool ChangePassword(DBO.User user, string newPassword)
        {
            return DA.User.ChangePassword(user, newPassword);
        }
    }
}