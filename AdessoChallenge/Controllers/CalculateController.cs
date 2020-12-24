using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdessoChallenge.DTO.CalculateInput;
using AdessoChallenge.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdessoChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CalculateController : ControllerBase
    {
        private readonly ICalculateService _calculateService;
        public CalculateController(ICalculateService calculateService)
        {
            _calculateService = calculateService;
        }

        [HttpGet("{iterationCount}")]
        // api/calculate/1000
        public IActionResult CalculatePiNumber(int iterationCount)
        {
            var piNumber = _calculateService.CalculatePiNumber(iterationCount);
            return Ok(piNumber);
        }


        [HttpPost]
        public IActionResult CalculatePiNumber([FromBody] CalculatePiInput input)
        {
            var piNumber = _calculateService.CalculatePiNumber(input.IterationCount);

            return Ok(piNumber);
        }


    }
}
