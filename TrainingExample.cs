//IQuerable vs IEnumerable
IEnumerable<Order> orders = context.Orders;
var expesiveOrder = orders.Where(o => o.Price > 35);

foreach (var order in expesiveOrder)
{
    WriteLine(order.ReferenceNumber);
}

//lazy loading and N+1 problem
var order = context.Orders.First(o => o.OrderId == 1);

foreach (var tripOrder in order.TripOrders)
{
    WriteLine(tripOrder.Trip.TripReference);
}

//eager loading
var order = context.Orders
            .Include(o => o.TripOrders)
            .ThenInclude(to => to.Trip)
            .First(o => o.OrderId == 1);

foreach (var tripOrder in order.TripOrders)
{
    WriteLine(tripOrder.Trip.TripReference);
}