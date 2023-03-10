using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? StudentAddress { get; set; }
        public int StudentMarks { get; set; }
        
        public int? RollNo { get; set; }
        [ForeignKey("RollNo")]
        public StudentPerformance? StudentPerformance { get; set; }
    }
}
