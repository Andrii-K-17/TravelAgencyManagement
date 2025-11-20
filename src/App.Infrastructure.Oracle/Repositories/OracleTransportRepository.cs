using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;

namespace App.Infrastructure.Oracle.Repositories;

public class OracleTransportRepository(TourAgencyDbContext context) : Repository<Transport>(context), ITransportRepository
{
}