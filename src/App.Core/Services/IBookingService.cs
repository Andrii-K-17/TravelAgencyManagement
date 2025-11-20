using App.Core.DTOs;
using App.Core.Entities;

namespace App.Core.Services;

/// <summary>
/// Defines business logic operations of booking management.
/// </summary>
public interface IBookingService
{
    Task CreateNewBookingAsync(Booking booking);
    Task<IEnumerable<BookingReportDto>> GenerateBookingReportAsync(DateTime start, DateTime end);
}
