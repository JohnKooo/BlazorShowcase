using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data;

public class ContextFactory : IDesignTimeDbContextFactory<InventoryDBContext>
{
    public InventoryDBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<InventoryDBContext>();
        optionsBuilder.UseSqlite("Data Source=InventoryDB.db");

        return new InventoryDBContext(optionsBuilder.Options);
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
