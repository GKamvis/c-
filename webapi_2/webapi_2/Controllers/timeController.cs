/*    using Microsoft.AspNetCore.Mvc;
    using webapi_2.Models;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    namespace webapi_2.Controllers
    {






        [Route("api/[controller]")]
        [ApiController]
        public class TimeController : ControllerBase
        {
            private readonly KamDbContext _context;

            public TimeController(KamDbContext context)
            {
                _context = context;
            }
      




        //// GET: api/Time
        //[HttpGet("compare")]
        //public ActionResult<IEnumerable<Time>> GetTimes(DateOnly giris, DateOnly cixis)
        //{

        //    var giris1 = _context.Times.Find(giris);
        //    var cixis1 = _context.Times.Find(cixis);


        //    return _context.Times.ToList();
        //}


        // GET: api/Time/compare
        [HttpGet("compare")]
        public ActionResult<IEnumerable<object>> GetTimeDifferencesWithStudents()
        {
            _context.ChangeTracker.Clear(); // Bu kod sətri əlavə edin



            //var records = (from t in _context.Times
            //               join s in _context.Students on t.Id equals s.id
            //               where t.Giris.HasValue
            //               select new
            //               {
            //                   StudentId = s.Kart,
            //                   StudentName = s.Ad,
            //                   GirisDateTime = t.Giris.Value,
            //                   CixisDateTime = t.Cixis.HasValue ? t.Cixis.Value : (DateTime?)null,
            //                   Ferq = t.Cixis.HasValue ? (t.Cixis.Value - t.Giris.Value).TotalHours.ToString("0.00") + " saat" : "Çıxış vaxtı qeyd olunmayıb"
            //               }).ToList();

            //if (!records.Any())
            //{
            //    return NotFound("Məlumat tapilmadi");
            //}

            //return Ok(records);

            return _context.Times.ToList();

          //  var students = _context.Students
          //                     .Select(student => new
          //                     {
          //                         student.id,
          //                         student.Ad,
          //                         student.Soyad,
          //                         student.Kart
          //                     })
          //                     .ToList();


          //  if (students == null || students.Count == 0)
          //  {
          //      return NotFound();
          //  }

          //  var results = new List<object>();

          //  foreach (var students1 in students)
          //  {
          //      TimeSpan totalTime = TimeSpan.Zero;

          //     var timeEntries = _context.Times
          //                         .Where(time => time.Kart == students1.Kart && time.Giris != null && time.Cixis != null)
          //                         .Select(time => new
          //                         {
          //                             Giris = time.Giris,
          //                             Cixis = time.Cixis
          //                         })
          //                         .ToList();

          //    foreach (var entry in timeEntries)
          //    {
          //        totalTime += (entry.Cixis - entry.Giris) ?? TimeSpan.Zero;
          //    }

          //    var result = new
          //    {
          //        StudentId = students1.id,
          //       Studentad = students1.Ad,
          //        StudentSoyad = students1.Soyad,
          //        StudentCard = students1.Kart,
          //        vaxt = totalTime
          //    };

          //    results.Add(result);
          //}

          //  return Ok(results);



            // Check for empty results (uncomment if needed)
            // if (!records.Any())
            // {
            //   return NotFound("Məlumat tapilmadi");
            // }




            //var records = (from t in _context.Times
            //               join s in _context.Students on t.Kart equals s.Kart
            //               where t.Giris.HasValue
            //               select new
            //               {
            //                   Girisİd = t.Id,
            //                   StudentName = s.Ad,
            //                   GirisDateTime = t.Giris.Value,
            //                   CixisDateTime = t.Cixis.HasValue ? t.Cixis.Value : (DateTime?)null,
            //                   Ferq = t.Cixis.HasValue ? (t.Cixis.Value - t.Giris.Value).TotalHours.ToString("0.00") + " saat" : "Çıxış vaxtı qeyd olunmayıb"
            //               }).ToList();

            //if (!records.Any())
            //{
            //    return NotFound("Məlumat tapilmadi");
            //}

            //return Ok(records);





        }

        // GET api/Time/5
        [HttpGet("{id}")]
        public ActionResult<object> GetTime(int id)
        {
            var record = (from t in _context.Times
                          join s in _context.Students on t.Id equals s.id
                          where t.Id == id && t.Giris.HasValue && t.Cixis.HasValue
                          select new
                          {
                              StudentName = s.Ad,
                              GirisDateTime = t.Giris.Value, // Doğrudan DateTime tipinde kullanın
                              CixisDateTime = t.Cixis.Value  // Doğrudan DateTime tipinde kullanın
                          }).FirstOrDefault();

            if (record == null)
            {
                return NotFound();
            }

            var timeDifference = (record.CixisDateTime - record.GirisDateTime).TotalHours.ToString("0.00") + " saat";

            var result = new
            {
                record.StudentName,
                GirisDateTime = record.GirisDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                CixisDateTime = record.CixisDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                Ferq = timeDifference,
            };

            return Ok(result);
        }



        //// POST api/Time
        //[HttpPost]
        //public ActionResult<object> PostTime(Time time)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // Giriş tarixini qeyd edin, çıxış tarixini boş qoyun
        //    time.Cixis = null;
        //    _context.Times.Add(time);
        //    _context.SaveChanges();

        //    // Cixis xanası olmadan yeni bir obyekt yaradın
        //    var result = new
        //    {
        //        time.Id,
        //        time.Giris,
        //        time.Kart
        //    };

        //    return CreatedAtAction("GetTime", new { id = time.Id }, result);
        //}

        //// POST api/Time
        //[HttpPost]
        //public ActionResult<object> PostTime([FromBody] Time time)
        //{
        //    var student = _context.Students.FirstOrDefault(s => s.Kart == time.Kart);
        //    if (student == null)
        //    {
        //        return NotFound("Tələbə tapılmadı.");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // Giriş tarixi və saatini qeyd edin, çıxış tarixini və saatini boş qoyun
        //    if (time.Giris.HasValue)
        //    {
        //        // Giriş tarixi və saatini qeyd edin
        //        _context.Times.Add(new Time { Giris = time.Giris, Kart = time.Kart });
        //    }
        //    else if (time.Cixis.HasValue)
        //    {
        //        // Çıxış tarixi və saatini qeyd edin
        //        var existingTime = _context.Times.FirstOrDefault(t => t.Kart == time.Kart && !t.Cixis.HasValue);
        //        if (existingTime != null)
        //        {
        //            existingTime.Cixis = time.Cixis;
        //            _context.Entry(existingTime).State = EntityState.Modified;
        //        }
        //    }
        //    _context.SaveChanges();

        //    // Yeni bir obyekt yaradın
        //    var result = new
        //    {
        //        time.Id,
        //        Giris = time.Giris?.ToString("yyyy-MM-dd HH:mm:ss"),
        //        Cixis = time.Cixis?.ToString("yyyy-MM-dd HH:mm:ss"),
        //        time.Kart
        //    };

        //    return CreatedAtAction("GetTime", new { id = time.Id }, result);
        //}




        //// PUT api/Time/5
        //[HttpPut("{id}")]
        //public IActionResult PutTime(int id, Time time)
        //{
        //    if (id != time.Kart)
        //    {
        //        return BadRequest();
        //    }

        //    var entity = _context.Times.Find(id);
        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    // Yalnız çıxış tarixini güncelləyin
        //    entity.Cixis = time.Cixis;
        //    _context.Entry(entity).State = EntityState.Modified;
        //    _context.SaveChanges();

        //    return NoContent();
        //}



        // POST api/Time
        [HttpPost]
        public ActionResult<object> PostTime([FromBody] Time time)
        {
            var student = _context.Students.FirstOrDefault(s => s.Kart == time.Kart);

            if (time.Giris.HasValue && time.Cixis.HasValue)
            {
                TimeSpan duration = time.Cixis.Value - time.Giris.Value;
                time.Duration = (int)duration.TotalHours;
            }

            if (student == null)
            {
                return NotFound("Tələbə tapılmadı.");
            }
         

            // Giriş tarixi və saatini qeyd edin, çıxış tarixini və saatini boş qoyun
            if (time.Giris.HasValue)
            {
                // Giriş tarixi və saatini qeyd edin
                _context.Times.Add(new Time { Giris = time.Giris, Kart = student.id });
            }
            _context.SaveChanges();

            // Yeni bir obyekt yaradın
            var result = new
            {
                time.Kart,
                Giris = time.Giris?.ToString("yyyy-MM-dd HH:mm:ss"),
               // Kart = student.Kart
            };

            return CreatedAtAction("GetTime", new { id = time.Id }, result);
        }


        [HttpPut("{id}")]
        public IActionResult PutTime(int id, Time time)
        {
            var student = _context.Students.FirstOrDefault(s => s.Kart == time.Kart);
            if (student == null)
            {
                return NotFound("Tələbə tapılmadı.");
            }

            var entity = _context.Times.FirstOrDefault(t => t.Kart == time.Kart && !t.Cixis.HasValue);
            if (entity == null)
            {
                return NotFound();
            }

            if (time.Giris.HasValue && time.Cixis.HasValue)
            {
                TimeSpan duration = time.Cixis.Value - time.Giris.Value;
                entity.Duration = (int)duration.TotalHours;
            }

            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }


        // DELETE api/Time/5
        [HttpDelete("{id}")]
            public ActionResult<Time> DeleteTime(int id)
            {
                var time = _context.Times.Find(id);
                if (time == null)
                {
                    return NotFound();
                }

                _context.Times.Remove(time);
                _context.SaveChanges();

                return time;
            }
        }
    }
*/