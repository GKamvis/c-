using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using webapi3_mvc.Models;

namespace webapi3_mvc.Controllers
{
    public class BankController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7028/api");
        private readonly HttpClient _client;

        public BankController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewModel myModel = new ViewModel();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/bank/GetResult").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                myModel = JsonConvert.DeserializeObject<ViewModel>(data);
            }
            return View(myModel);
        }


        // POST: BankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MedaxilViewModel medaxilViewModel)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(medaxilViewModel), Encoding.UTF8, "application/json");

                using (var response = await _client.PostAsync("https://localhost:7028/medaxilet", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Serverdə bir xəta baş verdi: " + apiResponse);
                    }
                }
            }
            return View(medaxilViewModel);
        }
        // POST: BankController/Expense
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Expense(MexaricViewModel mexaricViewModel)
        {
            if (ModelState.IsValid)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(mexaricViewModel), Encoding.UTF8, "application/json");

                using (var response = await _client.PostAsync("https://localhost:7028/mexaricet", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Serverdə bir xəta baş verdi: " + apiResponse);
                    }
                }
            }
            return View(mexaricViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> GetBalance()
        {
            HttpResponseMessage response = await _client.GetAsync(_client.BaseAddress + "/bank/GetBalance");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                double balance = JsonConvert.DeserializeObject<double>(data);
                return View(balance);
            }
            else
            {
                // Xəta işləməsi
                return View("Error");
            }
        }






































        // GET: BankController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankController/Create
        public ActionResult Create()
        {
            return View(new MedaxilViewModel());
        }


        // GET: BankController/Expense
        public ActionResult Expense()
        {
            return View(new MexaricViewModel());
        }


        // GET: BankController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
