using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Data;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Model;
using ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETCore_WebApi_With_EFCoreUsing_StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentControler : ControllerBase
    {
        //private readonly StudentContext _studentContext; 
        //public StudentControler (StudentContext studentContext)
        //{
        //    _studentContext = studentContext;
        //}
        private readonly IDataRepository<Student> _StudentRepository;
        public StudentControler(IDataRepository<Student> StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }


        // GET: api/<StudentControler>
        [HttpGet]
        //public IEnumerable<Student> Get()
        //{
        //    return _studentContext.Students;
        //}
        public IActionResult Get()
        {
            IEnumerable<Student> obj = _StudentRepository.GetAll();
            return Ok(obj);
        }
        //comment

        // GET api/<StudentControler>/5
        [HttpGet("{id}")]
        //public Student Get(int id)
        //{
        //    var student = _studentContext.Students.Find(id);
        //    return student;
        //}
        public IActionResult Get(int id)
        {
            Student obj = _StudentRepository.Get(id);

            if (obj == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            return Ok(obj);
        }

        // POST api/<StudentControler>
        [HttpPost]
        //public void Post([FromBody] Student student)
        //{
        //    var result = _studentContext.Students.Add(student);

        //    _studentContext.SaveChanges();
        //}
        public IActionResult Post([FromBody] Student obj)
        {
            if (obj == null)
            {
                return BadRequest("Student is Null");
            }
            _StudentRepository.Add(obj);
            //return CreatedAtRoute(
            //    "Get",
            //    new { Id = obj.StudentId },
            //    obj);
            return Ok(obj);
        }

        // PUT api/<StudentControler>/5
        [HttpPut("{id}")]
        //public void Put(int   id, [FromBody] Student student)
        //{
        //    var ID = _studentContext.Students.Find(id);
        //    ID.StudentName  = student.StudentName;
        //    ID.StudentAddress = student.StudentAddress;
        //    ID.StudentMarks = student.StudentMarks;
        //    ID.DateOfBirth = student.DateOfBirth;

        //    _studentContext.SaveChanges(); 

        //}
        public IActionResult Put(int id, [FromBody] Student obj)
        {
            if (obj == null)
            {
                return BadRequest("Student is Null");
            }

            Student StudentUpdate = _StudentRepository.Get(id);
             if (StudentUpdate == null)
             {
                return NotFound("The Student record couldn't be found.");
             }
            _StudentRepository.Update(StudentUpdate, obj);
              return NoContent();
        }




        // DELETE api/<StudentControler>/5
        [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var ID = _studentContext.Students.Find(id);
        //    _studentContext.Students.Remove(ID);
        //    _studentContext.SaveChanges();

        //}

        public IActionResult Delete(int id)
        {
            Student removeStudent = _StudentRepository.Get(id);
            if (removeStudent == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            _StudentRepository.Delete(removeStudent);
            return NoContent();
        }


    }
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPerformanceControler : ControllerBase
    {
        private readonly IDataRepository<StudentPerformance> _StudentRepository;
        public StudentPerformanceControler(IDataRepository<StudentPerformance> StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<StudentPerformance> obj = _StudentRepository.GetAll();
            return Ok(obj);
        }

        [HttpGet("{id}")]
        //public Student Get(int id)
        //{
        //    var student = _studentContext.Students.Find(id);
        //    return student;
        //}
        public IActionResult Get(int id)
        {
            StudentPerformance obj = _StudentRepository.Get(id);

            if (obj == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            return Ok(obj);
        }
        [HttpPost]
        //public void Post([FromBody] Student student)
        //{
        //    var result = _studentContext.Students.Add(student);

        //    _studentContext.SaveChanges();
        //}
        public IActionResult Post([FromBody] StudentPerformance obj)
        {
            if (obj == null)
            {
                return BadRequest("Student is Null");
            }
            _StudentRepository.Add(obj);
            return Ok(obj);
        }
        [HttpPut("{id}")]
        //public void Put(int   id, [FromBody] Student student)
        //{
        //    var ID = _studentContext.Students.Find(id);
        //    ID.StudentName  = student.StudentName;
        //    ID.StudentAddress = student.StudentAddress;
        //    ID.StudentMarks = student.StudentMarks;
        //    ID.DateOfBirth = student.DateOfBirth;

        //    _studentContext.SaveChanges(); 

        //}
        public IActionResult Put(int id, [FromBody] StudentPerformance obj)
        {
            if (obj == null)
            {
                return BadRequest("Student is Null");
            }

            StudentPerformance StudentUpdate = _StudentRepository.Get(id);
            if (StudentUpdate == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            _StudentRepository.Update(StudentUpdate, obj);
            return NoContent();
        }
        [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var ID = _studentContext.Students.Find(id);
        //    _studentContext.Students.Remove(ID);
        //    _studentContext.SaveChanges();

        //}

        public IActionResult Delete(int id)
        {
            StudentPerformance removeStudent = _StudentRepository.Get(id);
            if (removeStudent == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            _StudentRepository.Delete(removeStudent);
            return NoContent();
        }



    }
}







    

