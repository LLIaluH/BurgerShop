namespace BurgerShop.Models
{
    public class Burger
    {
        public Guid Id { get; set; }
        public BurgerName Name { get; set; }
        public int Picles { get; set; }
        public int Tomatos { get; set; }
        public int Bacon { get; set; }
        public int Cutlet { get; set; }
    }
}
