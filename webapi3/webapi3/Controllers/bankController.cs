using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi3.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class bankController : ControllerBase
    {
        private readonly BankDbContext _context;

        public bankController(BankDbContext context)
        {
            _context =  context;
        }
        // GET: api/Bank
        [HttpGet]
      
        public IActionResult GetResult()
        {
            var medaxiller = _context.Medaxils.ToList();
            var mexaricler = _context.Mexarics.ToList();

            var result = new
            {
                Medaxillar = medaxiller.Select(m => new { m.Id, m.Miqdar, m.Aciqlama, m.Tarix }),
                Mexaricler = mexaricler.Select(m => new { m.Id, m.Miqdar, m.Aciqlama, m.Tarix })
            };

            return Ok(result);
        }

        // POST api/Bank
        [HttpPost]
        [Route("/medaxilet")]
        public ActionResult<Medaxil> PostMedaxil(Medaxil medaxil)
        {

            medaxil.Tarix = DateTime.Now;

            _context.Medaxils.Add(medaxil);
            _context.SaveChanges();

           // return CreatedAtAction("Get", new { id = medaxil.Id }, medaxil);
            return CreatedAtAction(nameof(GetResult), new { id = medaxil.Id }, medaxil);
        }
        // POST api/Bank
        [HttpPost]
        [Route("/mexaricet")]
        public ActionResult<Mexaric> PostMexaric(Mexaric mexaric)
        {

            mexaric.Tarix = DateTime.Now;
            // Balansı hesablayan metod. Bu nümunədə sadəcə mexaric məbləğlərini cəmləyir.
            double HesablaBalans()
            {
                // Medaxil cedvelinden olan miqdarların cəmini hesablayın
                var totalIncome = _context.Medaxils.Sum(i => i.Miqdar);

                // Mexaric cedvelinden olan miqdarların cəmini hesablayın
                var totalExpense = _context.Mexarics.Sum(e => e.Miqdar);

                // Cəmləri hesablayın və balansı tapın
                return (double)(totalIncome - totalExpense);
            }

            double balans = HesablaBalans();

            // Mexaric məbləğini balansla müqayisə edin
            if (mexaric.Miqdar > balans)
            {
                // Əgər mexaric məbləği balansdan böyük olarsa, xəta mesajı qaytarın
                return BadRequest("Xəta: Mexaric ediləcək məbləğ balansdan böyükdür.");
            }

            // Əks halda, mexaric məbləğini əlavə edin və yadda saxlayın
            _context.Mexarics.Add(mexaric);
            _context.SaveChanges();

            // Yeni mexaric məbləğini qaytarın
            return CreatedAtAction(nameof(GetResult), new { id = mexaric.Id }, mexaric);
        }



        // GET: api/Bank
        [HttpGet]
        public  IActionResult GetBalance()
        {
            // Medaxil cedvelinden olan miqdarların cəmini hesablayın
            var totalIncome = _context.Medaxils.Sum(i => i.Miqdar);

            // Mexaric cedvelinden olan miqdarların cəmini hesablayın
            var totalExpense = _context.Mexarics.Sum(e => e.Miqdar);

            // Cəmləri hesablayın və balansı tapın
            var balance = totalIncome - totalExpense;

            // Balansı qaytarın
            return Ok(balance);

        }



    }
}
