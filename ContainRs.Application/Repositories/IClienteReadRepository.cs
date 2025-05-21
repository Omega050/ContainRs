namespace ContainRs.Application.Repositories;

using System.Linq.Expressions;
using ContainRs.Domain.Models;
public interface IClienteReadRepository
{
    Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente, bool>>? filtro = default);
}
