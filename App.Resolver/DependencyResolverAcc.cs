using Microsoft.Extensions.DependencyInjection;
using App.GL;

namespace App.Resolver
{
    public static class DependencyResolverAcc
    {
        public static IServiceCollection AddAccServices(this IServiceCollection services)
        {

            services.AddScoped<IGlServices, GlServices>();
            //services.AddScoped<IApServices, ApServices>();
            //services.AddScoped<IArServices, ArServices>();

            return services;
        }
    }
}
