using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDeDados
{
    public class Contato
    {
        public string Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Fone { get; }

        public Contato(string nome, string email, string fone) //construtor para criação de contato
        {
            Id = Guid.NewGuid().ToString(); //comando para gerar um id automaticamente e transformar em string.
            Nome = nome;
            Email = email;
            Fone = fone;
        }

        public Contato(string id, string nome, string email, string fone) // construtor para pesquisa
        {
            Id = id;
            Nome = nome;
            Email = email;
            Fone = fone;
        }
    }

    
}
