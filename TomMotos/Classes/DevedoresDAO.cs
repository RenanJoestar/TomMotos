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
    class DevedoresDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public DevedoresDAO()
        {
        }

        #region METODO LISTAR TODOS
        public DataTable listarTodos()
        {

            string sql = @"select tb_venda.id_venda AS 'ID VENDA', tb_cliente.nome_cliente AS 'NOME CLIENTE', tb_cliente.sobrenome_cliente AS 'SOBRENOME CLIENTE', tb_cliente.cpf_cliente AS 'CPF CLIENTE',
                            tb_cliente.cnpj_cliente AS 'CNPJ CLIENTE', tb_venda.total_venda AS 'TOTAL VENDA', 
                            tb_venda.valor_pago AS 'VALOR PAGO', tb_venda.total_venda - tb_venda.valor_pago AS 'VALOR FALTANDO',
                            tb_venda.data_venda AS 'DATA VENDA'
                            from tb_cliente
                            inner join tb_venda
                            on tb_cliente.id_cliente = tb_venda.fk_cliente_id
                            where tb_venda.total_venda - tb_venda.valor_pago > 0;";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaCargo = new DataTable();
            da.Fill(tabelaCargo);

            conexao.Close();

            return tabelaCargo;
        }
        #endregion

        #region UPDATE VALOR PAGO
        public void updateValorPago(DevedorModel obj)
        {

            string update = @"Update tb_venda set valor_pago = valor_pago + @valor_pago where tb_venda.id_venda = @id_venda";
            MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
            executacmdsql.Parameters.AddWithValue("@id_venda", obj.id_venda);
            executacmdsql.Parameters.AddWithValue("@valor_pago", obj.valor_pago);
            conexao.Open();
            executacmdsql.ExecuteNonQuery();
            conexao.Close();
        }
        #endregion
    }
}
