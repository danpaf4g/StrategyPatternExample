namespace StrategyPatternExample;

public class Order
{
    private IDiscountStrategy _discountStrategy;

    public Order(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void SetStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculatePrice(decimal originalPrice)
    {
        return _discountStrategy.ApplyDiscount(originalPrice);
    }
}