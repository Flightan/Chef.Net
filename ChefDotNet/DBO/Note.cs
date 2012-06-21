using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    public class Note
    {
        public int NoteId { get; set; }

        public int NoteRecette { get; set; }

        public int idRecette { get; set; }

        public int idUser { get; set; }
    }
}