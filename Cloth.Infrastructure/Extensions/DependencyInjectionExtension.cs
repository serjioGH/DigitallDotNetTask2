﻿namespace Cloth.Infrastructure.Extensions;

using Cloth.Application.Interfaces;
using Cloth.Application.Interfaces.Factories;
using Cloth.Application.Services;
using Cloth.Infrastructure.Configuration;
using Cloth.Infrastructure.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        if (configuration == null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        services.Configure<MockyHttpConfiguration>(configuration.GetSection("MockyClient"));
        //services.AddScoped<IClothRepository, ClothRepository>();
        services.AddScoped<IClothFactory, ClothFactory>();
        services.AddScoped<IOrderFactory, OrderFactory>();
        services.AddScoped<IClothService, ClothService>();
        services.AddHttpClient<MockyHttpServiceClient>();
        services.AddScoped<IMockyHttpServiceClient, MockyHttpServiceClient>();

        return services;
    }
}
