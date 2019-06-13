using System;
using System.Collections.Generic;

namespace NorthwindView.Models
{
    public partial class OrderInfo
    {
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipCountry { get; set; }
        public decimal SalesAmount { get; set; }
    }
}
