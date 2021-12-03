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
        #region METODO LISTAR FUNCIONARIO
        public DataTable ListarTodosFuncionario()
        {
            string sql = @"select id_funcionario, nome_funcionario, nome_cargo from tb_funcionario 
                           inner join tb_cargo on tb_funcionario.fk_cargo_id = tb_cargo.id_cargo";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaFuncionario = new DataTable();
            tabelaFuncionario.Columns.Add("Estado", typeof(bool));
            da.Fill(tabelaFuncionario);

            conexao.Close();

            return tabelaFuncionario;
        }
        #endregion

        #region METODO CADASTRAR VENDA

        public void cadastrarVenda(CaixaModel obj)
        {
                string insert = @"CALL criacaoVenda(@validade_orcamento_servico, @desconto_venda,@total_venda, @total_venda, @fk_veiculo_id, @fk_cliente_id)";

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


        #endregion

        #region METODO LISTAR TOTAL ORÇAMENTO POR ID

        public string listarTotalVendaPorId(int idVenda)
        {
            CaixaModel.totalVenda_orcamento = null;
            try
            {
                string select = @"select tb_venda.total_venda, tb_venda.valor_pago from tb_venda where tb_venda.id_venda = " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

                DataSet ds = new DataSet();
                da.Fill(ds);
                CaixaModel.totalVenda_orcamento = (double.Parse(ds.Tables[0].Rows[0]["total_venda"].ToString())-double.Parse(ds.Tables[0].Rows[0]["valor_pago"].ToString())).ToString();
             

                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
                MessageBox.Show("Cadastrado não Realizado!");
            }
            conexao.Close();
            return CaixaModel.totalVenda_orcamento;
        }


        #endregion

        #region METODO CADASTRAR FUNCIONARIOS NA VENDA

        public void cadastrarGrupoFunc(CaixaModel obj)
        {
            string insert = @"CALL criacaoGrupoFuncionarios(@fk_venda, @fk_funcionario)";

            MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
            executacmdsql.Parameters.AddWithValue("@fk_venda", CaixaModel.id_venda);
            executacmdsql.Parameters.AddWithValue("@fk_funcionario", CaixaModel.fk_funcionario_id);           

            conexao.Open();
            executacmdsql.ExecuteNonQuery();
            conexao.Close();

        }


        #endregion

        #region METODO CADASTRAR ORÇAMENTO

        public void cadastrarOrcamento(CaixaModel obj)
        {
                string insert = @"CALL criacaoOrcamento(@validade_orcamento_servico, @desconto_venda,@valor_pago, @total_venda, @fk_veiculo_id, @fk_cliente_id, @e_orcamento)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@validade_orcamento_servico", obj.validade_orcamento_servico);
                executacmdsql.Parameters.AddWithValue("@desconto_venda", obj.desconto);
                executacmdsql.Parameters.AddWithValue("@valor_pago", CaixaModel.valor_pago);
                executacmdsql.Parameters.AddWithValue("@total_venda", obj.total);
                executacmdsql.Parameters.AddWithValue("@fk_veiculo_id", CaixaModel.fk_veiculo_id);
                executacmdsql.Parameters.AddWithValue("@fk_cliente_id", CaixaModel.fk_cliente_id);
                executacmdsql.Parameters.AddWithValue("@e_orcamento", true);

                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Orçamento salvo!");
            
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
            conexao.Close();
        }

        #endregion

        #region METODO PESQUISAR ULTIMA VENDA 

        public string listarUltimaVenda()
        {
            string resultado = "";
               string select = @"SELECT MAX(id_venda) FROM tb_venda;";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                conexao.Open();
                resultado = executacmdsql.ExecuteScalar().ToString();
                conexao.Close();           
          
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
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Close();
            return resultado;
        }
        #endregion

        #region LISTAR TODOS ORÇAMENTOS/VENDAS
        public DataTable listarTodos(bool orcamento)
        {
            string sql = @"select tb_venda.id_venda AS 'ID DA CONSULTA', tb_cliente.nome_cliente AS 'NOME DO CLIENTE', 
                tb_cliente.cpf_cliente AS 'CPF DO CLIENTE', tb_cliente.cnpj_cliente AS 'CNPJ DO CLIENTE', 
		        tb_venda.validade_orcamento_servico AS 'VALIDADE DO ORÇAMENTO', tb_venda.desconto_venda AS 'DESCONTO SOBRE A VENDA', 
		        tb_venda.data_venda AS 'DATA DA VENDA', tb_venda.data_venda AS 'DATA DO FORNECIMENTO', tb_venda.total_venda AS 'TOTAL DA VENDA',tb_venda.valor_pago AS 'VALOR PAGO'
		        from tb_venda
		        inner join tb_cliente
		        on tb_venda.fk_cliente_id = tb_cliente.id_cliente
                where tb_venda.e_orcamento = " + orcamento + " order by tb_venda.data_venda desc";

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