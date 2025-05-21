using System.Linq.Expressions;
using ContainRs.Domain.Models;

namespace ContainRs.Application.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> AddAsync(Cliente cliente);
        Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente,bool>>? filtro = default);
    }
}
