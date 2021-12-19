using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExemploBancoDeDados
{
    internal class ConnectionManager //exemplo de como conectar um banco de dados, não é uma boa prática.
    {
        private static string Connstr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=exemploDB;Data Source=DESKTOP-9FIQRVK\SQLEXPRESS";

        public static SqlConnection GetConnection()
        {
            var cn = new SqlConnection(Connstr);
            return cn;
        }
    }
}
