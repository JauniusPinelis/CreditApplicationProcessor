using CreditApplicationProcessor.Domain.Dtos;
using CreditApplicationProcessor.Domain.Exceptions;
using CreditApplicationProcessor.Domain.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CreditApplicationProcessor.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditApplicationController : ControllerBase
    {
        private readonly ApplicationService _applicationService;

        public CreditApplicationController(ApplicationService applicationService)
        {
            _applicationService = applicationService ?? throw new ArgumentNullException(nameof(applicationService));
        }

        [HttpPost]
        public ActionResult<ApplicationResponse> ProcessCreditApplication(ApplicationRequest request)
        {
            try
            {
                return Ok(_applicationService.ProcessCreditApplication(request));
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ConfigurationException)
            {
                return StatusCode(500, "Rule configuration error");
            }
        }
    }
}
