using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Rules.Abstract
{
    public abstract class Rule
    {
        public int? Max { get; set; }

        public int? Min { get; set; }
    }
}
