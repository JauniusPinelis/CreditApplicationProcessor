using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditCheckController : ControllerBase
    {
        public IActionResult ProcessCreditApplication()
        {
            return Ok();
        }
    }
}
