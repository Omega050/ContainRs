using Microsoft.AspNetCore.Mvc;
using ContainRs.WebApp.Data;
using ContainRs.Application.UseCases;
using ContainRs.Domain.Models;

namespace ContainRs.WebApp.Controllers;

[ApiController]
[Route("api/clientes")]
public class ApiClientesController : ControllerBase
{
    private readonly AppDbContext context;
    private readonly AppDbReadClient read;

    public ApiClientesController(AppDbContext context, AppDbReadClient read)
    {
        this.context = context;
        this.read = read;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(string? estado)
    {
        var usecase = new ConsultarClientes(UfStringConverter.FromString(estado), read);
        var clientes = await usecase.ExecutarAsync();
        return Ok(clientes);
    }
}
