
using AdessoChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoChallenge.Services
{
    public class CalculateService : ICalculateService
    {
        public decimal CalculatePiNumber(int iterationCount)
        {
            decimal pi = 0;

            for (decimal i = 0; i < iterationCount; i++)
            {
                pi += 2 / (((4 * i) + 1) * ((4 * i) + 3));
            }
            return pi * 4;
        }
    }
}
