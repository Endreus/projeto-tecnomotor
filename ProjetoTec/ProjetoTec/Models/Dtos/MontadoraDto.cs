using Biblioteca.Models.Entidades;

namespace ProjetoTec.Models.Dtos
{
    public class MontadoraDto : EntidadeBase
    {

        public string Nome { get; set; }

        public MontadoraDto(string id, string nome) //construtor que gera o id e chama o construtor seguinte
            : this(nome)
        {
            this.Id = id;
        }

        public MontadoraDto(string nome) // construtor que pega as outras informações menos o id
        {
            this.Nome = nome;

        }
    }
}
