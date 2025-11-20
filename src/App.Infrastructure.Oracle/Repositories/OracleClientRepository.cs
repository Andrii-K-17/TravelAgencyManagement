using App.Core.Entities;
using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Oracle.Repositories;

public class OracleClientRepository(TourAgencyDbContext context) : Repository<Client>(context), IClientRepository
{
    public async Task<IEnumerable<Client>> GetAllWithPassportsAsync()
    {
        return await _context.Clients
                            .Include(c => c.Passports)
                            .ToListAsync();
    }
}
