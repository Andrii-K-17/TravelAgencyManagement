using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;

namespace App.Infrastructure.Oracle.Repositories;

public class OraclePassportRepository(TourAgencyDbContext context) : Repository<Passport>(context), IPassportRepository
{

}