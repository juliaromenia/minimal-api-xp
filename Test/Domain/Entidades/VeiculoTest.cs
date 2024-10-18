using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedadesVeiculo()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Argo";
        veiculo.Marca = "Fiat";
        veiculo.Ano = 2025;

        //Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Argo", veiculo.Nome);
        Assert.AreEqual("Fiat", veiculo.Marca);
        Assert.AreEqual(2025, veiculo.Ano);
    }
}