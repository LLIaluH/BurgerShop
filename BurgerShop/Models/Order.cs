using System.ComponentModel.DataAnnotations;

namespace BurgerShop.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Burger> Burgers { get; set; }
    }
}
