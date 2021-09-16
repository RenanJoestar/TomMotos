using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class FrmlogFornecimento : Form
    {
        LogFornecimentoDAO LogFornecimento = new LogFornecimentoDAO();
        public FrmlogFornecimento()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmlogFornecimento_Load(object sender, EventArgs e)
        {
            dg_log_fornecimento.DataSource = LogFornecimento.ListarTodosFornecimento();
            dtp1.Visible = false;
            dtp2.Visible = false;
        }

        private void FrmlogFornecimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbxBuscar.Text.ToString();
                string finalSQL = "";
                if (campo == "ID DO LOG DE FORNECIMENTO") campo = "tb_log_fornecimento.id_log_fornecimento";
                if (campo == "NOME DO PRODUTO") campo = "tb_produto.descricao_produto";
                if (campo == "NOME DO FORNECEDOR") campo = "tb_fornecedor.nome_fornecedor";

                if (campo == "DATA DO FORNECIMENTO")
                {
                    finalSQL = "tb_log_fornecimento.data_log_fornecimento BETWEEN ' " + dtp1.Value.ToString("yyyy/MM/dd") + " 00:00:00' AND ' " + dtp2.Value.ToString("yyyy/MM/dd") + " " + "23:59:59'";
                }
                else
                {
                    finalSQL = campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                }

                FiltroModel.filtro = @"select tb_log_fornecimento.id_log_fornecimento AS 'ID DO FORNECIMENTO', tb_produto.descricao_produto AS 'NOME DO PRODUTO', tb_produto.quantidade_produto AS 'QUANTIDADE DO PRODUTO',
		        tb_produto.quantidade_virtual_produto AS 'QUANTIDADE VIRTUAL DO PRODUTO', tb_fornecedor.nome_fornecedor AS 'NOME DO FORNECEDOR', 
		        tb_log_fornecimento.qtd_produto_fornecido AS 'QUANTIDADE FORNECIDA', tb_log_fornecimento.data_log_fornecimento AS 'DATA DO FORNECIMENTO'
		        from tb_produto
		        inner join tb_log_fornecimento 
		        on tb_log_fornecimento.fk_produto_id = tb_produto.id_produto
		        inner join tb_fornecedor
		        on tb_log_fornecimento.fk_fornecedor_id = tb_fornecedor.id_fornecedor where " + finalSQL;
                FiltroDAO dao = new FiltroDAO();
                dg_log_fornecimento.DataSource = dao.buscaCargo();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void btn_mostrar_tudo_Click(object sender, EventArgs e)
        {
            dg_log_fornecimento.DataSource = LogFornecimento.ListarTodosFornecimento();
        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscar.Text.ToString() == "DATA DO FORNECIMENTO")
            {
                dtp1.Visible = true;
                dtp2.Visible = true;
            }
            else
            {
                dtp1.Visible = false; 
                dtp2.Visible = false;
            }
        }
    }
}
