using AdessoChallenge.DTO.CalculateInput;
using AdessoChallenge.DTO.CalculateObjects.CalculatePiNumberOutput;

namespace AdessoChallenge.Interfaces
{
    public interface ICalculateService
    {
        CalculatePiNumberOutput CalculatePiNumber(CalculatePiInput iterationCount);
    }
}
