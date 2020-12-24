using AdessoChallenge.DTO.CalculateInput;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdessoChallenge.Validation.CalculateValidation
{
    public class CalculatePiNumberValidator : AbstractValidator<CalculatePiInput>
    {
        public CalculatePiNumberValidator()
        {

            RuleFor(x => x.IterationCount)
                .NotEmpty().WithMessage("Iteration Count can not be Empty and/or Equal to ZERO")
                .GreaterThan(0).WithMessage("Iteration Count can not be Negative");
        }
    }
}
