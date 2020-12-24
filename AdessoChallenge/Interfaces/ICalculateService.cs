using AdessoChallenge.DTO.CalculateObjects.CalculatePiNumberOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoChallenge.Interfaces
{
    public interface ICalculateService
    {
        CalculatePiNumberOutput CalculatePiNumber(int iterationCount);
    }
}
