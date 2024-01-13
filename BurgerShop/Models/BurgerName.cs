using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Models
{
    public class BurgerName
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
    }
}
