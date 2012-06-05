using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet Recette
    /// </summary>
    public class Recette
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Intro { get; set; }

        public string Realisation { get; set; }

        public string Temps { get; set; }

        public string Difficulte { get; set; }

        public string Categorie { get; set; }

        public string Photo { get; set; }

        public int idCreateur { get; set; }

        public Recette()
        {
            Id = -1;
            Nom = string.Empty;
            Intro = string.Empty;
            Realisation = string.Empty;
            Temps = string.Empty;
            Difficulte = string.Empty;
            Categorie = string.Empty;
            Photo = string.Empty;
            idCreateur = -1;
        }
    }
}