using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Rules
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

    }
}
