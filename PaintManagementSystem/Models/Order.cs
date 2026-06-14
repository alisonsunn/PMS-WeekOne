using System.Reflection.Metadata.Ecma335;

namespace PaintManagementSystem.Models;

public class Order
{
    private readonly DateTime _createdAt;
    public List<OrderList> OrderList {get;}
    public int Quantity {get; private set;}
    public decimal TotalPrice {get; private set;}

    public Order(List<OrderList> orderList)
    {
        OrderList = orderList;
        TotalPrice = GetTotalOrderPrice();
        _createdAt = DateTime.Now;
    }

    public String DisplayOrder()
    {
        string orderInfo = "";
        foreach (var order in OrderList)
        {
            orderInfo += order.OrderLIstInfo();
        }
        return orderInfo + TotalPrice + _createdAt;
    }

    public decimal GetTotalOrderPrice()
    {
        decimal totalPrice = 0;
        foreach (var order in OrderList)
        {
            decimal productPrice = order.Product.GetFinalPrice();
            int quantity = order.Quantity;
            totalPrice += productPrice * quantity;
        }
        return totalPrice;
    }
}