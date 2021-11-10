using System;
using TomMotos.Conexao;
using TomMotos.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TomMotos.Classes
{
    class ProdutoUsadoDAO
    {
        #region METODO CADASTRAR 

        public void cadastrar(ProdutoUsadoModel obj)
        {
            MySqlConnection conexao = ConnectionFactory.getConnection();
            try
            {
                string insert = @"CALL criacaoProdutoUsado(@quantidade_produto_usado, @fk_produto_id, @fk_venda_id, @validade_da_garantia_produto, @desconto_produto_usado)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@quantidade_produto_usado", obj.quantidade_produto_usado);
                executacmdsql.Parameters.AddWithValue("@desconto_produto_usado", obj.desconto_produto_usado);
                executacmdsql.Parameters.AddWithValue("@fk_produto_id", obj.fk_produto_id);
                executacmdsql.Parameters.AddWithValue("@fk_venda_id", obj.fk_venda_id);
                executacmdsql.Parameters.AddWithValue("@validade_da_garantia_produto", obj.validade_da_garantia_produto);

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
