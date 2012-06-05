using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
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
            return DA.Note.NewNote(note);
        }

        /// <summary>
        /// Retourne la note totale de cette recette
        /// </summary>
        public static DBO.NoteTotale GetNoteTotaleByRecette(DBO.Recette recette)
        {
            List<DBO.Note> notes = DA.Note.GetNoteByRecette(recette);
            DBO.NoteTotale noteTotale = new DBO.NoteTotale();

            return noteTotale;
        }

        /// <summary>
        /// Retourne les notes de cet utilisateur
        /// </summary>
        public static List<DBO.Note> GetNoteByUser(DBO.User user)
        {
            return DA.Note.GetNoteByUser(user);
        }
    }
}