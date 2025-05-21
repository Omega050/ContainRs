using ContainRs.Domain.Models;

namespace ContainRs.Teste

{
    public class EmailCtor
    {
        [Fact]
        public void Deve_Lan�ar_ArgumentException_Quando_Valor_Inv�lido()
        {
            string emailInvalido = "valor qualquer";

            Assert.Throws<ArgumentException>(() =>
            {
                Email email = new Email(emailInvalido);
            });
        }
    }
}