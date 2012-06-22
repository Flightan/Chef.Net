using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BM
{
    public static class Note
    {
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