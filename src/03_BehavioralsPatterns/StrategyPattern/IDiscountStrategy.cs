namespace StrategyPattern
{
    public interface IDiscountStrategy
    {
        bool CanDiscount(Order order);
        decimal GetDiscount(Order order);
        decimal NoDiscount();
    }
}
