using PaintManagementSystem.Enums;
using PaintManagementSystem.Models;

// create many paintproduct products
PaintSpecification paintSpecification1 = new PaintSpecification("Pink", 2);
PaintSpecification paintSpecification2 = new PaintSpecification("White", 4);
PaintSpecification paintSpecification3 = new PaintSpecification("Blue", 8);

Brand brand = new Brand("GoodPaint!");

PaintProduct paintProduct1 = new PaintProduct("Pink Paint", PaintType.Matte, paintSpecification1, 100m, brand);
PaintProduct paintProduct2 = new PaintProduct("White Paint", PaintType.Gloss, paintSpecification2, 80m, brand);
PaintProduct paintProduct3 = new PaintProduct("Blue Paint", PaintType.BaseCoat, paintSpecification3, 60m,brand);


// display all the Info for paintProducts
Console.WriteLine(paintProduct1.DisplayInfo());
Console.WriteLine(paintProduct2.DisplayInfo(10,true));
Console.WriteLine(paintProduct3.DisplayInfo());

Console.WriteLine("===========");

// test OrderList Class
OrderList orderList = new OrderList(paintProduct1, 3);
OrderList orderList2 = new OrderList(paintProduct2, 5);

List<OrderList> orderLists = new List<OrderList>{};
orderLists.Add(orderList);
orderLists.Add(orderList2);


// create an order
Order order1 = new Order(orderLists);


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


