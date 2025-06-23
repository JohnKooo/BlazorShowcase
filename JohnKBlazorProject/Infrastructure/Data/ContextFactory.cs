using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data;

public class ContextFactory : IDesignTimeDbContextFactory<AppDBContext>
{
    public AppDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
        optionsBuilder.UseSqlite("Data Source=AppDB.db");

        return new AppDBContext(optionsBuilder.Options);
    }
}
// public class ContextFactory<TContext> : IDbContextFactory<TContext> where TContext : DbContext
// {
//     private readonly IServiceProvider _provider;

//     public ContextFactory(IServiceProvider provider)
//     {
//         _provider = provider;
//     }

//     public TContext CreateDbContext()
//     {
//         if (_provider == null)
//         {
//             throw new InvalidOperationException(
//                 "You must configure an instance of IServiceProvider");
//         }
//         return ActivatorUtilities.CreateInstance<TContext>(_provider);
//     }
// }
