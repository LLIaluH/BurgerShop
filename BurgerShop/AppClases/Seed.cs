using BurgerShop.Models;

namespace BurgerShop.AppClases
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BurgerShopContext>();
                context.Database.EnsureCreated();
                if (!context.Burgers.Any())
                {

                    var names = new string[] { "Чизбургер", "Гамбургер", "Джуси Люси" };
                    List<Burger> burgers = new List<Burger>(names.Length);
                    foreach (var name in names)
                    {
                        var builder = new BurgerBuilder(new Burger()
                        {
                            BurgerName = new BurgerName() { Name = name },
                        });
                        burgers.Add(builder.AddBacon().AddPickles().AddCutlet().AddTomatos().GetBurger());
                    }
                    context.Burgers.AddRange(burgers);
                }
                context.SaveChanges();
            }
        }
    }
}
