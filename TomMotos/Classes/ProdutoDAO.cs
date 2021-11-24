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

        #region METODO LISTAR PRODUTOS
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
                MessageBox.Show("Cadastrado com sucesso!");
                conexao.Close();
                }
                catch (Exception erro)
                {
                   MessageBox.Show("Cadastrado não Realizado! " + erro.Message);
            }
            conexao.Close();
        }

        #endregion

        #region METODO ADICIONAR QUANTIDADE

        public void adicionarQtd(ProdutoModel obj)
        {

            try
            {
                string insert = @"call acrescentarQTDProduto(@id_produto, @quantidade,@fornecedor);";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);                
                executacmdsql.Parameters.AddWithValue("@quantidade", obj.quantidade);     
  
                executacmdsql.Parameters.AddWithValue("@fornecedor", obj.id_fornecedor);
                executacmdsql.Parameters.AddWithValue("@id_produto", obj.id);



                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                MessageBox.Show("Adicionada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
                MessageBox.Show("Adicão não Realizado!");
            }
            conexao.Close();
        }

        #endregion

        #region METODO ALTERAR
        public void alterar(ProdutoModel obj)
        {
            try
            {

                string update = @"CALL UpdateProduto (@descricao, @quantidade,@quantidade_virtual,@valor,@marca,@imagem,@id)";
                MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
                executacmdsql.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmdsql.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmdsql.Parameters.AddWithValue("@quantidade_virtual", obj.quantidade_virtual);
                executacmdsql.Parameters.AddWithValue("@valor", obj.valor);
                executacmdsql.Parameters.AddWithValue("@marca", obj.marca);
                executacmdsql.Parameters.AddWithValue("@imagem", obj.imagem);
                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro" + erro.Message);
            }
            conexao.Close();

        }
        #endregion

        #region METODO EXCLUIR
        public void Excluir(ProdutoModel obj)
        {
            try
            {

                string update = @"Delete from tb_produto  where id_produto=@id";
                MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
                
                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Excluido com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro" + erro.Message);
            }
            conexao.Close();

        }
        #endregion
    }


}
