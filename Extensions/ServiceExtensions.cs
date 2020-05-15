using Contracts;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Netris.Extensions
{
    public static class ServiceExtensions
    {
        // CORS Implementaion on Page 6
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        // IIS Configuration on Page 7
        public static void ConfigureIISIntegeration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });
        // Nlog Configuration
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();
    }

}
