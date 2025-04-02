using EnumSample.Entities;
using EnumSample.Entities.Enums;

Order order = new Order
{
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt  = OrderStatus.Delivered.ToString();

Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);