using CreditApplicationProcessor.Domain.Rules.Abstract;

namespace CreditApplicationProcessor.Domain.Rules
{
    public class InterestRateRule : Rule
    {
        public int InterestRate { get; set; }
    }
}
