using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Dtos
{
    public class ApplicationResponse
    {
        /// <summary>
        /// Yes or No
        /// </summary>
        public bool Decision { get; init; }

        /// <summary>
        /// Interest Rate in %
        /// </summary>
        public int InterestRate { get; init; }
    }
}
