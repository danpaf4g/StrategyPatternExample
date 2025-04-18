namespace StrategyPatternExample;

public class NoDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal price)
    {
        return price; // Возвращаем цену без изменений
    }
}