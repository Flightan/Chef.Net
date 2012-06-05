using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les utilisateurs
    /// </summary>
    public static class User
    {
        /// <summary>
        /// Création d'un utilisateur
        /// </summary>
        public static bool NewUser(DBO.User user)
        {
            return true;
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède ce nom
        /// </summary>
        public static DBO.User GetUserByName(string name)
        {
            return TmpTest.GetUser(name);
        }

        /// <summary>
        /// Retourne l'utilisateur qui possède cet id
        /// </summary>
        public static DBO.User GetUserById(int id)
        {
            return TmpTest.GetUser("Test");
        }

        /// <summary>
        /// Retourne true si le pseudo et le mot de passe sont valide
        /// </summary>
        public static bool IsValid(DBO.User user)
        {
            return true;
        }

        /// <summary>
        /// Change le mot de passe de l'utilisateur
        /// </summary>
        public static bool ChangePassword(DBO.User user, string newPassword)
        {
            return true;
        }
    }
}