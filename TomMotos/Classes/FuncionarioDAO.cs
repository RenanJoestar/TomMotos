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
        public DataTable ListarTodosFuncionario()
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


        #region METODO LISTAR CARGO
        public DataTable ListarTodosCargos()
        {
            string sql = @"select * from tb_cargo";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaCargo = new DataTable();
            da.Fill(tabelaCargo);

            conexao.Close();

            return tabelaCargo;
        }
        #endregion



        #region METODO CADASTRAR

        public void cadastrarFuncionario(FuncionarioModel obj)
        {
            try
            {
                string insert = @"CALL criacaoFuncionario(@nome, @sobrenome,@cpf, @data_nasc, @data_contratacao, @sexo,@cargo_fk)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@sobrenome", obj.sobrenome);
                executacmdsql.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmdsql.Parameters.AddWithValue("@data_nasc", obj.data_nasc);
                executacmdsql.Parameters.AddWithValue("@data_contratacao", obj.data_contratacao);
                executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmdsql.Parameters.AddWithValue("@cargo_fk", obj.cargo_fk);
                
                
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
