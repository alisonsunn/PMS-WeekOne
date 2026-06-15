using PaintManagementSystem.Enums;
using PaintManagementSystem.Models;

// create many paintproduct products
PaintSpecification paintSpecification1 = new PaintSpecification("Pink", 2);
PaintSpecification paintSpecification2 = new PaintSpecification("White", 4);
PaintSpecification paintSpecification3 = new PaintSpecification("Blue", 8);

Brand brand = new Brand("GoodPaint!");

PaintProduct paintProduct1 = new PaintProduct(1, "Pink Paint", PaintType.Matte, paintSpecification1, 100m, brand);
PaintProduct paintProduct2 = new PaintProduct(2, "White Paint", PaintType.Gloss, paintSpecification2, 80m, brand);
PaintProduct paintProduct3 = new PaintProduct(3, "Blue Paint", PaintType.BaseCoat, paintSpecification3, 60m,brand);


// display all the Info for paintProducts
Console.WriteLine(paintProduct1.DisplayInfo());
Console.WriteLine(paintProduct2.DisplayInfo(10,true));
Console.WriteLine(paintProduct3.DisplayInfo());

Console.WriteLine("===========");

// test OrderList Class
OrderList orderList = new OrderList(paintProduct1, 3);
OrderList orderList2 = new OrderList(paintProduct2, 5);

OrderList orderList3 = new OrderList(paintProduct3, 8);

List<OrderList> orderLists = new List<OrderList>{};
orderLists.Add(orderList);
orderLists.Add(orderList2);

List<OrderList> orderLists2 = new List<OrderList>{};

orderLists2.Add(orderList3);

// create orders
Order order1 = new Order(orderLists);

Order order2 = new Order(orderLists2);


// display the Info for order1
Console.WriteLine(order1.DisplayOrder());

Console.WriteLine("===========");
// display all the paintProducts from PaintStore Class
List<PaintProduct> paintProducts = new List<PaintProduct>();
paintProducts.Add(paintProduct1);
paintProducts.Add(paintProduct2);
paintProducts.Add(paintProduct3);
PaintStore paintStore = new PaintStore(paintProducts);
Console.WriteLine(paintStore.GetPaintProductsInfo());

Console.WriteLine("===========");
// order1.RemoveProduct(1);
// Console.WriteLine(order1.DisplayOrder());

Console.WriteLine(order1.GetMostExpensivePaintProduct());

// test GetEachPaintTotalPrice() method
Console.WriteLine("===========");
Console.WriteLine(order1.GetEachPaintTotalPrice());

// test GetPaintsWithCertainPrices method
Console.WriteLine("===========");
Console.WriteLine(order1.GetPaintsWithCertainPrices(50, 150));

// test Payment class
Console.WriteLine("===========");
Payment payment1 = new Payment(PaymentStatus.Success, PaymentMethod.BankTransfer, order1);
Console.WriteLine(payment1.PaymentAmount);

// test User class
Console.WriteLine("===========");
List<Order> orders = new List<Order>();
orders.Add(order1);
orders.Add(order2);

User user = new User(orders);
Console.WriteLine(user.GetLatestOrder().DisplayOrder());
Console.WriteLine(user.GetMostExpensiveOrder().DisplayOrder());