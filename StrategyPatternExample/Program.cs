using StrategyPatternExample;

class Program
{
    static void Main(string[] args)
    {
        // Исходная цена товара
        decimal originalPrice = 1000m;

        // Создаем заказ с начальной стратегией (без скидки)
        var order = new Order(new NoDiscountStrategy());
        Console.WriteLine($"Initial Price: {originalPrice}");
        Console.WriteLine($"Price with No Discount: {order.CalculatePrice(originalPrice)}");

        // Меняем стратегию на 10% скидку
        order.SetStrategy(new PercentageDiscountStrategy(10));
        Console.WriteLine($"Price with 10% Discount: {order.CalculatePrice(originalPrice)}");

        // Меняем стратегию на фиксированную скидку 200 рублей
        order.SetStrategy(new FixedAmountDiscountStrategy(200));
        Console.WriteLine($"Price with Fixed Discount (200): {order.CalculatePrice(originalPrice)}");
    }
}

