using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindView.Models;

namespace NorthwindView.Controllers
{
    public class HomeController : Controller
    {
        private NorthwindContext _northwindContext;
        public HomeController(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrders(string pOrderDateFrom, string pOrderDateTo)
        {
            DateTime orderDateFrom;
            DateTime orderDateTo;
            if (!DateTime.TryParse(pOrderDateFrom, out orderDateFrom))
                orderDateFrom = new DateTime(1900, 1, 1); // SQLDateTime doesn't support 0001/01/01
            if (!DateTime.TryParse(pOrderDateTo, out orderDateTo))
                orderDateTo = DateTime.MaxValue;

            var queryOrderInfo =
                (from o in _northwindContext.Orders
                 join ods in _northwindContext.OrderDetails
                     .GroupBy(o => o.OrderId)
                     .Select(o => new { orderID = o.Key, salesAmount = o.Sum(x => x.Quantity * x.UnitPrice) })
                 on o.OrderId equals ods.orderID
                 where o.OrderDate >= orderDateFrom && o.OrderDate <= orderDateTo
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
