using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBO
{
    /// <summary>
    /// Class pour contenir un objet User
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Info { get; set; }

        public User()
        {
            Id = -1;
            Name = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
            Info = string.Empty;
        }
    }
}