using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;

namespace App.Infrastructure.Oracle.Repositories;

public class OraclePaymentRepository(TourAgencyDbContext context) : Repository<Payment>(context), IPaymentRepository
{
}
