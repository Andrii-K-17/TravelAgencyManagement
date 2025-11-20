using App.Core.DTOs;
using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace App.Infrastructure.Oracle.Repositories;

public class OracleBookingRepository(TourAgencyDbContext context) : Repository<Booking>(context), IBookingRepository
{
    /// <summary>
    /// Retrieves a detailed report of booking details for the specified date range.
    /// </summary>
    public async Task<IEnumerable<BookingReportDto>> GetBookingsReportAsync(DateTime startDate, DateTime endDate)
    {
        var results = await _context.Bookings
            .Include(b => b.Client)
            .Include(b => b.Tour)
            .Include(b => b.Employee)
            .Include(b => b.Payments)
            .Where(b => b.BookingDate >= startDate && b.BookingDate <= endDate)
            .Select(b => new BookingReportDto
            {
                BookingId = b.BookingId,
                BookingDate = b.BookingDate,
                ClientName = b.Client.FirstName + " " + b.Client.LastName,
                TourName = b.Tour.TourName,
                Destination = b.Tour.Destination,
                PaymentAmount = b.Payments.Any() ? b.Payments.Sum(p => p.Amount) : null,
                ManagerName = b.Employee.FirstName + " " + b.Employee.LastName
            })
            .OrderByDescending(r => r.BookingDate)
            .ToListAsync();

        return results;
    }
}
