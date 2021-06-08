using CreditApplicationProcessor.Domain.Dtos;
using CreditApplicationProcessor.Domain.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
