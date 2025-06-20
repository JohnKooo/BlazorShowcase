using System;

namespace Application.Models.Inventory;

public class Order
{
    public int Id { get; set; }
    public string? CustomerName { get; set; }
    public List<Item>? Items { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
}