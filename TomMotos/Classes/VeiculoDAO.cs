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
    class VeiculoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public VeiculoDAO()
        {
        }

        #region METODO LISTAR
        public DataTable ListarTodosVeiculos()
        {
            string sql = @"select tb_cliente.nome_cliente, tb_veiculo.id_veiculo, marca_veiculo, modelo_veiculo, cor_veiculo, ano_veiculo, km_veiculo, placa_veiculo, obs_veiculo from tb_veiculo
                          inner join tb_cliente on tb_veiculo.fk_cliente_id = tb_cliente.id_cliente";

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


        #region METODO LISTAR CLIENTE
        public DataTable ListarTodosClientes()
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


        #region METODO CADASTRAR

        public void cadastrar(VeiculoModel obj)
        {
            int a=1;
            if (obj.marca == "" || obj.modelo == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");

            }
            else
            {

                try
                {
                    string insert = @"CALL criacaoVeiculo(@marca, @modelo, @cor ,@ano, @km, @placa, @obs, @fk_cliente_id)";

                    MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                    executacmdsql.Parameters.AddWithValue("@marca", obj.marca);
                    executacmdsql.Parameters.AddWithValue("@modelo", obj.modelo);
                    executacmdsql.Parameters.AddWithValue("@cor", obj.cor_veiculo);
                    executacmdsql.Parameters.AddWithValue("@ano", obj.ano_veiculo);
                    executacmdsql.Parameters.AddWithValue("@km", obj.km_veiculo);
                    executacmdsql.Parameters.AddWithValue("@placa", obj.placa_veiculo);
                    executacmdsql.Parameters.AddWithValue("@obs", obj.obs_veiculo);
                    executacmdsql.Parameters.AddWithValue("@fk_cliente_id", obj.cliente_fk);

                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    a = 2;
                    MessageBox.Show("Erro: " + erro);
                }
                if (a == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Cadastrado não Realizado!");
                }
            }

        }
        #endregion
    }
}
