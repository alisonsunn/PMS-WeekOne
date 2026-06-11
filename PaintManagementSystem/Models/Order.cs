namespace PaintManagementSystem.Models;

public class Order
{
    private readonly DateTime _createdAt;
    public PaintProduct Product {get; private set;}
    public int Quantity {get; private set;}
    public decimal TotalPrice {get; private set;}

    public Order(PaintProduct product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        TotalPrice = GetTotalPrice();
        _createdAt = DateTime.Now;
    }

    public String DisplayOrder()
    {
        string paintInfo = Product.DisplayInfo();
        return $"Order Details: PaintProduct: {paintInfo}, Quantity: {Quantity}, TotalPrice: {TotalPrice}, CreatedAt: {_createdAt}";
    }

    public decimal GetTotalPrice()
    {
        decimal productPrice = Product.GetFinalPrice();
        TotalPrice = productPrice * Quantity;
        return TotalPrice;
    }
}