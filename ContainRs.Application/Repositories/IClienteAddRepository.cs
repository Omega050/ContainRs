namespace ContainRs.Application.Repositories;

using ContainRs.Domain.Models;
public interface IClienteAddRepository
{
    Task<Cliente> AddAsync(Cliente cliente);
}
