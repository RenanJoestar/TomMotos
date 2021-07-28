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
    class FornecedorDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public FornecedorDAO()
        {
        }

        #region METODO LISTAR
        public DataTable ListarTodosFornecedores()
        {

            //tem que mudar o select para a storeProcedur, porém tem que criar o metodo cadastra telefone, email e endereco

            string sql = @"select * from tb_fornecedor";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaFornecedor = new DataTable();
            da.Fill(tabelaFornecedor);

            conexao.Close();

            return tabelaFornecedor;
        }
        #endregion


        #region METODO CADASTRAR

        public void cadastrarFornecedor(FornecedorModel obj)
        {
            try
            {
                string insert = @"CALL criacaoFornecedor(@nome, @cnpj)";

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

