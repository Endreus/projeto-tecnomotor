using Biblioteca.Models.Dtos;
using System.Collections.Generic;

namespace Biblioteca.Models.Contracts.Repositories
{
    public interface IVeiculoRepository
    {
        void Cadastrar(VeiculoDto veiculo);
        List<VeiculoDto> Listar();

        VeiculoDto PesquisarPorId(string id);

        void Atualizar(VeiculoDto veiculo);

        void Excluir(string id);
    }
}
