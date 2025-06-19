using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give your task a Name!")]
        [StringLength(100, ErrorMessage = "Name shouldn't be more than 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please include a Description!")]
        public string? Description { get; set; }
        public bool Completed { get; set; } = false;
        public bool Prioritized { get; set; } = false;
    }
}