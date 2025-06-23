using System;
using System.Reflection;
using Application.Models.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {

    }

    public DbSet<Item> Items { get; set; }
    public DbSet<Order> Orders { get; set; }

    // protected override void OnModelCreating(ModelBuilder builder)
    // {
    //     base.OnModelCreating(builder);
    //     builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    // }
    // protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    // {
    //     base.ConfigureConventions(configurationBuilder);
    //     configurationBuilder.Properties<string>().HaveMaxLength(450);
    // }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {

    // }
}
