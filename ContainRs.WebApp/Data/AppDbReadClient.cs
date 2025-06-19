using ContainRs.Application.Repositories;
using ContainRs.Domain.Models;
using ContainRs.WebApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class AppDbReadClient : DbContext, IClienteReadRepository
{
    private readonly AppDbContext _context;

    public AppDbReadClient(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cliente>> GetAsync(Expression<Func<Cliente, bool>>? filtro)
    {
        IQueryable<Cliente> queryClientes = _context.Clientes; 
        if (filtro != null)
        {
            queryClientes = queryClientes.Where(filtro);
        }
        return await queryClientes
            .AsNoTracking()
            .ToListAsync();
    }
}
