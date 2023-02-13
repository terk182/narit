﻿using App.Common;
using App.PathDetail;
using App.SEC;
using Microsoft.Extensions.DependencyInjection;

namespace App.Resolver
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
          
            //---------MIS-------------------------
            services.AddScoped<IPathDetailService, PathDetailService>(); 
            services.AddScoped<ISecServices, SecServices>(); 
            services.AddScoped<ICommonServices, CommonServices>();


      


            
            return services;
        }
    }
}
