namespace ProjetoTec.Models.Dtos
{
    public class MontadoraDto
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public MontadoraDto(string id, string nome)
        {
            Id = id;
        }

        public MontadoraDto(string nome)
        {
            this.Nome = nome;
        }
    }
}
