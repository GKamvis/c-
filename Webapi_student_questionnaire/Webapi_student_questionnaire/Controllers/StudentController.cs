using Microsoft.AspNetCore.Mvc;
using Webapi_student_questionnaire.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webapi_student_questionnaire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly AnketContext _context;

        public StudentController()
        {
            _context = new AnketContext();  
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
