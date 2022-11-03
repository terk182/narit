
using App.Accommodations;
using App.Common;
using App.EIS;
using App.FIN;
using App.General;
using App.Individual;
using App.PathDetail;
using App.Plan;
using App.Procure;
using App.SEC;
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
          
          
            services.AddScoped<IAccommodationsService, AccommodationsService>(); 
            services.AddScoped<IPathDetailService, PathDetailService>(); 
            services.AddScoped<IEisServices, EisServices>(); 
            services.AddScoped<IFinServices, FinServices>(); 
            services.AddScoped<IIndividualServices, IndividualServices>();  
            services.AddScoped<IGeneralServices, GeneralServices>(); 
            services.AddScoped<ISecServices, SecServices>(); 
            services.AddScoped<IPlanServices, PlanServices>(); 
            services.AddScoped<IProcureServices, ProcureServices>();
            services.AddScoped<ICommonServices, CommonServices>();
            return services;
        }
    }
}
