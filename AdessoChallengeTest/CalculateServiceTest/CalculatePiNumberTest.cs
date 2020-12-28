using AdessoChallenge.DTO.CalculateInput;
using AdessoChallenge.Interfaces;
using AdessoChallenge.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdessoChallengeTest.CalculateServiceTest
{
    public class CalculatePiNumberTest
    {
        ICalculateService calculateService;

        public CalculatePiNumberTest()
        {
            calculateService = new CalculateService();
        }

        [Fact]
        public void calculate_pi_number_should_throw_exception_with_zero_iteration_count()
        {
            var iterationCount = 0;

            Assert.Throws<ArgumentException>(() => calculateService.CalculatePiNumber(new CalculatePiInput { IterationCount = iterationCount }));
        }

        [Fact]
        public void calculate_pi_number_should_throw_exception_when_iteration_count_less_than_zero()
        {
            var iterationCount = -5;

            Assert.Throws<ArgumentException>(() => calculateService.CalculatePiNumber(new CalculatePiInput { IterationCount = iterationCount }));
        }

        [Theory]
        [InlineData(1, "2,6666666666666666666666666668")] //Data, Excpected
        [InlineData(2, "2,8952380952380952380952380952")]
        [InlineData(3, "2,9760461760461760461760461760")]
        [InlineData(4, "3,0170718170718170718170718172")]        
        public void calculate_pi_number_should_return_expected_result(int iterationCount, string expectedResult)
        {
            var expected = Convert.ToDecimal(expectedResult);
            var result = calculateService.CalculatePiNumber(new CalculatePiInput { IterationCount = iterationCount });

            Assert.Equal(expected, result.piNumber);
        }
    }
}
