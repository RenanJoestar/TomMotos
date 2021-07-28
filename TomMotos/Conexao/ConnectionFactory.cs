using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TomMotos.Conexao
{
    class ConnectionFactory
    {
        internal static MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bd_tommotos"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
