
using AdessoChallenge.DTO.CalculateInput;
using AdessoChallenge.DTO.CalculateObjects.CalculatePiNumberOutput;
using AdessoChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoChallenge.Services
{
    public class CalculateService : ICalculateService
    {
        public CalculatePiNumberOutput CalculatePiNumber(CalculatePiInput input)
        {
            //For xUnit testing, its not able to get caught by the Validation, so I made this control here. It works for xUnit Testing purposes.
            if (input.IterationCount <= 0)
            {
                throw new ArgumentException("Iteraction Count can not be less or equal to zero");
            }

            decimal pi = 0;

            for (decimal i = 0; i < input.IterationCount; i++)
            {
                pi += 2 / (((4 * i) + 1) * ((4 * i) + 3));
            }

            return new CalculatePiNumberOutput { piNumber = pi * 4 };
        }
    }
}
