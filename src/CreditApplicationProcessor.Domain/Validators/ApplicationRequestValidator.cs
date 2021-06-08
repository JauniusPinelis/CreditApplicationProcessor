using CreditApplicationProcessor.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Validators
{
    public class ApplicationRequestValidator : AbstractValidator<ApplicationRequest>
    {
        public ApplicationRequestValidator()
        {
            RuleFor(a => a.Amount).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(a => a.Term).NotEmpty().GreaterThanOrEqualTo(1);
        }
        
    }
}
