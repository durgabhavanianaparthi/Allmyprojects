using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Student> Studentss { get; set; }
        public DbSet<StudentPerformance> StudentPerformances { get; set; }
    }

}

