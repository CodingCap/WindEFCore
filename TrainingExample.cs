/*

//IQuerable vs IEnumerable
IQueryable<Order> orders = context.Orders;
var mostExpensiveOrders = orders.Where(o => o.Price > 35);

foreach (var order in mostExpensiveOrders)//aici se duce la baza
{
WriteLine(order.ReferenceNumber);
}

//aici se duce iar la baza
WriteLine(mostExpensiveOrders.OrderByDescending(o => o.Price).First().Price);


//=======================================================================================



//lazy loading and N+1 problem
var order = context.Orders.First(o => o.OrderId == 1);

foreach (var tripOrder in order.TripOrders)
{
    WriteLine(tripOrder.Trip.TripReference);
}



//aici este IQueryable si nu se duce la baza inca
var companies = context.Companies
.Where(c => c.CompanyId > 0);

//aici tot IQueryable si inca nu s-a dus la baza
var companyIDs = companies.Select(c => c.CompanyId);

//aici se duce la baza pt companies
//se duce la baza si pt dependinte (prin lazy loading) si face BUM
//in spate se face ceva async si se deschid mai multe Readere pe aceiasi comanda de SQL
foreach (var company in companies)
{
WriteLine(company.Address.StreetNumber);
    foreach (var order in company.Orders)
{
    WriteLine(order.ReferenceNumber);
}
}

//=======================================================================================


//eager loading
//singurul dezavantaj este ca rezult intrun sql query stufos
var order = context.Orders
.Include(o => o.TripOrders)
.ThenInclude(to => to.Trip)
.First(o => o.OrderId == 1);

foreach (var tripOrder in order.TripOrders)
{
WriteLine(tripOrder.Trip.TripReference);
}




//aici nu ai nevoie sa instantiezi navigation properties collection
var companies = context.Companies
.Where(c => c.CompanyId > 0)
.Include(c => c.Orders)
.Include(c => c.Address);
                

foreach (var company in companies)
{
WriteLine(company.Address.StreetNumber);
    foreach (var order in company.Orders) WriteLine(order.ReferenceNumber);
}


//=======================================================================================


//explicit loading


//aici trebuie instantiate navigation properties collections
//daca este activat lazy loading atunci incarca si lazy chiar daca am incarcat explicit
var companies = context.Companies
.Where(c => c.CompanyId > 0);

var companyIDs = companies.Select(c => c.CompanyId);

context.Orders.Where(o => companyIDs.Contains(o.ClientId)).Load();
context.Addresses.Where(a => companyIDs.Contains(a.AddressId)).Load();

foreach (var company in companies)
{
WriteLine(company.Address.StreetNumber);
    foreach (var order in company.Orders) WriteLine(order.ReferenceNumber);
}


//=======================================================================================


//Change Tracker

var order = context.Orders.First();

order.Price = 150m;

var modifiedEntities = context.ChangeTracker.Entries();

var originalOrders = modifiedEntities.Where(me => me.Entity is Order && me.State == EntityState.Modified)
    .Select(m => m.OriginalValues.ToObject() as Order);

WriteLine($"Current value {order.Price}");
WriteLine($"Original value {originalOrders.First().Price}");






//=======================================================================================
//concurency checks
 var company = context.Companies.First(c => c.CompanyId == 3);


            var companyToUpdate = context.Companies.Find(3);
            company.CompanyName = "test";

            context.Entry(companyToUpdate).OriginalValues["RowVersion"] = context.Entry(company)
                .OriginalValues["RowVersion"];
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException  e)
            {
                Console.WriteLine(e);
            }

*/