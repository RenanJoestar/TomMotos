using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class FuncionarioDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public FuncionarioDAO()
        {
        }

        #region METODO LISTAR
        public DataTable ListarTodosClientes()
        {
            string sql = @"select * from tb_funcionario";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaFuncionario = new DataTable();
            da.Fill(tabelaFuncionario);

            conexao.Close();

            return tabelaFuncionario;
        }
        #endregion


        #region METODO CADASTRAR

        public void cadastrar(ClienteModel obj)
        {
            try
            {
                string insert = @"CALL criacaoFuncionario(@nome, @cnpj)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@cnpj", obj.cnpj);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

    }
}
