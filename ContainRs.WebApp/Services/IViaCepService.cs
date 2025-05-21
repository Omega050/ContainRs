using Refit;

namespace ContainRs.WebApp.Services;

public interface IViaCepService
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> ConsultarAsync(string cep);
}
