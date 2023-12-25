namespace BurgerShop.AppClases
{
    public class SupportCls
    {
        public static T GetLimit<T>(T number, T limit) where T : IComparable => Comparer<T>.Default.Compare(number, limit) < 0 ? number : limit;
    }
}
