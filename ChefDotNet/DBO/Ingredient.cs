using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet Ingredient
    /// </summary>
    public class Ingredient
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int idRecette { get; set; }

        public Ingredient()
        {
            Id = -1;
            Nom = string.Empty;
            idRecette = -1;
        }
    }
}