namespace App.Core.Entities;

public class Tour
{
    public int TourId { get; set; }
    public required string TourName { get; set; }
    public required string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Price { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = [];
    public virtual ICollection<Hotel> Hotels { get; set; } = [];
    public virtual ICollection<Meal> Meals { get; set; } = [];
    public virtual ICollection<Transport> Transports { get; set; } = [];
}
