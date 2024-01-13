using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerShop.Models
{
    public class Burger
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("BurgerName")]
        public Guid? BurgerNameId { get; set; }
        public BurgerName? BurgerName { get; set; }

        [ForeignKey("Order")]
        public Guid? OrderId { get; set; }
        public Order? Order { get; set; }
        public float Price { get; set; }
        public int Picles { get; set; }
        public int Tomatos { get; set; }
        public int Bacon { get; set; }
        public int Cutlet { get; set; }
    }
}
