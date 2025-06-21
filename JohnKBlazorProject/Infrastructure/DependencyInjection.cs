using System;
using Application.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<InventoryDBContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("InventoryDBContext")));

        services.AddScoped<IInventoryRepository, InventoryRepository>();
        services.AddScoped<InventoryService>();


        return services;
    }
}
