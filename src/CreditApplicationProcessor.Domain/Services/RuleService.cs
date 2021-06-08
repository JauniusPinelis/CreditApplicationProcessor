using CreditApplicationProcessor.Domain.Configurations;
using CreditApplicationProcessor.Domain.Exceptions;
using CreditApplicationProcessor.Domain.Rules;
using System;
using System.Collections.Generic;

namespace CreditApplicationProcessor.Domain.Services
{
    public class RuleService
    {
        private readonly List<DecisionRule> _decisionRules = RulesConfiguration.GetDecisionRules();
        private readonly List<InterestRateRule> _interestRateRules = RulesConfiguration.GetInterestRateRules();

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
            throw new ConfigurationException("Did not find applicable interest rule");
        }
    }
}
