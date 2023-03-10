using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Repository;

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Datamanager
{
    public class StudentPerformanceManager : IDataRepository<StudentPerformance>
    {
        readonly StudentContext _studentContext;
        public StudentPerformanceManager(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public void Add(StudentPerformance entity)
        {
            _studentContext.StudentPerformances.Add(entity);
            _studentContext.SaveChanges();
        }

        public void Delete(StudentPerformance entity)
        {
            _studentContext.StudentPerformances.Remove(entity);
            _studentContext.SaveChanges();
        }

        public StudentPerformance Get(int id)
        {
            return _studentContext.StudentPerformances .FirstOrDefault(e => e.RollNo == id);
        }

        public IEnumerable<StudentPerformance> GetAll()
        {
            return _studentContext.StudentPerformances.ToList();
        }

        public void Update(StudentPerformance dbEntity, StudentPerformance entity)
        {
            dbEntity.RollNo = entity.RollNo;
            dbEntity.Grade = entity.Grade;
            dbEntity.Performance = entity.Performance;
            dbEntity.ExamType = entity.ExamType;
            _studentContext.SaveChanges();
        }
    }
}
