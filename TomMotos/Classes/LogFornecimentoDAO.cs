using MySql.Data.MySqlClient;
using System.Data;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class LogFornecimentoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        #region METODO LISTAR FORNECIMENTO
        public DataTable ListarTodosFornecimento()
        {
            string sql = @"select tb_log_fornecimento.id_log_fornecimento AS 'ID DO FORNECIMENTO', tb_produto.descricao_produto AS 'NOME DO PRODUTO', tb_produto.quantidade_produto AS 'QUANTIDADE DO PRODUTO',
		        tb_produto.quantidade_virtual_produto AS 'QUANTIDADE VIRTUAL DO PRODUTO', tb_fornecedor.nome_fornecedor AS 'NOME DO FORNECEDOR', 
		        tb_log_fornecimento.qtd_produto_fornecido AS 'QUANTIDADE FORNECIDA', tb_log_fornecimento.data_log_fornecimento AS 'DATA DO FORNECIMENTO'
		        from tb_produto
		        inner join tb_log_fornecimento 
		        on tb_log_fornecimento.fk_produto_id = tb_produto.id_produto
		        inner join tb_fornecedor
		        on tb_log_fornecimento.fk_fornecedor_id = tb_fornecedor.id_fornecedor;";

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
    }
}
