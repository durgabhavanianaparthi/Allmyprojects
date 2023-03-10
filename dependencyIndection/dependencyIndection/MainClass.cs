using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    public class MainClass
    {
        private readonly ISchoolRepository _schoolIRepository;
        public MainClass(ISchoolRepository schoolIRepository)
        {
            _schoolIRepository = schoolIRepository;
        }
        public string GetSchoolINames()
        {
            string schoolIName = _schoolIRepository.GetSchoolIName();
            return schoolIName;
        }
        public List<Author> GetAllLists()
        {
            List<Author> authorList = _schoolIRepository.GetAllList();
            return authorList;
        }
        public string GetNameByBook()
        {
            string bookName = "HR";
            string bookNames = _schoolIRepository.GetNameByBook(bookName);
            return bookNames;
        }
    }
}
