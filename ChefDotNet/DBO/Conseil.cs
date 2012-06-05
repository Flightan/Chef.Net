using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet Conseil
    /// </summary>
    public class Conseil
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Text { get; set; }

        public int idCreateur { get; set; }

        public DateTime DateCreation { get; set; }

        public Conseil()
        {
            Id = -1;
            Nom = string.Empty;
            Text = string.Empty;
            idCreateur = -1;
            DateCreation = DateTime.Now;
        }
    }
}