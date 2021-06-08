using CreditApplicationProcessor.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplicationProcessor.Domain
{
    public static class DependencyInjection
    {
        public static void ConfigureDomainServices(this IServiceCollection services)
        {
            services.AddScoped<ApplicationService>();
            services.AddScoped<RuleService>();
            services.AddScoped<ValidationService>();
        }
    }
}
