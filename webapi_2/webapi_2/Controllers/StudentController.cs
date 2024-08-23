using Microsoft.AspNetCore.Mvc;
using webapi_2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace webapi_2.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly KamDbContext _context;

        public StudentController(KamDbContext context)
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

            ModelState.Remove("Ortalama");

            // Hesablanan orta qiyməti 'ortalama' adlı sütuna yazın
            //student.Ortalama = (student.oop + student.cleancode + student.problemSolving + student.teamwork + student.algorithm) / 5.0;

            // Dəyişiklikləri məlumat bazasına yazın
            _context.SaveChanges();

            return student;
        }

        // POST api/Student
        [HttpPost]
        public ActionResult<Student> PostStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return CreatedAtAction("GetStudent", new { id = student.id }, student);

        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id, Student model)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

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
