using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    public static class Note
    {
        /// <summary>
        /// Création d'une note
        /// </summary>
        public static string NewNote(DBO.Note note)
        {
            return DA.Note.NewNote(note);
        }

        /// <summary>
        /// Retourne la note d'un utilisateur pour une recette
        /// </summary>
        public static DBO.Note GetNoteByUserForRecette(DBO.User user, DBO.Recette recette)
        {
            return DA.Note.GetNoteByUserForRecette(user, recette);
        }

        /// <summary>
        /// Retourne la liste des notes d'un utilisateur
        /// </summary>
        public static List<DBO.Note> GetNoteByUser(DBO.User user)
        {
            return DA.Note.GetNoteByUser(user);
        }

        /// <summary>
        /// Retourne la note totale de la recette
        /// </summary>
        public static int GetNoteTotaleByRecette(DBO.Recette recette)
        {
            return DA.Note.GetNoteTotaleByRecette(recette);
        }

        /// <summary>
        /// Retourne une note totale sous forme html
        /// </summary>
        public static string GetNoteHtml(int note)
        {
            string html = "";

            string liBegin = "<li class='";
            string liEnd = "'></li>";

            string full = "star full";
            string empty = "star empty";

            for (int i = 0; i < note; i++)
                html += liBegin + full + liEnd;

            for (int i = 5; i > note; i--)
                html += liBegin + empty + liEnd;

            return html;
        }
    }
}