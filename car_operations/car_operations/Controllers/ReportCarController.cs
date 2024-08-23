using car_operations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace car_operations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly CarsContext _context;

        public ReportController(CarsContext context)
        {
            _context = context;
        }

        // GET: api/Report/CarStatus
        [HttpGet("CarStatus")]
        public async Task<ActionResult<IEnumerable<CarStatus>>> GetCarStatus()
        {
            var carStatuses = await _context.Cars.Select(car => new CarStatus
            {
                CarNumber = car.Number,
                Status = _context.Operations
                    .Where(op => op.Id == car.Id)
                    .OrderByDescending(op => op.OperationDate)
                    .Select(op => op.Item)
                    .FirstOrDefault() ?? "Empty",
                LastOperationDate = _context.Operations
                    .Where(op => op.Id == car.Id)
                    .Max(op => op.OperationDate)
            }).ToListAsync();

            return carStatuses;
        }

        // POST: api/Report/CarStatus
        [HttpPost("CarStatus")]
        public async Task<IActionResult> PostCarStatus(CarStatus carStatusDto)
        {
            // Burada post yadindan çixmasin





           // Mənim yadimdan çizsa müəllim siz tamamlayin boş qalmasin post 
            return Ok();
        }
    }
}