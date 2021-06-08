using CreditApplicationProcessor.Domain.Dtos;
using CreditApplicationProcessor.Domain.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreditApplicationProcessor.UnitTests.Services
{
    public class ValidationServiceTests
    {
        [Fact]
        public void ValidateApplicationRequest_GivenValidRequest_ValidatesSuccesfully()
        {
            var request = new ApplicationRequest()
            {
                Amount = 2000,
                PreAmount = 20000,
                Term = 2
            };

            var validationService = new ValidationService();

            var response = validationService.ValidateApplicationRequest(request);

            response.IsValid.Should().BeTrue();
        }

        [Fact]
        public void ValidateApplicationRequest_GivenRequestWithAmountZero_ValidationFails()
        {
            var request = new ApplicationRequest()
            {
                Amount = 0,
                PreAmount = 20000,
                Term = 2
            };

            var validationService = new ValidationService();

            var response = validationService.ValidateApplicationRequest(request);

            response.IsValid.Should().BeFalse();
        }
    }
}
