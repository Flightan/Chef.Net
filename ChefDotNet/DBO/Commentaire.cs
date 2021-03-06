﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet Commentaire
    /// </summary>
    public class Commentaire
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int idUser { get; set; }

        public int idRecette { get; set; }

        public DateTime DateCreation { get; set; }

        public Commentaire()
        {
            Id = -1;
            Text = string.Empty;
            idUser = -1;
            idRecette = -1;
            DateCreation = DateTime.Now;
        }
    }
}