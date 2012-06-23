using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChefDotNet.Models
{
    public class NoteModel
    {
        public int recetteId { get; set; }

        public int userId { get; set; }

        public int value { get; set; }
    }
}