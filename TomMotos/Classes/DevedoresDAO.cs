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
                            tb_venda.valor_pago AS 'VALOR PAGO', tb_venda.total_venda - tb_venda.valor_pago AS 'VALOR FALTANDO'
                            from tb_cliente
                            inner join tb_venda
                            on tb_cliente.id_cliente = tb_venda.fk_cliente_id
                            where tb_venda.total_venda - tb_venda.valor_pago != 0;";

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
    }
}
