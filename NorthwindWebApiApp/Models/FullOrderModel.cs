namespace NorthwindWebApiApp.Models
{
    public class FullOrderDescription : BriefOrderDescription
    {
        public string CustomerId { get; set; }

        public int? EmployeeId { get; set; }

        public int? ShipVia { get; set; }
    }
}