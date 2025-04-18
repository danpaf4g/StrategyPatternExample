namespace StrategyPatternExample;

public class FixedAmountDiscountStrategy : IDiscountStrategy
{
    private readonly decimal _fixedDiscount;

    public FixedAmountDiscountStrategy(decimal fixedDiscount)
    {
        _fixedDiscount = fixedDiscount;
    }

    public decimal ApplyDiscount(decimal price)
    {
        return price - _fixedDiscount;
    }
}