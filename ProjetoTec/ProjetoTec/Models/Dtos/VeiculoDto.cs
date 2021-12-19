namespace ProjetoTec.Models.Dtos
{
    public class VeiculoDto
    {
        public string Id { get; set; }
        public string Nome { get; set; }


        public VeiculoDto(string id, string nome)
        {   

            Id = id;
        }

        public VeiculoDto(string nome)
        {
            Nome = nome;
        }

    }
}
