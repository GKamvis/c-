using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using web_api_anket_mvc.Models;

namespace web_api_anket_mvc.Controllers
{
    public class QuestionController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:5253/api");
        private readonly HttpClient _client;

        public QuestionController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }


        // GET: QuestionController
        [HttpGet]
        public IActionResult Index()
        {
            List<QuestionViewModel> questionList = new List<QuestionViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Question/GetQuestions").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                questionList = JsonConvert.DeserializeObject<List<QuestionViewModel>>(data);
            }
            return View(questionList);
        }






        // GET: QuestionController
        public async Task<IActionResult> Details(int studentNumber)
        {
            List<QuestionViewModel> questionList = new List<QuestionViewModel>();
            HttpResponseMessage response = await _client.GetAsync($"/api/Question/GetQuestionsByStudent/{studentNumber}");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                questionList = JsonConvert.DeserializeObject<List<QuestionViewModel>>(data);
            }
            else
            {
                // Xəta mesajını göstərmək üçün bir şeylər əlavə edin
                return View("Error");
            }

            return View(questionList);
        }




















        // GET: QuestionController
        public async Task<IActionResult> GetScore(int studentNumber)
        {
            List<StudentAverageScore> ScoreList = new List<StudentAverageScore>();
            HttpResponseMessage response = await _client.GetAsync($"/api/Question/GetStudentAverageScore/{studentNumber}");

            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                ScoreList = JsonConvert.DeserializeObject<List<StudentAverageScore>>(data);
            }
            else
            {
                // Xəta mesajını göstərmək üçün bir şeylər əlavə edin
                return View("Error");
            }

            return View(ScoreList);
        }





        // POST: QuestionController/Create
        [HttpPost]
        
        public async Task<ActionResult> Create(int studentNumber, List<string> questionTexts)
        {
            var content = new StringContent(JsonConvert.SerializeObject(questionTexts), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync($"/api/Question/{studentNumber}/{questionTexts.Count}", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index), new { studentNumber = studentNumber });
            }
            else
            {
                // Xəta mesajını göstərmək üçün bir şeylər əlavə edin
                return View();
            }
        }

        /*  // PUT: QuestionController/Edit 
          [HttpPost]
          [ValidateAntiForgeryToken]
          public async Task<ActionResult> Edit(int studentNumber, List<ScoreUpdateDto> scoresToUpdate)
          {
              // JSON olaraq serializasiya edilmiş `scoresToUpdate` siyahısını yaradırıq
              var content = new StringContent(JsonConvert.SerializeObject(scoresToUpdate), Encoding.UTF8, "application/json");

              // API-nizə HTTP PUT istəyi göndərilir
              HttpResponseMessage response = await _client.PutAsync($"/api/Question/UpdateScores/{studentNumber}", content);

              if (response.IsSuccessStatusCode)
              {
                  // Yeniləmə uğurlu olduqda, istifadəçini Index səhifəsinə yönləndiririk
                  return RedirectToAction(nameof(Index), new { studentNumber = studentNumber });
              }
              else
              {
                  // Xəta baş verərsə, istifadəçiyə xəta mesajı göstərilir
                  ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                  return View(); // Cari səhifəyə xəta mesajı ilə qayıdır
              }
          }

          [HttpGet]
          public IActionResult Edit(int studentNumber)
          {
              // GET metodunun işləməsi üçün kodlar
              return View();
          }*/





        [HttpGet]
        public async Task<IActionResult> Edit(int studentNumber, List<ScoreUpdateDto> scoresToUpdate)
        {
            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(scoresToUpdate), Encoding.UTF8, "application/json");

                ScoreUpdateDto student = new ScoreUpdateDto();
               // HttpResponseMessage response = await _client.PutAsync($"/api/Question/UpdateScores/{studentNumber}", content);
                HttpResponseMessage response = await _client.GetAsync($"/api/Question/GetQuestionsByStudent/{studentNumber}");

                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<ScoreUpdateDto>(data);
                }
                return View(student);
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
        }


        [HttpPost]
        public IActionResult Edit(ScoreUpdateDto model)
        {
            try
            {
                ModelState.Remove("Ad");
                ModelState.Remove("Soyad");

                if (ModelState.IsValid)
                {
                    string data = JsonConvert.SerializeObject(model);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Student/PutStudent/" + model.QuestionId, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        TempData["successMessage"] = "Student details updated.";
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
            }
            return View(model);
        }






















    }
}
