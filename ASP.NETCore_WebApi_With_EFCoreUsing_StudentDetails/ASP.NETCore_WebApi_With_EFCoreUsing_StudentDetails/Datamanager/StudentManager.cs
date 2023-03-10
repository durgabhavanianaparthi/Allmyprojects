using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Repository;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Datamanager
{
    public class StudentManager : IDataRepository<Student>
    {
        readonly StudentContext _studentContext;
        public StudentManager(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public IEnumerable<Student> GetAll()
        {
            return _studentContext.Studentss.Include("StudentPerformance").ToList();
        }
        public Student Get(int id)
        {
            return _studentContext.Studentss
                  .FirstOrDefault(e => e.StudentId == id);//doubt 
        }
        public void Add(Student entity)
        {
            _studentContext.Studentss.Add(entity);
            _studentContext.SaveChanges();
        }

        public void Update(Student dbEntity, Student entity)//doubt
        {
            dbEntity.StudentName = entity.StudentName;

            dbEntity.StudentAddress = entity.StudentAddress;
            dbEntity.DateOfBirth = entity.DateOfBirth;
            dbEntity.StudentMarks = entity.StudentMarks;
            _studentContext.SaveChanges();
        }

        public void Delete(Student entity)
        {
            _studentContext.Studentss.Remove(entity);
            _studentContext.SaveChanges();
        }
    }

}
