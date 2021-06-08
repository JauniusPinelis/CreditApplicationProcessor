using CreditApplicationProcessor.Domain.Rules;
using System;
using System.Collections.Generic;
namespace CreditApplicationProcessor.Domain.Configurations
{
    public static class RulesConfiguration
    {
        public static List<DecisionRule> GetDecisionRules()
            => new List<DecisionRule>()
        {
            new DecisionRule()
            {
                Max = 1999,
                Decision = false
            },
             new DecisionRule()
            {
                Min = 2000,
                Max = 68999,
                Decision = true
            },
              new DecisionRule()
            {
                Min = 69000,
                Decision = false
            },
        };

        public static List<InterestRateRule> GetInterestRateRules()
            => new List<InterestRateRule>()
            {
                new InterestRateRule()
                {
                    Max = 19999,
                    InterestRate = 3
                },
                new InterestRateRule()
                {
                    Min = 20000,
                    Max = 39000,
                    InterestRate = 4
                },
                new InterestRateRule()
                {
                    Min = 40000,
                    Max = 59000,
                    InterestRate = 5
                },
                new InterestRateRule()
                {
                    Min = 60000,
                    InterestRate = 6
                },
            };

    }
}
