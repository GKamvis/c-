using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;
using web_api_anket_mvc.Models;

namespace web_api_anket_mvc.Controllers
{
    public class StudentController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:5253/api");
        private readonly HttpClient _client;


        public StudentController()

        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }
        // GET: StudentController
        [HttpGet]
        public IActionResult Index()
        {
            List<StudentViewModel> studentList = new List<StudentViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/Student/GetStudents").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                studentList = JsonConvert.DeserializeObject<List<StudentViewModel>>(data);
            }
            return View(studentList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentViewModel model)
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
        /*     
                [HttpGet]
                public IActionResult Edit(StudentViewModel model1)
                {
                    try
                    {
                        StudentViewModel student = new StudentViewModel();
                        HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/student/GetStudent/" + model1.StudentNumber).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            string data = response.Content.ReadAsStringAsync().Result;
                            student = JsonConvert.DeserializeObject<StudentViewModel>(data);
                        }
                        return View(student);
                    }
                    catch (Exception ex)
                    {
                        TempData["errorMessage"] = ex.Message;
                        return View();
                    }
                }*/


        [HttpPost]
        public IActionResult Edit(StudentViewModel model)
        {
            try
            {
                ModelState.Remove("Ad");
                ModelState.Remove("Soyad");

                if (ModelState.IsValid)
                {
                    string data = JsonConvert.SerializeObject(model);
                    StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _client.PutAsync(_client.BaseAddress + "/Student/PutStudent/" + model.StudentNumber, content).Result;
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
