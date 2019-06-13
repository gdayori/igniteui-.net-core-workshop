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
            var queryOrderInfo =
                (from o in _northwindContext.Orders
                 join ods in _northwindContext.OrderDetails
                     .GroupBy(o => o.OrderId)
                     .Select(o => new { orderID = o.Key, salesAmount = o.Sum(x => x.Quantity * x.UnitPrice) })
                 on o.OrderId equals ods.orderID
                 select new OrderInfo
                 {
                     OrderId = o.OrderId,
                     CompanyName = o.Customer.CompanyName,
                     EmployeeName = o.Employee.FirstName + "" + o.Employee.LastName,
                     OrderDate = o.OrderDate,
                     ShipCountry = o.ShipCountry,
                     SalesAmount = ods.salesAmount,
                 });
            return View(queryOrderInfo.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
