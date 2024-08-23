using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using web_api_anket.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace web_api_anket.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   // [Authorize]
    public class QuestionController : ControllerBase
    {
        private readonly AnketContext _context;

        public QuestionController(AnketContext context)
        {
            _context = context;
        }

        // POST: api/Question/{studentNumber}/{questionCount}
        [HttpPost("{studentNumber}/{questionCount}")]
        public ActionResult PostQuestions(int studentNumber, int questionCount, [FromBody] List<string> questionTexts)
        {
            if (questionTexts.Count != questionCount)
            {
                return BadRequest("Sual sayı və daxil edilmiş sualların sayı uyğun gəlmir.");
            }

            var student = _context.Students.FirstOrDefault(s => s.StudentNumber == studentNumber);
            if (student == null)
            {
                return NotFound($"Student number {studentNumber} ilə şagird tapılmadı.");
            }

            foreach (var text in questionTexts)
            {
                var question = new Question
                {
                    StudentNumber = studentNumber,
                    QuestionText = text
                };
                _context.Questions.Add(question);
            }
            _context.SaveChanges();

            return Ok("Suallar uğurla əlavə edildi.");
        }


        // GET: api/Question
        [HttpGet]
        public ActionResult<IEnumerable<Question>> GetQuestions()
        {
            return _context.Questions.ToList();
        }


        [HttpGet("{studentNumber}")]
        public ActionResult<List<Question>> GetQuestionsByStudent(int studentNumber)
        {
            var questions = _context.Questions
                .Where(q => q.StudentNumber == studentNumber)
                .Select(q => new Question
                {
                    QuestionId = q.QuestionId,
                    StudentNumber = q.StudentNumber,
                    QuestionText = q.QuestionText, // Digər xüsusiyyətləri təyin edin
                    Responses = _context.Responses.Where(r => r.QuestionId == q.QuestionId && r.StudentNumber == studentNumber).ToList()
                })
                .ToList();

            if (questions == null || questions.Count == 0)
            {
                return NotFound($"Student number {studentNumber} üçün sual tapılmadı.");
            }

            return questions;
        }

        /*      // PUT: api/Question/{studentNumber}/{questionId}
              [HttpPut("{studentNumber}/{questionId}")]
              public ActionResult UpdateResponse(int studentNumber, int questionId, [FromBody] double score)
              {
                  var response = _context.Responses.FirstOrDefault(r => r.StudentNumber == studentNumber && r.QuestionId == questionId);

                  if (response == null)
                  {
                      // Cavab tapılmadı, yeni bir cavab yaradılır
                      response = new Response
                      {
                          StudentNumber = studentNumber,
                          QuestionId = questionId,
                          Score = score
                      };
                      _context.Responses.Add(response);
                  }
                  else
                  {
                      // Cavab tapıldı, mövcud cavab yenilənir
                      response.Score = score;
                  }

                  _context.SaveChanges();

                  return Ok("Cavab uğurla yeniləndi və ya əlavə edildi.");
              }


      */

            // PUT: api/Question/UpdateScores/{studentNumber}
            [HttpPut("UpdateScores/{studentNumber}")]
            public ActionResult UpdateScores(int studentNumber, [FromBody] List<ScoreUpdateDto> scoresToUpdate)
            {
                var questions = _context.Questions.Where(q => q.StudentNumber == studentNumber).ToList();

                if (questions == null || questions.Count == 0)
                {
                    return NotFound($"Student number {studentNumber} ilə şagirdin sualları tapılmadı.");
                }

                foreach (var scoreUpdate in scoresToUpdate)
                {
                    var question = questions.FirstOrDefault(q => q.QuestionId == scoreUpdate.QuestionId);
                    if (question != null)
                    {
                        var response = _context.Responses.FirstOrDefault(r => r.QuestionId == scoreUpdate.QuestionId && r.StudentNumber == studentNumber);
                        if (response == null)
                        {
                            // Cavab tapılmadı, yeni bir cavab yaradılır
                            _context.Responses.Add(new Response
                            {
                                StudentNumber = studentNumber,
                                QuestionId = scoreUpdate.QuestionId,
                                Score = scoreUpdate.Score
                            });
                        }
                        else
                        {
                            // Cavab tapıldı, mövcud cavab yenilənir
                            response.Score = scoreUpdate.Score;
                        }
                    }
                }

                _context.SaveChanges();

                return Ok("Cavablar uğurla yeniləndi.");
            }

            public class ScoreUpdateDto
            {
                public int QuestionId { get; set; }
                public double Score { get; set; }
            }


        // GET: api/StudentScores
        [HttpGet("StudentScores")]
        public async Task<ActionResult<IEnumerable<StudentAverageScore>>> GetStudentAverageScores()
        {
            var studentScores = await _context.Responses
                .GroupBy(r => r.StudentNumber)
                .Select(group => new StudentAverageScore
                {
                    StudentNumber = group.Key,
                    AverageScore = group.Average(r => r.Score)
                })
                .ToListAsync();

            return studentScores;
        }
        public class StudentAverageScore
        {
            public int? StudentNumber { get; set; }
            public double? AverageScore
            {
                get { return _averageScore.HasValue ? _averageScore.Value : 0.0; }
                set { _averageScore = value; }
            }
            private double? _averageScore;
        }

        // GET: api/StudentScores/5
        [HttpGet("StudentScores/{studentNumber}")]
        public async Task<ActionResult<StudentAverageScore>> GetStudentAverageScore(int studentNumber)
        {
            var studentScore = await _context.Responses
                .Where(r => r.StudentNumber == studentNumber)
                .GroupBy(r => r.StudentNumber)
                .Select(group => new StudentAverageScore
                {
                    StudentNumber = group.Key,
                    AverageScore = group.Average(r => r.Score)
                })
                .FirstOrDefaultAsync();

            if (studentScore == null)
            {
                return NotFound();
            }

            return studentScore;
        }


    }
}

