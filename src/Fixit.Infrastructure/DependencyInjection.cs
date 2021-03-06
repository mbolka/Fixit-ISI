﻿using Fixit.Infrastructure.Services.Mail;
using Fixit.Infrastructure.Services.Media;
using Fixit.Infrastructure.Services.Sms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fixit.Infrastructure
{
    public static class InfrastructureProvider
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddMailService(config);
            services.AddSmsService(config);
            services.AddMediaService(config);

            return services;
        }
    }
}