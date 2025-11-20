using App.Core.DTOs;
using App.Core.Entities;

namespace App.Core.Interfaces;

public interface IBookingRepository : IRepository<Booking>
{
    Task<IEnumerable<BookingReportDto>> GetBookingsReportAsync(DateTime startDate, DateTime endDate);
}
