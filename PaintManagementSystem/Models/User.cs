namespace PaintManagementSystem.Models;

public class User
{
    private static int _nextUserId = 1;
    public int UserId {get; private set;}
    public List<Order> Orders {get; private set;}
    public List<Payment> Payments {get; private set;}

    public User (List<Order> orders, List<Payment> payments)
    {
        UserId = _nextUserId ++;
        Orders = orders;
        Payments = payments;
    }

    // Get Latest Order
    public Order GetLatestOrder()
    {
        if (Orders.Count != 0)
        {
            return Orders.OrderByDescending(order => order.createdAt).First();
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

    // Get the payment with lowest price
    public Payment GetLowestPayment()
    {
        return Payments.OrderByDescending(payment=>payment.PaymentAmount).Last();
    }

    // Get the lastest payment record
    public Payment GetLastestPaymemt()
    {
        return Payments.OrderByDescending(payment=>payment.createdAt).First();
    }

    // Get the payment over 10
    public List<Payment> GetPaymentOverTen()
    {
        return Payments.FindAll(payment=>payment.PaymentAmount > 10);
    }
}