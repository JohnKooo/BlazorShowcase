using System;
using Application.Models.Inventory;

namespace Application.Interfaces;

public interface IInventoryRepository
{
    public Task AddItem(Item item);
    public Task DeleteItem(Item item);
    public Task UpdateItem(Item item, Item item2);

    public Task AddOrder(Order order);
    public Task DeleteOrder(Order order);
    public Task UpdateOrder(Order order, Order order2);
}
