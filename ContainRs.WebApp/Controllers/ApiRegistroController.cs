using ContainRs.WebApp.Data;
using ContainRs.Domain.Models;
using ContainRs.WebApp.Models;
using ContainRs.Application.UseCases;
using Microsoft.AspNetCore.Mvc;


namespace ContainRs.WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApiRegistroController : Controller
{
    private readonly AppDbContext context;

    public ApiRegistroController(AppDbContext context)
    {
        this.context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(RegistroViewModel request)
    {
        var useCase = new RegistrarCliente(
            context,
            request.Nome,
            new Email(request.Email),
            request.CPF,
            request.Nascimento, // Added missing 'Nascimento' parameter
            request.Celular,
            request.CEP,
            request.Rua,
            request.Numero,
            request.Complemento,
            request.Bairro,
            request.Municipio,
            UfStringConverter.FromString(request.Estado)
        );

        await useCase.ExecutarAsync();

        return RedirectToAction("Sucesso");
    }
}
