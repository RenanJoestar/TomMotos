using System;
using TomMotos.Conexao;
using TomMotos.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

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

        #region METODO LISTAR 

        public ArrayList listarPorVenda(int idVenda)
        {
            MySqlConnection conexao = ConnectionFactory.getConnection();
            ArrayList resultado = new ArrayList();
            
            try
            {
                string select = @"
                                select tb_produto.id_produto, tb_produto.descricao_produto, tb_produto_usado.quantidade_produto_usado, 
                                tb_produto.valor_produto, tb_produto_usado.desconto_produto_usado from tb_produto_usado 
                                inner join tb_venda on tb_produto_usado.fk_venda_id = tb_venda.id_venda inner join
                                tb_produto on tb_produto.id_produto = tb_produto_usado.fk_produto_id
                                where tb_venda.id_venda = " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                MySqlDataReader reader = executacmdsql.ExecuteReader();

                while (reader.Read())
                {
                    resultado.Add(Convert.ToInt32(reader[0].ToString()));
                    resultado.Add(Convert.ToString(reader[1].ToString()));
                    resultado.Add(Convert.ToDouble(reader[2].ToString()));
                    resultado.Add(Convert.ToDouble(reader[3].ToString()));
                    resultado.Add(Convert.ToDouble(reader[4].ToString()));
                }
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            return resultado;
        }
        #endregion
    }
}
