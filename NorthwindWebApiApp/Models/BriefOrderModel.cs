using System;
using NorthwindModel;

namespace NorthwindWebApiApp.Models
{
    public class BriefOrderDescription
    {
        public int OrderId { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public string CustomerId { get; set; }
        //public Customer Customer { get; set; } = new Customer();
    }
}