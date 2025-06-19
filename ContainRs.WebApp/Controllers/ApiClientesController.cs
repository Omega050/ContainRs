using ContainRs.Application.Repositories;
using ContainRs.Application.UseCases;
using ContainRs.Domain.Models;
using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContainRs.WebApp.Controllers;

[ApiController]
[Route("api/clientes")]
public class ApiClientesController : ControllerBase
{
    private readonly AppDbContext context;
    private readonly AppDbReadClient read;

    public ApiClientesController(AppDbContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(string? estado)
    {
        UnidadeFederativa? estadoEnum = null;
        if (!string.IsNullOrEmpty(estado) && Enum.TryParse<UnidadeFederativa>(estado, out var uf))
        {
            estadoEnum = uf;
        }

        var useCase = new ConsultarClientes(estadoEnum, read);

        var clientes = await useCase.ExecutarAsync();

        return Ok(clientes.Select(c => new ClienteResponse(c.Id.ToString(), c.Nome, c.Email.Value)));
    }
}