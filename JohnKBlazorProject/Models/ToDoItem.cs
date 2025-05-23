using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JohnKBlazorProject.Models
{
    public class ToDoItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Completed { get; set; } = false;
        
    }
}