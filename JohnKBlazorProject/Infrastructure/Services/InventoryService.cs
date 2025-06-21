using System;
using Application.Interfaces;
using Application.Models.Inventory;

namespace Infrastructure.Services;

public class InventoryService
{
    private readonly IInventoryRepository inventoryRepository;

    public InventoryService(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task AddItem(Item item)
    {
        await inventoryRepository.AddItem(item);
    }

    public async Task AddOrder(Order order)
    {
        await inventoryRepository.AddOrder(order);
    }

    public async Task DeleteItem(Item item)
    {
        await inventoryRepository.DeleteItem(item);
    }

    public async Task DeleteOrder(Order order)
    {
        await inventoryRepository.DeleteOrder(order);
    }

    public async Task UpdateItem(Item item, Item item2)
    {
        await inventoryRepository.UpdateItem(item, item2);
    }

    public async Task UpdateOrder(Order order, Order order2)
    {
        await inventoryRepository.UpdateOrder(order, order2);
    }
}
