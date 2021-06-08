using CreditApplicationProcessor.Domain.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain.Services
{
    public class ApplicationService
    {
        private readonly ValidationService _validationService;

        public ApplicationService(ValidationService validationService)
        {
            _validationService = validationService ?? throw new ArgumentNullException(nameof(validationService));
        }

        public ApplicationResponse ProcessCreditApplication(ApplicationRequest request)
        {
            var validationResult = _validationService.ValidateApplicationRequest(request);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.ToString());
            }

            return GenerateResponse(request);
        }

        private ApplicationResponse GenerateResponse(ApplicationRequest request)
        {
            return new ApplicationResponse()
            {
                //Decision = 
            };
        }

        
    }
}
