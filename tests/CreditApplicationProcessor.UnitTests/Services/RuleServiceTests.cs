using CreditApplicationProcessor.Domain.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
