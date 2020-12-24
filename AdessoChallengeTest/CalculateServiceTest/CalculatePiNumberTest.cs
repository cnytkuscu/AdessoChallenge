using AdessoChallenge.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdessoChallengeTest.CalculateServiceTest
{
    public class CalculatePiNumberTest
    {
        [Fact]
        public void try_to_calculate_with_null_iteration_count()
        {
            string iterationCount = "";

            var calculateServiceMock = new Mock<ICalculateService>();
            calculateServiceMock.Setup(x => x.CalculatePiNumber(Convert.ToInt32(iterationCount)));
            var result = calculateServiceMock.Object;
        }
    }
}
