# Create API returning JSON

You create API to return order data with JSON format on the Controller.

## Create a new function

Open Controllers\\HomeController.cs. Create a new function named GetOrders() with 2 paramaters and it returns JsonResult type.

Controllers\\HomeController.cs

```cs
public JsonResult GetOrders(string pOrderDateFrom, string pOrderDateTo)
{
    return new JsonResult();
}
```

 Copy the LINQ query in Index() and paste it in GetOrders(). This query gets order information but without filtering by "OrderDate From" and "OrderDate To". So, let's modify the query as below so API returns filtered order data by the requested oder dates.

Controllers\\HomeController.cs

```cs
public JsonResult GetOrders(string pOrderDateFrom, string pOrderDateTo)
{
    // ↓↓↓ Added ↓↓↓ 
    DateTime orderDateFrom;
    DateTime orderDateTo;
    if (!DateTime.TryParse(pOrderDateFrom, out orderDateFrom))
        orderDateFrom = new DateTime(1900, 1, 1); // SQLDateTime doesn't support 0001/01/01
    if (!DateTime.TryParse(pOrderDateTo, out orderDateTo))
        orderDateTo = DateTime.MaxValue;
    // ↑↑↑ Added ↑↑↑ 

    var queryOrderInfo =
        (from o in _northwindContext.Orders
            join ods in _northwindContext.OrderDetails
                .GroupBy(o => o.OrderId)
                .Select(o => new { orderID = o.Key, salesAmount = o.Sum(x => x.Quantity * x.UnitPrice) })
            on o.OrderId equals ods.orderID
            // ↓↓↓ Added ↓↓↓ 
            where o.OrderDate >= orderDateFrom && o.OrderDate <= orderDateTo
            // ↑↑↑ Added ↑↑↑ 
            select new OrderInfo
            {
                OrderId = o.OrderId,
                CompanyName = o.Customer.CompanyName,
                EmployeeName = o.Employee.FirstName + "" + o.Employee.LastName,
                OrderDate = o.OrderDate,
                ShipCountry = o.ShipCountry,
                SalesAmount = ods.salesAmount,
            });
    return new JsonResult(queryOrderInfo);
}
```
## Modify Index()

Index() doesn't have to return View with order data since you created a new function instead, so let's remove the query in Index() as below.

Controllers\\HomeController.cs

```cs
public IActionResult Index()
{
    return View();
}
```

Now you have API returning JSON Order data filtered by searched Order Dates.

## Next
[02-03 Get data from API](02-03-Get-Data-From-API.md)
