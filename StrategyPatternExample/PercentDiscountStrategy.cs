namespace StrategyPatternExample;

public class PercentageDiscountStrategy(decimal discountPercentage) : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        return price - (price * (discountPercentage / 100));
    }
}