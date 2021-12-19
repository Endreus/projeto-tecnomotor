using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ExemploBancoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestarConexao();
            //TestarCadastro();
            var result = TestarPesquisa();
        }

        static void TestarConexao()
        {
            try
            {
                var connection = ConnectionManager.GetConnection();
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestarCadastro()
        {
            try
            {
                var contatos = ListarContatos(); //cria um objeto contatos que vai listar os contatos.

                var connection = ConnectionManager.GetConnection(); //objeto de conexão
                connection.Open(); //abri a conexão //O SqlCommand recebe esse parametro para poder se conectar no BD.

                foreach(var contato in contatos) //cria um loop
                {
                    var query = "insert into contato(id, nome, email,fone) values (@id, @nome, @email, @fone)"; //o SqlCommand recebe isso para executar no BD

                    var command = new SqlCommand(query, connection);//SqlCommand ele é uma classe usada para executar comandos no SQL,
                                                                    //então pra executar ele recebe os parametros que serão executados como a *query e *connection
                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = contato.Id; //o command declarada na linha de cima, recebe os Parameters(parametros)
                                                                                         //@id igual declarada na query  depois vem o tipo do sql que esta como varchar e recebe
                                                                                         // os valores da id do contato.

                    command.Parameters.Add("@nome", SqlDbType.VarChar).Value = contato.Nome;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = contato.Email;
                    command.Parameters.Add("@fone", SqlDbType.VarChar).Value = contato.Fone;

                    command.ExecuteNonQuery(); //comando para execução dos comandos acima.
                }
                connection.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static List<Contato> TestarPesquisa()
        {
            try
            {
                var contatos = new List<Contato>();

                var connection = ConnectionManager.GetConnection(); //objeto de conexão
                connection.Open(); //abri a conexão //O SqlCommand recebe esse parametro para poder se conectar no BD.

                var query = "select id, nome, email, fone from contato order by nome"; //o SqlCommand recebe isso para executar no BD

                var command = new SqlCommand(query, connection);

                var dataset = new DataSet(); // dataset é um banco de dados em memória
                var adapter = new SqlDataAdapter(command); // adapter permite o dataset caerragr as informações
                adapter.Fill(dataset); // Fill para preencher o dataset
                var rows = dataset.Tables[0].Rows;


                foreach (DataRow item in rows)
                {
                    var colunas = item.ItemArray;

                    var id = colunas[0].ToString();
                    var nome = colunas[1].ToString();
                    var email = colunas[2].ToString();
                    var fone = colunas[3].ToString();

                    var contato = new Contato(id, nome, email, fone);
                    contatos.Add(contato);
                }
                connection.Close();

                return contatos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        static List<Contato> ListarContatos()
        {
            var contatos = new List<Contato>();

            var c1 = new Contato("Joao Silva", "joao.silva@gmail.com", "16 1010-2054");
            var c2 = new Contato("Pedro Santos", "pedro.santos@gmail.com", "16 3366-5070");
            var c3 = new Contato("Antonio Alves", "antonio.alves@gmail.com", "16 4020-7895");

            contatos.Add(c1);
            contatos.Add(c2);
            contatos.Add(c3);

            return contatos;
        }
    }
}
