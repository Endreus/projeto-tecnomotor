using Biblioteca.Models.Entidades;

namespace Biblioteca.Models.Dtos
{
    public class VeiculoDto : EntidadeBase // caracteristicas do livro //Ele herda Da entidade base o ID que irá gerar automaticamente
    {

        public string Nome { get; set; }


        public VeiculoDto() //construtor sem parametros para criação de livros nos formulários.
        {

        }
    

        public VeiculoDto(string id, string nome) //construtor que gera o id e chama o construtor seguinte
            :this(nome)
        {
            this.Id = id;
        }

        public VeiculoDto(string nome) // construtor que pega as outras informações menos o id
        {
            this.Nome = nome;

        }

    }
}
