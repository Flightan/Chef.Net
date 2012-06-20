using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
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
            return DA.Conseil.NewConseil(conseil);
        }

        /// <summary>
        /// Retourne tout les conseils
        /// </summary>
        public static List<DBO.Conseil> GetAll()
        {
            return DA.Conseil.GetAll();
        }

        /// <summary>
        /// Retourne le conseil qui possède cet id
        /// </summary>
        public static DBO.Conseil GetConseilById(int id)
        {
            return DA.Conseil.GetConseilById(id);
        }

        /// <summary>
        /// Retourne le conseil qui possède ce nom
        /// </summary>
        public static DBO.Conseil GetConseilByNom(string nom)
        {
            return DA.Conseil.GetConseilByNom(nom);
        }

        /// <summary>
        /// Retourne les conseils créés par cet utilisateur
        /// </summary>
        public static List<DBO.Conseil> GetConseilByUser(DBO.User user)
        {
            return DA.Conseil.GetConseilByUser(user);
        }

        /// <summary>
        /// Retourne les 20 derniers conseils
        /// </summary>
        public static List<DBO.Conseil> GetConseilByDate()
        {
            return DA.Conseil.GetConseilByDate();
        }
    }
}