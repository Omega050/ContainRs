namespace ContainRs.Domain.Models;

public class Cliente
{
    private Cliente() { }

    public Cliente(string nome, Email email, string cPF, DateTime nascimento)
    {
        if (CalcularIdade(nascimento) < 18)
            throw new DomainException("Obrigatório ter mais de 18 anos.");
        Nome = nome;
        Email = email;
        CPF = cPF;
        Nascimento = nascimento;
    }

    private int CalcularIdade(DateTime nascimento)
        => DateTime.Today.Year - nascimento.Year -
           (DateTime.Today.DayOfYear < nascimento.DayOfYear ? 1 : 0);

    public Guid Id { get; set; }
    public string Nome { get; private set; }
    public Email Email { get; private set; }
    public string CPF { get; private set; }
    public DateTime Nascimento { get; private set; }
    public string? Celular { get; set; }
    public string? CEP { get; set; }
    public string? Rua { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Municipio { get; set; }
    public UnidadeFederativa? Estado { get; set; }
}

