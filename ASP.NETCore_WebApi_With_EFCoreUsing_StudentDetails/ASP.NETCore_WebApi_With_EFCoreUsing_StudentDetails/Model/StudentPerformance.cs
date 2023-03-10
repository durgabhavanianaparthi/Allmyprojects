using System.ComponentModel.DataAnnotations;

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model
{
    public class StudentPerformance
    {
       [Key]
        public int RollNo { get; set; }
        public string? Grade { get; set; }
        public string? Performance { get; set; }
        public string? ExamType { get; set;}
       

    }
}
