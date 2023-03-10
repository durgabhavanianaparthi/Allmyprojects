using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    public class Author
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public double Price { get; set; }



        public static List<Author> DepartmentListMethod()
        {
            //List<Author> authorList = new List<Author>
            List<Author> authorList = new()
            {
                 new Author { Name = "Human Resource", Book = "HR" },
                 new Author { Name = "Electricity", Book = "EC" },
                 new Author { Name = "Home Department", Book = "HD" },
                 new Author { Name = "Health Department", Book = "HL" },
                 new Author { Name = "Finance", Book = "FN" }
            };
            return authorList;
        }
    }
}

