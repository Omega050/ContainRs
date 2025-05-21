using System.Linq.Expressions;
using ContainRs.Application.Repositories;
using ContainRs.Domain.Models;
using Microsoft.EntityFrameworkCore;
namespace ContainRs.WebApp.Data;

public class AppDbReadClient : IClienteReadRepository
{
    public DbSet<Cliente> Clientes { get; set; }
    public async Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente, bool>>? filtro = default)
    {
        IQueryable<Cliente> query = this.Clientes;
        if (filtro is not null)
        {
            query = query.Where(filtro);
        }
        return await query.AsNoTracking().ToListAsync();
    }
}

