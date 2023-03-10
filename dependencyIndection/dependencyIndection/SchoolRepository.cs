using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly IAuthor _db;
        public SchoolRepository(IAuthor db)
        {
            _db = db;
        }




        public string GetSchoolIName()
        {
            string schoolIname = "HPS";
            return schoolIname;
        }
        public List<Author> GetAllList()
        {
            List<Author> record = _db.DepartmentListMethod();
            return record;
        }
        public string GetNameByBook(string book)
        {
            List<Author> bookName = _db.DepartmentListMethod();
            string? name = bookName.Where(x => x.Book == book).Select(x => x.Name).FirstOrDefault();
            return book;
        }
    }
}

