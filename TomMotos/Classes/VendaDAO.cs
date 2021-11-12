using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    class VendaDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        #region METODO CADASTRAR VENDA

        public void cadastrarVenda(CaixaModel obj)
        {
            try
            {
                string insert = @"CALL criacaoVenda(@validade_orcamento_servico, @desconto_venda, @total_venda, @fk_veiculo_id, @fk_cliente_id)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@validade_orcamento_servico", obj.validade_orcamento_servico);
                executacmdsql.Parameters.AddWithValue("@desconto_venda", obj.desconto);
                executacmdsql.Parameters.AddWithValue("@total_venda", obj.total);
                executacmdsql.Parameters.AddWithValue("@fk_veiculo_id", CaixaModel.fk_veiculo_id);
                executacmdsql.Parameters.AddWithValue("@fk_cliente_id", CaixaModel.fk_cliente_id);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                MessageBox.Show("Cadastrado não Realizado!");
            }
        }


        #endregion

        #region METODO LISTAR TOTAL ORÇAMENTO POR ID

        public string listarTotalVendaPorId(int idVenda)
        {
            string totalVenda = null;
            try
            {
                string select = @"select tb_venda.total_venda from tb_venda where tb_venda.id_venda = " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                totalVenda = executacmdsql.ExecuteScalar().ToString();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                MessageBox.Show("Cadastrado não Realizado!");
            }
            return totalVenda;
        }


        #endregion

        #region METODO CADASTRAR ORÇAMENTO

        public void cadastrarOrcamento(CaixaModel obj)
        {
            try
            {
                string insert = @"CALL criacaoOrcamento(@validade_orcamento_servico, @desconto_venda, @total_venda, @fk_veiculo_id, @fk_cliente_id, @e_orcamento)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@validade_orcamento_servico", obj.validade_orcamento_servico);
                executacmdsql.Parameters.AddWithValue("@desconto_venda", obj.desconto);
                executacmdsql.Parameters.AddWithValue("@total_venda", obj.total);
                executacmdsql.Parameters.AddWithValue("@fk_veiculo_id", CaixaModel.fk_veiculo_id);
                executacmdsql.Parameters.AddWithValue("@fk_cliente_id", CaixaModel.fk_cliente_id);
                executacmdsql.Parameters.AddWithValue("@e_orcamento", true);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                MessageBox.Show("Cadastrado não Realizado!");
            }
        }


        #endregion

        #region METODO MUDAR STATUS DA VENDA

        public void mudarStatusVenda(string objVenda, bool status)
        {
            try
            {
                string update = @"CALL mudarStatusVenda(@id_venda, " + status + ");";

                MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                executacmdsql.Parameters.AddWithValue("@id_venda", objVenda);

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

        #region METODO PESQUISAR ULTIMA VENDA 

        public string listarUltimaVenda()
        {
            string resultado = "";
            try
            {
                string select = @"SELECT MAX(id_venda) FROM tb_venda;";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                conexao.Open();
                resultado = executacmdsql.ExecuteScalar().ToString();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            return resultado;
        }

        #endregion

        #region METODO ALTERAR
        public void alterar()
        {
        }
        #endregion

        #region METODO EXCLUIR
        public void Excluir()
        {
        }
        #endregion

        #region LISTAR TODOS VEICULOS
        public DataTable ListarTodosVeiculo()
        {

            string sql = @"select * from tb_veiculo";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaVeiculo = new DataTable();
            da.Fill(tabelaVeiculo);

            conexao.Close();

            return tabelaVeiculo;
        }
        #endregion

        #region LISTAR TODOS CLIENTES
        public DataTable ListarTodosCliente()
        {

            string sql = @"select * from tb_cliente";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaCliente = new DataTable();
            da.Fill(tabelaCliente);

            conexao.Close();

            return tabelaCliente;
        }
        #endregion

        #region LISTAR SERVIÇOS PRESTADOS
        public string listarServiçosPrestados(int idVenda)
        {
            string resultado = null;
            try
            {
                string select = @"select tb_venda.descricao_mao_de_obra, tb_venda.preco_mao_de_obra 
                                  from tb_venda where tb_venda.id_venda " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                MySqlDataReader reader = executacmdsql.ExecuteReader();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
            return resultado;
        }
        #endregion

        #region LISTAR TODAS ORÇAMENTOS
        public DataTable listarTodosOrcamentos()
        {
            string sql = @"select tb_venda.id_venda AS 'ID DO ORÇAMENTO', tb_cliente.nome_cliente AS 'NOME DO CLIENTE', 
                tb_cliente.cpf_cliente AS 'CPF DO CLIENTE', 
		        tb_venda.validade_orcamento_servico AS 'VALIDADE DO ORÇAMENTO', tb_venda.desconto_venda AS 'DESCONTO SOBRE A VENDA', 
		        tb_venda.data_venda AS 'DATA DA VENDA', tb_venda.data_venda AS 'DATA DO FORNECIMENTO'
		        from tb_venda
		        inner join tb_cliente
		        on tb_venda.fk_cliente_id = tb_cliente.id_cliente
                where tb_venda.e_orcamento = true order by tb_venda.id_venda;";

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

        #region LISTAR VENDAS POR FILTRO
        public DataTable listarVendaPor(string finalSQL)
        {
            string select = @"select tb_venda.id_venda AS 'ID DO ORÇAMENTO', tb_cliente.nome_cliente AS 'NOME DO CLIENTE', 
                tb_cliente.cpf_cliente AS 'CPF DO CLIENTE', 
		        tb_venda.validade_orcamento_servico AS 'VALIDADE DO ORÇAMENTO', tb_venda.desconto_venda AS 'DESCONTO SOBRE A VENDA', 
		        tb_venda.data_venda AS 'DATA DA VENDA', tb_venda.data_venda AS 'DATA DO FORNECIMENTO'
		        from tb_venda
		        inner join tb_cliente
		        on tb_venda.fk_cliente_id = tb_cliente.id_cliente
                where tb_venda.e_orcamento = true " + finalSQL + " order by tb_venda.id_venda";

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();
            conexao.Close();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaProduto = new DataTable();
            da.Fill(tabelaProduto);

            return tabelaProduto;
        }
        #endregion
    }
}