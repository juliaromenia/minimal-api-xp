using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>(){
        new Veiculo{
            Id = 1,
            Nome = "HB20",
            Marca = "Hyundai",
            Ano = 2025
        },
        new Veiculo{
            Id = 2,
            Nome = "FIAT",
            Marca = "TORO",
            Ano = 2025
        }
    };

    public void Apagar(Veiculo veiculo)
    {
        var veiculoExistente = veiculos.FirstOrDefault(x => x.Id == veiculo.Id);
        if (veiculoExistente != null)
        {
            veiculos.Remove(veiculoExistente);
        }
    }

    public void Atualizar(Veiculo veiculo)
    {
        var veiculoExistente = veiculos.FirstOrDefault(x => x.Id == veiculo.Id);
        if (veiculoExistente != null)
        {
            veiculoExistente.Nome = veiculo.Nome;
            veiculoExistente.Marca = veiculo.Marca;
            veiculoExistente.Ano = veiculo.Ano;
        }
    }

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count() + 1;
        veiculos.Add(veiculo);
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }
}