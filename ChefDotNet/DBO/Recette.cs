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

        public int TempsCuisson { get; set; }

        public int TempsPreparation { get; set; }

        public int TempsRepos { get; set; }

        public int Difficulte { get; set; }

        public string Categorie { get; set; }

        public string Photo { get; set; }

        public int idCreateur { get; set; }

        public Recette()
        {
            Id = -1;
            Nom = string.Empty;
            Intro = string.Empty;
            Realisation = string.Empty;
            TempsCuisson = 0;
            TempsPreparation = 0;
            TempsRepos = 0;
            Difficulte = 0;
            Categorie = string.Empty;
            Photo = string.Empty;
            idCreateur = -1;
        }
    }
}