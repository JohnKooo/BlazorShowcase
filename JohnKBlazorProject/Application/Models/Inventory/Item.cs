using System.ComponentModel.DataAnnotations;

namespace Application.Models.Inventory;

public class Item
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public float Cost { get; set; }

    public Item(int id, string? name, int quantity, float cost)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Cost = cost;
    }

    public Item()
    {
        
    }
}