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
            return string.Empty;
        }

        /// <summary>
        /// Retourne tout les conseils
        /// </summary>
        public static List<DBO.Conseil> GetAll()
        {
            return new List<DBO.Conseil>();
        }

        /// <summary>
        /// Retourne le conseil qui possède cet id
        /// </summary>
        public static DBO.Conseil GetConseilById(int id)
        {
            return new DBO.Conseil();
        }

        /// <summary>
        /// Retourne le conseil qui possède ce nom
        /// </summary>
        public static DBO.Conseil GetConseilByNom(string nom)
        {
            return new DBO.Conseil();
        }

        /// <summary>
        /// Retourne les conseils créés par cet utilisateur
        /// </summary>
        public static List<DBO.Conseil> GetConseilByUser(DBO.User user)
        {
            return new List<DBO.Conseil>();
        }

        /// <summary>
        /// Retourne les 20 derniers conseils
        /// </summary>
        public static List<DBO.Conseil> GetConseilByDate()
        {
            return new List<DBO.Conseil>();
        }
    }
}