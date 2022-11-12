using System;
using System.Collections.Generic;
using System.Text;

namespace Collection.Models
{
   public class Author
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }



        public Author(string authorname, string authorsurname, int authorage)
        {
            Age = authorage;
            Name = authorname;
            Surname = authorsurname;
        }
    }
}
