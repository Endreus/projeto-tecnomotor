using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Models.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public void Atualizar(VeiculoDto veiculo)
        {
           var objPesquisa = PesquisarPorId(veiculo.Id); //guia de pesquisa para verificar os dados
            ContentDataFake.Veiculos.Remove(objPesquisa); //aqui ele remove o objeto de pesquisa

            objPesquisa.Nome = veiculo.Nome; //aqui pego os dados do obj de pesquisa que desejo atualizar

            Cadastrar(objPesquisa); // aqui pega os dados e cadastra.
        }

        public void Cadastrar(VeiculoDto veiculo)
        {
            ContentDataFake.Veiculos.Add(veiculo); // cadastra um veiculo a partir do banco de dados fake
        }

        public void Excluir(string id) // igual o atualizar porém ele vai pesquisar somente o id e através disso excluir tudo nessa id, ou seja, o veículo.
        {
            var objPesquisa = PesquisarPorId(id); //guia de pesquisa para verificar os dados
            ContentDataFake.Veiculos.Remove(objPesquisa); //aqui ele remove o objeto de pesquisa
        }

        public List<VeiculoDto> Listar()
        {
            var veiculos = ContentDataFake.Veiculos; //acessando os dados do banco fake
            return veiculos.OrderBy(p => p.Nome).ToList(); // retornando os dados do banco fake

        }

        public VeiculoDto PesquisarPorId(string id)
        {
            var livro = ContentDataFake.Veiculos.FirstOrDefault(p => p.Id == id);
            return livro;
        }

    }
}
