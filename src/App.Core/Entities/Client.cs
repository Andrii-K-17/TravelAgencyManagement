namespace App.Core.Entities;

public class Client
{
    public int ClientId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }

    public virtual ICollection<Passport> Passports { get; set; } = [];
    public virtual ICollection<Booking> Bookings { get; set; } = [];
}
