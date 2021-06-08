using CreditApplicationProcessor.Domain.Dtos;
using CreditApplicationProcessor.WebApi;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace CreditApplicationProcessor.IntegrationTests
{
    public class CreditApplicationControllerTests
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public CreditApplicationControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ProcessCreditApplication_GivenRequest_ReturnsCorrectResponse()
        {
            var client = _factory.CreateClient();

            var request = new ApplicationRequest()
            {
                Term = 4,
                Amount = 5000
            };

            var response = await client.PostAsJsonAsync("/CreditApplication", request);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var applicationResponse = JsonConvert.DeserializeObject<ApplicationResponse>(content);

            applicationResponse.Decision.Should().BeTrue();
            applicationResponse.InterestRate.Should().Be(3);
        }

        [Fact]
        public async Task ProcessCreditApplication_GivenInvalidRequest_ReturnsBadRequest()
        {
            var client = _factory.CreateClient();

            var request = new ApplicationRequest()
            {
                Term = 4,
                Amount = -5000
            };

            var response = await client.PostAsJsonAsync("/CreditApplication", request);

            response.StatusCode.Should().Be(400);
        }

        [Fact]
        public async Task ProcessCreditApplication_GivenPreamount_ReturnsCorrectInterestRate()
        {
            var client = _factory.CreateClient();

            var request = new ApplicationRequest()
            {
                Term = 4,
                Amount = 20000,
                PreAmount = 20000
            };

            var response = await client.PostAsJsonAsync("/CreditApplication", request);

            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var applicationResponse = JsonConvert.DeserializeObject<ApplicationResponse>(content);

            applicationResponse.Decision.Should().BeTrue();
            applicationResponse.InterestRate.Should().Be(5);
        }
    }
}
