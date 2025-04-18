namespace StrategyPatternExample;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal price);
}