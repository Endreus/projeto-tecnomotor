using Biblioteca.Models.Entidades;
using ProjetoTec.Models.Dtos;

namespace Biblioteca.Models.Dtos
{
    public class VeiculoDto : EntidadeBase // caracteristicas do veículo //Ele herda Da entidade base o ID que irá gerar automaticamente
    {

        public string Nome { get; set; }
        public MontadoraDto Montadora { get; set;}


        public VeiculoDto() //construtor sem parametros para criação de veículos nos formulários.
        {

        }
    

        public VeiculoDto(string id, string nome, MontadoraDto montadora) //construtor que gera o id e chama o construtor seguinte
            :this(nome, montadora)
        {
            this.Id = id;
        }

        public VeiculoDto(string nome, MontadoraDto montadora) // construtor que pega as outras informações menos o id
        {
            this.Nome = nome;
            this.Montadora = montadora;

        }

    }
}
