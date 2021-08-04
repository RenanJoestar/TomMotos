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
    class ProdutoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public ProdutoDAO()
        {
        }

        #region METODO LISTAR
        public DataTable ListarTodosProdutos()
        {
            string sql = @"select * from tb_produto";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            conexao.Close();

            return tabelaProduto;
        }
        #endregion




        #region METODO CADASTRAR

        public void cadastrarProduto(ProdutoModel obj)
        {
            
            try
            {
                string insert = @"CALL criacaoProduto(@descricao, @quantidade,@quantidade_virtual, @valor, @marca, @imagem)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmdsql.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmdsql.Parameters.AddWithValue("@quantidade_virtual", obj.quantidade_virtual);
                executacmdsql.Parameters.AddWithValue("@valor", obj.valor);
                executacmdsql.Parameters.AddWithValue("@marca", obj.marca);
                executacmdsql.Parameters.AddWithValue("@imagem", obj.imagem);
                


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
