namespace BurgerShop.Models.Interfaces
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddPickles(int count = 1);
        IBurgerBuilder AddTomatos(int count = 1);
        IBurgerBuilder AddBacon(int count = 1);
        IBurgerBuilder AddCutlet(int count = 1);
        Burger GetBurger();
    }
}
