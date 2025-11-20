using App.Core.Interfaces;
using App.Infrastructure.Oracle.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Infrastructure.Oracle.Repositories;

/// <summary>
/// A generic repository implementation for standard CRUD operations using EF Core.
/// </summary>
public class Repository<T>(TourAgencyDbContext context) : IRepository<T> where T : class 
{
    protected readonly TourAgencyDbContext _context = context;

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }
}
