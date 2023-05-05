using Alura.Estacionamento.Modelos;

namespace TestProject1
{
    public class VeiculoTeste
    {
        [Fact(DisplayName ="Teste nº1")]
        [Trait("Funcionalidade", "Velocidade Acelerar")]
        public void TestarVelocidadeVeiculo()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact(DisplayName = "Teste nº2")]
        [Trait("Funcionalidade", "Velocidade Frear")]
        public void TestarFrearVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo();
            //Act
            veiculo.Frear(15);
            //Assert
            Assert.Equal(-225, veiculo.VelocidadeAtual);
        }
        [Fact(DisplayName = "Teste nº3 - Validar Nome",Skip = "Teste não implementado")]
        public void ValidaNomeProprietario()
        {

        }
    }
}