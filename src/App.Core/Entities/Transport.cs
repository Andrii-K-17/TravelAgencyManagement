using System;

namespace App.Core.Entities;

public class Transport
{
    public int TransportId { get; set; }
    public required string TransportType { get; set; }
    public required string RouteNumber { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime DepartureTime { get; set; }
    public required string DeparturePlace { get; set; }
    public required string ArrivalPlace { get; set; }
    public decimal Price { get; set; }
    public int EmployeeId { get; set; }
    public int TourId { get; set; }

    public required virtual Employee Employee { get; set; }
    public required virtual Tour Tour { get; set; }
}
