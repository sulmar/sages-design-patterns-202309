namespace StrategyPattern
{
    public interface ICalculateDiscountStrategy
    {
        decimal GetDiscount(Order order);
        decimal NoDiscount();
    }
}
