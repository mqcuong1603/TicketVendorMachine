namespace TicketVendorMachine.Models
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string DestinationName { get; set; }
        public decimal Price { get; set; }
        public string RouteCode { get; set; }
        public bool IsActive { get; set; }
    }
}