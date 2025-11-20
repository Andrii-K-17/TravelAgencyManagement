using System;

namespace App.Core.Entities;

public class Payment
{
    public int PaymentId { get; set; }
    public int BookingId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public required string TransactionNumber { get; set; }
    public required string PaymentMethod { get; set; }
    public int EmployeeId { get; set; }

    public required virtual Booking Booking { get; set; }
    public required virtual Employee Employee { get; set; }
}
