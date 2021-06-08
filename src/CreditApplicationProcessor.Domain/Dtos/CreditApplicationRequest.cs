using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Dtos
{
    public class CreditApplicationRequest
    {
        /// <summary>
        /// Credit Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Repayment in months
        /// </summary>
        public int Term { get; set; }

        /// <summary>
        /// Current pre-existing credit amount
        /// </summary>
        public decimal PreAmount { get; set; }
    }
}
