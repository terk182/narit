using App.ACC;
using App.Accommodations;
using App.Authenticator;
using App.Common;
using App.EIS;
using App.FIN;
using App.Individual;
using App.PathDetail;
using App.Plan;
using App.Procure;
using App.SEC;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Acc.GL;
using App.Acc.Contact;

namespace App.Resolver
{
    public static class DependencyResolverAcc
    {
        public static IServiceCollection AddAccServices(this IServiceCollection services)
        {

            services.AddScoped<IGlServices, GlServices>();
            services.AddScoped<IContactServices, ContactServices>();

            //services.AddScoped<IApServices, ApServices>();
            //services.AddScoped<IArServices, ArServices>();

            return services;
        }
    }
}
