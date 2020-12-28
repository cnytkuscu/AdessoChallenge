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

        // api/calculate/1000
        [HttpGet("{iterationCount}")]
        public IActionResult CalculatePiNumber(int iterationCount)
        {
            if (iterationCount <= 0)
            {
                throw new ArgumentException("Iteration Count can not be less or equal to Zero.");
            }
            var piNumberOutput = _calculateService.CalculatePiNumber(new CalculatePiInput { IterationCount = iterationCount });
            return Ok(piNumberOutput.piNumber);
        }


        [HttpPost]
        public IActionResult CalculatePiNumber([FromBody] CalculatePiInput input)
        {
            var piNumberOutput = _calculateService.CalculatePiNumber(input);

            return Ok(piNumberOutput.piNumber);
        }


    }
}
