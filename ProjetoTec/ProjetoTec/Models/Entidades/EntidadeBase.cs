using System;

namespace Biblioteca.Models.Entidades
{
    public abstract class EntidadeBase // Entidade que vai gerar o ID do veiculo automaticamente
    {
        public string Id { get; set; }

        public EntidadeBase() //contrutor que gera o ID
        {
            Id = Guid.NewGuid().ToString(); //criará a ID e transformará em string para colocar na tela.
        }
    }
}
