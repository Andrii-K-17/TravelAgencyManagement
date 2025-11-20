using System;

namespace App.Core.DTOs;

/// <summary>
/// Represents DTO for displaying booking details in reports or the ui.
/// </summary>
public class BookingReportDto
{
    public int BookingId { get; set; }
    public DateTime BookingDate { get; set; }
    public required string ClientName { get; set; }
    public required string TourName { get; set; }
    public required string Destination { get; set; }
    public decimal? PaymentAmount { get; set; }
    public required string ManagerName { get; set; }
}
