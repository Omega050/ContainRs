using ContainRs.Domain.Models;
using ContainRs.Application.Repositories;

namespace ContainRs.Application.UseCases
{
    public class RegistrarCliente
    {
        private readonly IClienteAddRepository repository;
        public RegistrarCliente(IClienteAddRepository repository, string nome, Email email, string cPF, DateTime nascimento, string? celular, string? cEP, string? rua, string? numero, string? complemento, string? bairro, string? municipio, UnidadeFederativa? estado)
        {
            this.repository = repository;
            Nome = nome;
            Email = email;
            CPF = cPF;
            Nascimento = nascimento;
            Celular = celular;
            CEP = cEP;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
        }

        public string Nome { get; }
        public Email Email { get; }
        public string CPF { get; }
        public DateTime Nascimento { get; }
        public string? Celular { get; }
        public string? CEP { get; }
        public string? Rua { get; }
        public string? Numero { get; }
        public string? Complemento { get; }
        public string? Bairro { get; }
        public string? Municipio { get; }
        public UnidadeFederativa? Estado { get; }

        public async Task<Cliente> ExecutarAsync()
        {
            var cliente = new Cliente(Nome, Email, CPF, Nascimento)
            {
                Celular = Celular,
                CEP = CEP,
                Rua = Rua,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                Municipio = Municipio,
                Estado = Estado
            };
            await repository.AddAsync(cliente);

            return cliente;
        }
    }
}
