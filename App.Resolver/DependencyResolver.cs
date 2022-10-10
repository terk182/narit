
using App.Accommodations;
using App.Accounting;
using App.ExampleTest;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Resolver
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IExampleTests, ExampleTests>(); 
            services.AddScoped<IService, Service>();
            services.AddScoped<IAccommodationsService, AccommodationsService>();
            return services;
        }
    }
}
