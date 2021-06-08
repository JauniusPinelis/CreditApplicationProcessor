using CreditApplicationProcessor.Domain.Rules.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Rules
{
    public class DecisionRule : Rule
    {
        public bool Decision { get; set; }
    }
}
