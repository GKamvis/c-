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
    public class OperationController : ControllerBase
    {
        private readonly CarsContext _context;

        public OperationController(CarsContext context)
        {
            _context = context;
        }

        // POST: api/Operation/Load
        [HttpPost("Load")]
        public async Task<IActionResult> LoadOperation(OperationLoadDto operationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Number == operationDto.CarNumber);
            if (car == null)
            {
                return NotFound("Car not found");
            }

            var operation = new Operation
            {
                Id = car.Id,
                Item = operationDto.Load,
                OperationDate = operationDto.OperationDate
            };

            _context.Operations.Add(operation);
            await _context.SaveChangesAsync();

            return Ok(operation);
        }

        // POST: api/Operation/CarDropped
        [HttpPost("CarDropped")]
        public async Task<IActionResult> CarDropped(OperationCarDto operationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Number == operationDto.CarNumber);
            if (car == null)
            {
                return NotFound("Car not found");
            }

            var operation = new Operation
            {
                Id = car.Id,
                OperationType = 1,
                OperationDate = operationDto.OperationDate
            };

            _context.Operations.Add(operation);
            await _context.SaveChangesAsync();

            return Ok(operation);
        }

        // POST: api/Operation/CarArrived
        [HttpPost("CarArrived")]
        public async Task<IActionResult> CarArrived(OperationCarDto operationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Number == operationDto.CarNumber);
            if (car == null)
            {
                return NotFound("Car not found");
            }

            var operation = new Operation
            {
                Id = car.Id,
                OperationType = 2,
                OperationDate = operationDto.OperationDate
            };

            _context.Operations.Add(operation);
            await _context.SaveChangesAsync();

            return Ok(operation);
        }
    }
}