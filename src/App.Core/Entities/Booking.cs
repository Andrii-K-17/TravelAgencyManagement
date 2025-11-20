namespace App.Core.Entities;

public class Booking
{
    public int BookingId { get; set; }
    public DateTime BookingDate { get; set; }
    public int ClientId { get; set; }
    public int TourId { get; set; }
    public int EmployeeId { get; set; }

    public required virtual Client Client { get; set; }
    public required virtual Tour Tour { get; set; }
    public required virtual Employee Employee { get; set; }
    public virtual ICollection<Payment> Payments { get; set; } = [];
}
