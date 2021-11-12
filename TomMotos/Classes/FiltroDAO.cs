using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class FiltroDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        public DataTable buscaCargo()
        {
            string sql = FiltroModel.filtro;

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
            
            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
    }
}
