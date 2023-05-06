using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace TestProject1
{
    public class VeiculoTeste
    {
        [Fact(DisplayName ="Teste n�1")]
        [Trait("Funcionalidade", "Velocidade Acelerar")]
        public void TestarVelocidadeVeiculo()
        {
            var veiculo = new Veiculo();
            veiculo.Acelerar(10);
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact(DisplayName = "Teste n�2")]
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
        [Fact(DisplayName = "Teste n�3 - Validar Nome",Skip = "Teste n�o implementado")]
        public void ValidaNomeProprietario()
        {

        }
        [Fact]
        public void DadosVeiculo()
        {
            //Arrange
            var carro = new Veiculo();
            carro.Proprietario = "Carlos Silva";
            carro.Tipo = TipoVeiculo.Automovel;
            carro.Placa = "ZAP-4354";
            carro.Cor = "Verde";
            carro.Modelo = "Variante";

            //Act
            string dados = carro.ToString();
            //Assert
            Assert.Contains("Ficha do Ve�culo:", dados);
        }
    }
}