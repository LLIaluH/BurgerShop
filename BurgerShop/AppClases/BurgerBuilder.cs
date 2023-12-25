using BurgerShop.Models;
using BurgerShop.Models.Interfaces;

namespace BurgerShop.AppClases
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;

        public BurgerBuilder(Burger burger)
        {
            this._burger = burger;
        }

        public IBurgerBuilder AddBacon(int count = 1)
        {
            _burger.Bacon += SupportCls.GetLimit(count, 3);
            return this;
        }

        public IBurgerBuilder AddCutlet(int count = 1)
        {
            _burger.Cutlet += SupportCls.GetLimit(count, 2); ;
            return this;
        }

        public IBurgerBuilder AddPickles(int count = 1)
        {
            _burger.Picles += SupportCls.GetLimit(count, 5); ;
            return this;
        }

        public IBurgerBuilder AddTomatos(int count = 1)
        {
            _burger.Tomatos += SupportCls.GetLimit(count, 3); ;
            return this;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
