namespace PaintManagementSystem.Models;

public class User
{
    private static int _nextUserId = 1;
    public int UserId {get; private set;}
    public List<Order> Orders {get; private set;}

    public User (List<Order> orders)
    {
        UserId = _nextUserId ++;
        Orders = orders;
    }

    // Get Latest Order
    public Order GetLatestOrder()
    {
        if (Orders.Count != 0)
        {
            return Orders.OrderByDescending(order => order._createdAt).First();
        }
        throw new Exception("This User currently doesn't have any order.");
    }

    // Get the most expensive order
    public Order GetMostExpensiveOrder()
    {
        if (Orders.Count != 0)
        {
            return Orders.OrderByDescending(order=> order.GetTotalOrderPrice()).First();
        }
        throw new Exception("This User currently doesn't have any order.");
    }
}