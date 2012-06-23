using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{
    public static class Note
    {
        /// <summary>
        /// Création d'une note
        /// </summary>
        public static DBO.Note NewNote(DBO.Note note)
        {
            return new DBO.Note();
        }

        /// <summary>
        /// Retourne la note d'un utilisateur pour une recette
        /// </summary>
        public static DBO.Note GetNoteByUserForRecette(DBO.User user, DBO.Recette recette)
        {
            return null;
        }

        /// <summary>
        /// Retourne la liste des notes d'un utilisateur
        /// </summary>
        public static List<DBO.Note> GetNoteByUser(DBO.User user)
        {
            return new List<DBO.Note>();
        }

        /// <summary>
        /// Retourne la note totale de la recette
        /// </summary>
        public static int GetNoteTotaleByRecette(DBO.Recette recette)
        {
            return 1;
        }
    }
}