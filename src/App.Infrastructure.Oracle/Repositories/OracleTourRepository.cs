using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;

namespace App.Infrastructure.Oracle.Repositories;

public class OracleTourRepository(TourAgencyDbContext context) : Repository<Tour>(context), ITourRepository
{

}
