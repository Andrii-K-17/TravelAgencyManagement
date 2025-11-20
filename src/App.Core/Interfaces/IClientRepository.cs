using App.Core.Entities;

namespace App.Core.Interfaces;

public interface IClientRepository : IRepository<Client>
{
    Task<IEnumerable<Client>> GetAllWithPassportsAsync();
}
