using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Rules
{
    public class DecisionRule
    {

        public int? Max { get; set; }

        public int? Min { get; set; }

        public bool Decision { get; set; }
    }
}
