using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using web_api_anket.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web_api_anket.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
  //  [Authorize]

    public class StudentController : ControllerBase
    {

        private readonly AnketContext _context;

        public StudentController(AnketContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {


            return _context.Students.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.SaveChanges();

            return student;
        }

        // POST api/Student
        [HttpPost]
        public ActionResult<Student> PostStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id, Student model)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
/*
            student.oop = model.oop;
            student.cleancode = model.cleancode;
            student.teamwork = model.teamwork;
            student.algorithm = model.algorithm;
            student.problemSolving = model.problemSolving;

            _context.Entry(student).Property("Ad").IsModified = false;
            _context.Entry(student).Property("Soyad").IsModified = false;

            // Yenilənmiş xüsusiyyətləri qeyd edirik.
            _context.Entry(student).Property("oop").IsModified = true;
            _context.Entry(student).Property("cleancode").IsModified = true;
            _context.Entry(student).Property("teamwork").IsModified = true;
            _context.Entry(student).Property("algorithm").IsModified = true;
            _context.Entry(student).Property("problemSolving").IsModified = true;
*/
            _context.SaveChanges();

            return NoContent();
        }


        // DELETE api/Student/5
        [HttpDelete("{id}")]
        public ActionResult<Student> DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return student;
        }
    }
}
