using System;

namespace TicketVendorMachine.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int TicketID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentGateway { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
    }
}