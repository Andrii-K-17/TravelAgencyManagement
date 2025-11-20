using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;

namespace App.Infrastructure.Oracle.Repositories;

public class OracleHotelRepository(TourAgencyDbContext context) : Repository<Hotel>(context), IHotelRepository
{
}
