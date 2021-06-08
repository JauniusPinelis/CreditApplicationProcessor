using CreditApplicationProcessor.Domain.Dtos;
using FluentValidation;
using System;

namespace CreditApplicationProcessor.Domain.Services
{
    public class ApplicationService
    {
        private readonly ValidationService _validationService;
        private readonly RuleService _ruleService;

        public ApplicationService(ValidationService validationService, RuleService ruleService)
        {
            _validationService = validationService ?? throw new ArgumentNullException(nameof(validationService));
            _ruleService = ruleService ?? throw new ArgumentNullException(nameof(ruleService));
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
                Decision = _ruleService.CalculateDecision(request.Amount),
                InterestRate = _ruleService.CalculateInterestRate(request.Amount + request.PreAmount)
            };
        }
    }
}
