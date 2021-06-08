using CreditApplicationProcessor.Domain.Dtos;
using CreditApplicationProcessor.Domain.Validators;
using FluentValidation.Results;
namespace CreditApplicationProcessor.Domain.Services
{
    public class ValidationService
    {
        public ValidationResult ValidateApplicationRequest(ApplicationRequest request)
        {
            var validator = new ApplicationRequestValidator();

            return validator.Validate(request);
        }
    }
}