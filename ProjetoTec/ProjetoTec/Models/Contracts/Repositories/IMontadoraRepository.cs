using ProjetoTec.Models.Dtos;
using System.Collections.Generic;

namespace ProjetoTec.Models.Contracts.Repositories
{
    public interface IMontadoraRepository
    {
        
            void Cadastrar(MontadoraDto montadora);
            List<MontadoraDto> Listar();

            MontadoraDto PesquisarPorId(string id);

            void Atualizar(MontadoraDto montadora);

            void Excluir(string id);
    }
}
