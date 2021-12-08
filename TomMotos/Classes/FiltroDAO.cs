using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class FiltroDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        #region BUSCA CARGO FILTRADA
        public DataTable buscaCargo()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_cargo.id_cargo AS 'ID', tb_cargo.nome_cargo AS 'CARGO', tb_cargo.salario_cargo AS 'SALARIO'
            from tb_cargo 
            where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA CLIENTE FILTRADA
        public DataTable buscaCliente()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_cliente.id_cliente AS 'ID', tb_cliente.nome_cliente AS 'NOME', tb_cliente.sobrenome_cliente AS 'SOBRENOME', 
            tb_cliente.data_nascimento_cliente AS 'DATA DE NASCIMENTO', tb_cliente.cpf_cliente AS 'CPF', tb_cliente.cnpj_cliente AS 'CNPJ'
            from tb_cliente where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA ENDEREÇO FILTRADA
        public DataTable buscaEndereco()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select id_endereco AS 'ID', rua_endereco AS 'RUA', numero_endereco AS 'NÚMERO',  bairro_endereco AS 'BAIRRO', 
            cidade_endereco AS 'CIDADE', cep_endereco AS 'CEP' from tb_endereco
            where " + campoWhere + " AND tb_endereco.fk_usuario_id = @id";

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
            executacmdsql.Parameters.AddWithValue("@id", EnderecoModel.id);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA EMAIL FILTRADA
        public DataTable buscaEmail()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select id_email AS 'ID', nome_email AS 'NOME' from tb_email
            where " + campoWhere + " AND tb_email.fk_usuario_id = @id";

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
            executacmdsql.Parameters.AddWithValue("@id", EmailModel.id);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA FORNECEDOR FILTRADA
        public DataTable buscaFornecedor()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select id_fornecedor as 'ID', nome_fornecedor as 'NOME', cnpj_fornecedor as 'CNPJ'
            from tb_fornecedor
            where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA FUNCIONARIO FILTRADA
        public DataTable buscaFuncionario(bool selecionada)
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"

            select id_funcionario as 'ID',nome_funcionario as 'NOME', sobrenome_funcionario as 'SOBRENOME', cpf_funcionario as 'CPF', 
            data_nascimento_funcionario as 'DATA DE NASCIMENTO', data_contratacao_funcionario as 'DATA DE CONTRATAÇÃO', sexo_funcionario as 'SEXO',
            nome_cargo as 'CARGO' from tb_funcionario
            inner join tb_cargo on tb_funcionario.fk_cargo_id = tb_cargo.id_cargo
            where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            if (selecionada) Filtro.Columns.Add("Selecionar", typeof(bool));
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA PRODUTOS, FUNCIONARIO, SERVIÇOS DA VENDA
        public DataTable Exibir()
        {
            string campoWhere = FiltroModel.campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(campoWhere, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA PRODUTO FILTRADA
        public DataTable buscaProduto()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select id_produto as 'ID', descricao_produto as 'DESCRIÇÃO', quantidade_produto as 'QTD', valor_produto as 'VALOR', 
            marca_produto as 'MARCA',quantidade_virtual_produto as 'QTD VIRTUAL', imagem_produto as 'IMAGEM'
            from tb_produto
            where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA VEICULO FILTRADA
        public DataTable buscaVeiculo()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_veiculo.id_veiculo as 'ID VEICULO', marca_veiculo AS 'MARCA',
            modelo_veiculo AS 'MODELO', cor_veiculo AS 'COR', ano_veiculo AS 'ANO', km_veiculo AS 'KM RODADO',
            placa_veiculo AS 'PLACA', obs_veiculo AS 'OBSERVAÇÃO', tb_veiculo.fk_cliente_id AS 'ID CLIENTE', tb_cliente.nome_cliente as 'NOME CLIENTE'
            from tb_veiculo 
            inner join tb_cliente
            on tb_cliente.id_cliente = tb_veiculo.fk_cliente_id 
            where " + campoWhere;

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion

        #region BUSCA DEVEDORES
        public DataTable buscaDevedores()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_venda.id_venda AS 'ID VENDA', tb_cliente.nome_cliente AS 'NOME CLIENTE', tb_cliente.sobrenome_cliente AS 'SOBRENOME CLIENTE', tb_cliente.cpf_cliente AS 'CPF CLIENTE',
                            tb_cliente.cnpj_cliente AS 'CNPJ CLIENTE', tb_venda.total_venda AS 'TOTAL VENDA', 
                            tb_venda.valor_pago AS 'VALOR PAGO', tb_venda.total_venda - tb_venda.valor_pago AS 'VALOR FALTANDO',
                            tb_venda.data_venda AS 'DATA VENDA'
                            from tb_cliente
                            inner join tb_venda
                            on tb_cliente.id_cliente = tb_venda.fk_cliente_id
                            where tb_venda.total_venda - tb_venda.valor_pago > 0 " + campoWhere;

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

        #region BUSCA LOG FORNECIMENTO FILTRADA
        public DataTable buscaLogFornecimento()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_log_fornecimento.id_log_fornecimento AS 'ID DO FORNECIMENTO', tb_produto.descricao_produto AS 'NOME DO PRODUTO', tb_produto.quantidade_produto AS 'QUANTIDADE DO PRODUTO',
		        tb_produto.quantidade_virtual_produto AS 'QUANTIDADE VIRTUAL DO PRODUTO', tb_fornecedor.nome_fornecedor AS 'NOME DO FORNECEDOR', 
		        tb_log_fornecimento.qtd_produto_fornecido AS 'QUANTIDADE FORNECIDA', tb_log_fornecimento.data_log_fornecimento AS 'DATA DO FORNECIMENTO'
		        from tb_produto
		        inner join tb_log_fornecimento 
		        on tb_log_fornecimento.fk_produto_id = tb_produto.id_produto
		        inner join tb_fornecedor
		        on tb_log_fornecimento.fk_fornecedor_id = tb_fornecedor.id_fornecedor where " + campoWhere + " order by tb_log_fornecimento.data_log_fornecimento desc";

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

        #region BUSCA VENDAS POR FILTRADA
        public DataTable buscaVenda()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select tb_venda.id_venda AS 'ID DA CONSULTA', tb_cliente.nome_cliente AS 'NOME DO CLIENTE', 
                tb_cliente.cpf_cliente AS 'CPF DO CLIENTE', tb_cliente.cnpj_cliente AS 'CNPJ DO CLIENTE', 
                tb_venda.validade_orcamento_servico AS 'VALIDADE DO ORÇAMENTO', 
                tb_venda.desconto_venda AS 'DESCONTO SOBRE A VENDA', tb_venda.data_venda AS 'DATA DA VENDA', 
                tb_venda.data_venda AS 'DATA DO FORNECIMENTO', tb_venda.total_venda AS 'TOTAL DA VENDA',tb_venda.valor_pago AS 'VALOR PAGO'
		        from tb_venda
		        inner join tb_cliente
		        on tb_venda.fk_cliente_id = tb_cliente.id_cliente
                where " + campoWhere + " order by tb_venda.data_venda desc";

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

        #region BUSCA TELEFONE FILTRADA
        public DataTable buscaTelefone()
        {
            string campoWhere = FiltroModel.campoWhere;

            string select = @"select id_telefone AS 'ID', numero_telefone AS 'NÚMERO' from tb_telefone
            where " + campoWhere + " AND tb_telefone.fk_usuario_id = @id";

            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
            executacmdsql.Parameters.AddWithValue("@id", TelefoneModel.id);

            conexao.Open();

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable Filtro = new DataTable();
            da.Fill(Filtro);

            conexao.Close();

            return Filtro;
        }
        #endregion
    }
}
