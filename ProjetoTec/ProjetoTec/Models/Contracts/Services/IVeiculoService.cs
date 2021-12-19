using Biblioteca.Models.Dtos;
using System.Collections.Generic;

namespace Biblioteca.Models.Contracts.Services
{
    public interface IVeiculoService
    {
        void Cadastrar(VeiculoDto veiculo);
        List<VeiculoDto> Listar();

        VeiculoDto PesquisarPorID(string id);

        void Atualizar(VeiculoDto veiculo);

        void Excluir(string id);
    }
}
