using System;
using TomMotos.Conexao;
using TomMotos.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Data;

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
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Close();
        }
        #endregion

    #region METODO LISTAR POR ID

        public ArrayList listarPorVenda(int idVenda)
        {
            MySqlConnection conexao = ConnectionFactory.getConnection();
            ArrayList resultado = new ArrayList();
            
            try
            {
                string select = @"
                                select tb_produto.id_produto, tb_produto.descricao_produto, tb_produto_usado.quantidade_produto_usado, 
                                tb_produto.valor_produto, tb_produto_usado.desconto_produto_usado, tb_venda.fk_veiculo_id, tb_venda.fk_cliente_id from tb_produto_usado 
                                inner join tb_venda on tb_produto_usado.fk_venda_id = tb_venda.id_venda inner join
                                tb_produto on tb_produto.id_produto = tb_produto_usado.fk_produto_id
                                where tb_venda.id_venda = " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ClienteModel.fk_cliente = ds.Tables[0].Rows[0]["fk_cliente_id"].ToString();
                    VeiculoModel.fk_veiculo =  ds.Tables[0].Rows[0]["fk_veiculo_id"].ToString();                    
                }
                MySqlDataReader reader = executacmdsql.ExecuteReader();
                if (reader.HasRows)
                {
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
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            return resultado;
        }
        #endregion
    }
}
