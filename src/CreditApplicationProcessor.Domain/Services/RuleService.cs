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
        private readonly List<DecisionRule> _decisionRules = RulesConfiguration.GetDecisionRules();
        private readonly List<InterestRateRule> _interestRateRules = RulesConfiguration.GetInterestRateRules();

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

        public int CalculateInterestRate(int totalDebt)
        {
            foreach (var rule in _interestRateRules)
            {
                if ((totalDebt >= rule.Min || !rule.Min.HasValue) &&
                    (totalDebt <= rule.Max || !rule.Max.HasValue))
                    return rule.InterestRate;
            }

            // Did not find any valid interest rate rule, throw exception
            throw new ArgumentException("Did not find applicable interest rule");
        }
    }
}
