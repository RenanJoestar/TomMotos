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
    class ServicoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public ServicoDAO()
        {
        }

        #region METODO CADASTRAR

        public void cadastrarServicoPrestado(ServicoModel obj)
        {
            try
            {
                string insert = @"CALL criacaoServicoPrestado(@descricao_servico_prestado, @valor_servico_prestado, @fk_venda_id)";

                MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                executacmdsql.Parameters.AddWithValue("@descricao_servico_prestado", obj.descricao_servico_prestado);
                executacmdsql.Parameters.AddWithValue("@valor_servico_prestado", obj.valor_servico_prestado);
                executacmdsql.Parameters.AddWithValue("@fk_venda_id", obj.fk_venda_id);

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

        #region METODO LISTAR POR ID

        public ArrayList listarPorVenda(int idVenda)
        {
            MySqlConnection conexao = ConnectionFactory.getConnection();
            ArrayList resultado = new ArrayList();

            try
            {
                string select = @"
                                select tb_servico_prestado.descricao_servico_prestado, tb_servico_prestado.valor_servico_prestado from tb_servico_prestado
                                inner join tb_venda on tb_servico_prestado.fk_venda_id = tb_venda.id_venda 
                                where tb_venda.id_venda = " + idVenda + ";";

                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                conexao.Open();
                MySqlDataReader reader = executacmdsql.ExecuteReader();

                while (reader.Read())
                {
                    resultado.Add(Convert.ToString(reader[0].ToString()));
                    resultado.Add(Convert.ToDouble(reader[1].ToString()));
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
