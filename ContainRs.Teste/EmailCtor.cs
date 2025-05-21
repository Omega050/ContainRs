using ContainRs.Domain.Models;

namespace ContainRs.Teste

{
    public class EmailCtor
    {
        [Fact]
        public void Deve_Lançar_ArgumentException_Quando_Valor_Inválido()
        {
            string emailInvalido = "valor qualquer";

            Assert.Throws<ArgumentException>(() =>
            {
                Email email = new Email(emailInvalido);
            });
        }
    }
}