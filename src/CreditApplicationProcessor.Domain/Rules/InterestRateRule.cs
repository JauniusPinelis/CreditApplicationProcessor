using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Rules
{
    public class InterestRateRule
    {
        public int? Min { get; set; }

        public int? Max { get; set; }

        public int InterestRate { get; set; }
    }
}
