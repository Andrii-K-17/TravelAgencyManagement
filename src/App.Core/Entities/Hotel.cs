namespace App.Core.Entities;

public class Hotel
{
    public int HotelId { get; set; }
    public required string HotelName { get; set; }
    public required string Location { get; set; }
    public int Stars { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }
    public int TourId { get; set; }

    public required virtual Tour Tour { get; set; }
}
