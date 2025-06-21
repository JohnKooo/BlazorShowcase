using System;
using Application.Interfaces;
using Application.Models.Inventory;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class InventoryRepository : IInventoryRepository
{
    private readonly InventoryDBContext inventoryDBContext;

    public InventoryRepository(InventoryDBContext inventoryDBContext)
    {
        this.inventoryDBContext = inventoryDBContext;
    }

    public async Task AddItem(Item item)
    {
        Console.Out.WriteLine("Add Item Message");
        await inventoryDBContext.AddAsync(item);
    }

    public Task AddOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteItem(Item item)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task UpdateItem(Item item, Item item2)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrder(Order order, Order order2)
    {
        throw new NotImplementedException();
    }
}
