using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    public interface ISchoolRepository
    {
        string GetSchoolIName();
        List<Author> GetAllList();
        string GetNameByBook(string book);
    }
}
