using CreditApplicationProcessor.Domain.Dtos;
using FluentValidation;

namespace CreditApplicationProcessor.Domain.Validators
{
    public class ApplicationRequestValidator : AbstractValidator<ApplicationRequest>
    {
        public ApplicationRequestValidator()
        {
            RuleFor(a => a.Amount).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(a => a.PreAmount).GreaterThanOrEqualTo(0);
            RuleFor(a => a.Term).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}
