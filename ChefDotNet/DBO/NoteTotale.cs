using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet NoteTotale, qui contient toute les note d'une recette
    /// </summary>
    public class NoteTotale
    {
        public int NoteGout { get; set; }

        public int NoteOriginalite { get; set; }

        public int NotePresentation { get; set; }

        public NoteTotale()
        {
            NoteGout = -1;
            NoteOriginalite = -1;
            NotePresentation = -1;
        }
    }
}