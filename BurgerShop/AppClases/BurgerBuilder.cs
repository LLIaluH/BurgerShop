using BurgerShop.Models;
using BurgerShop.Models.Interfaces;

namespace BurgerShop.AppClases
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        /*
         * TODO:
         *  AddValidation
         * 
         */

        public BurgerBuilder(Burger burger)
        {
            this._burger = burger;
        }

        public IBurgerBuilder AddBacon(int count = 1)
        {
            _burger.Bacon += count;
            return this;
        }

        public IBurgerBuilder AddCutlet(int count = 1)
        {
            _burger.Cutlet += count;
            return this;
        }

        public IBurgerBuilder AddPickles(int count = 1)
        {
            _burger.Picles += count;
            return this;
        }

        public IBurgerBuilder AddTomatos(int count = 1)
        {
            _burger.Tomatos += count;
            return this;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
