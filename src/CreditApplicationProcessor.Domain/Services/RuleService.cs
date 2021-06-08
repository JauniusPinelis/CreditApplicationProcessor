using CreditApplicationProcessor.Domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Services
{
    public class RuleService
    {
        private readonly List<DecisionRule> _decisionRules = new List<DecisionRule>()
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

        public RuleService()
        {

        }

        public bool CalculateDecision(int amount)
        {
            foreach (var rule in _decisionRules)
            {
                if ((amount >= rule.Min || !rule.Min.HasValue) &&
                    (amount <= rule.Max || !rule.Max.HasValue))
                    return rule.Decision;
            }

            return false;
        }
    }
}
