using Biblioteca.Models.Repositories;
using ProjetoTec.Models.Contracts.Repositories;
using ProjetoTec.Models.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTec.Models.Repositories
{
    public class MontadoraRepository : IMontadoraRepository
    {
        public void Atualizar(MontadoraDto montadora)
        {
            var objPesquisa = PesquisarPorId(montadora.Id); //guia de pesquisa para verificar os dados
            ContentDataFake.Montadoras.Remove(objPesquisa); //aqui ele remove o objeto de pesquisa

            objPesquisa.Nome = montadora.Nome; //aqui pego os dados do obj de pesquisa que desejo atualizar

            Cadastrar(objPesquisa); // aqui pega os dados e cadastra.
        }

        public void Cadastrar(MontadoraDto montadora)
        {
            ContentDataFake.Montadoras.Add(montadora); // cadastra um veiculo a partir do banco de dados fake
        }

        public void Excluir(string id) // igual o atualizar porém ele vai pesquisar somente o id e através disso excluir tudo nessa id, ou seja, o veículo.
        {
            var objPesquisa = PesquisarPorId(id); //guia de pesquisa para verificar os dados
            ContentDataFake.Montadoras.Remove(objPesquisa); //aqui ele remove o objeto de pesquisa
        }

        public List<MontadoraDto> Listar()
        {
            var montadoras = ContentDataFake.Montadoras; //acessando os dados do banco fake
            return montadoras.OrderBy(p => p.Nome).ToList(); // retornando os dados do banco fake

        }

        public MontadoraDto PesquisarPorId(string id)
        {
            var montadora = ContentDataFake.Montadoras.FirstOrDefault(p => p.Id == id);
            return montadora;
        }
    }
}
