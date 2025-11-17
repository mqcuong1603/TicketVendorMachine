using System;

namespace TicketVendorMachine.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int DestinationID { get; set; }
        public string TicketCode { get; set; }
        public decimal Price { get; set; }
        public DateTime IssueDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionID { get; set; }
    }
}