using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    /// <summary>
    /// Class pour gérer les notes
    /// </summary>
    public static class Note
    {
        /// <summary>
        /// Création d'une note
        /// </summary>
        public static bool NewNote(DBO.Note note)
        {
            return true;
        }

        /// <summary>
        /// Retourne les notes de cette recette
        /// </summary>
        public static List<DBO.Note> GetNoteByRecette(DBO.Recette recette)
        {
            return new List<DBO.Note>();
        }

        /// <summary>
        /// Retourne les notes de cet utilisateur
        /// </summary>
        public static List<DBO.Note> GetNoteByUser(DBO.User user)
        {
            return new List<DBO.Note>();
        }
    }
}