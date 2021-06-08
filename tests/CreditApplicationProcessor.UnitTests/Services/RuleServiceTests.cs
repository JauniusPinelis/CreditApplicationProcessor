using CreditApplicationProcessor.Domain.Services;
using FluentAssertions;
using Xunit;

namespace CreditApplicationProcessor.UnitTests.Services
{
    public class RuleServiceTests
    {
        [Theory]
        [InlineData(1999, false)]
        [InlineData(2000, true)]
        [InlineData(68999, true)]
        [InlineData(69000, false)]
        public void CalculateDecision_GivenAmount_ReturnsCorrectDecision(int amount, bool expectedDecision)
        {
            var ruleService = new RuleService();

            var decision = ruleService.CalculateDecision(amount);

            decision.Should().Be(expectedDecision);
        }

        [Theory]
        [InlineData(19999, 3)]
        [InlineData(20000, 4)]
        [InlineData(40000, 5)]
        [InlineData(79999, 6)]
        public void CalculateInterestRate_GivenFutureDebt_ReturnsCorrectInterestRate(int futureDebt, int expectedRate)
        {
            var ruleService = new RuleService();

            var interestRate = ruleService.CalculateInterestRate(futureDebt);

            interestRate.Should().Be(expectedRate);
        }
    }
}
