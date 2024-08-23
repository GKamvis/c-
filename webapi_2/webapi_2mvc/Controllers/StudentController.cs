using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using webapi_2mvc.Models;

namespace webapi_2mvc.Controllers
{
    public class StudentController : Controller
    {

        Uri baseAddress = new Uri("https://localhost:7276/api");

        private readonly HttpClient _client;

        public StudentController()
        {
            _client = new HttpClient(); 
            _client.BaseAddress = baseAddress;

        }

        [HttpGet]
        public IActionResult Index()
        {
            List<StudentviewModel> studentList = new List<StudentviewModel>();
            //'https://localhost:7276/api/Student'
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Student/GetStudients").Result;

            if (response.IsSuccessStatusCode)
            {
                    string data = response.Content.ReadAsStringAsync().Result;
                studentList = JsonConvert.DeserializeObject<List<StudentviewModel>>(data);
            }
            return View(studentList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentviewModel model)
        {
            try
            {
                string data = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _client.PostAsync(_client.BaseAddress + "/Student/PostStudent", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    TempData["successMessage"] = " Student Created.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                StudentviewModel student = new StudentviewModel();
                HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/student/GetStudent/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    student = JsonConvert.DeserializeObject<StudentviewModel>(data);
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
        public IActionResult Edit(StudentviewModel model)
        {
            try
            {
                ModelState.Remove("Ad");
                ModelState.Remove("Soyad");

                if (ModelState.IsValid)
                {
                    string data = JsonConvert.SerializeObject(model);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Student/PutStudent/" + model.id, content).Result;
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
