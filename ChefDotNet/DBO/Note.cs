using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet Note
    /// </summary>
    public class Note
    {
        public int Id { get; set; }

        public int NoteGout { get; set; }

        public int NoteOriginalite { get; set; }

        public int NotePresentation { get; set; }

        public int idUser { get; set; }

        public int idRecette { get; set; }

        public DateTime DateCreation { get; set; }

        public Note()
        {
            Id = -1;
            NoteGout = -1;
            NoteOriginalite = -1;
            NotePresentation = -1;
            idUser = -1;
            idRecette = -1;
            DateCreation = DateTime.Now;
        }
    }
}