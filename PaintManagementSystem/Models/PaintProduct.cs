using PaintManagementSystem.Enums;

namespace PaintManagementSystem.Models;

public class PaintProduct {
    private const int _DefaultDiscount = 5;
    private readonly decimal _taxRate;
    public string Name {get; private set;}
    public PaintType Type {get; private set;}
    public PaintSpecification Specification {get; private set;}
    public decimal Price {get; private set;}

    public PaintProduct (string name, PaintType type, PaintSpecification specification, decimal price) 
    {
        Name = name;
        Type = type;
        Specification = specification;
        Price = price;
        _taxRate = 0.1m;
    }

    public string DisplayInfo()
    {
        decimal finalPrice = GetFinalPrice();
        return $"Name: {Name}, Type: {Type}, Price: {Price}, Specification: {Specification}, FinalPrice: {finalPrice}";
    }

    public int GetMaxDiscount(int rate, bool isOverridable) {
        if (isOverridable) {
            return Math.Max(rate, _DefaultDiscount);
        }
        return _DefaultDiscount;
    }

    public decimal GetFinalPrice()
    {
        decimal discountedPrice = Price - (Price * (_DefaultDiscount/100m));
        decimal finalPrice = discountedPrice * (1 + _taxRate);
        return finalPrice;
    }   
}