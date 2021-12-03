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
        LogFornecimentoDAO LogFornecimentoDAO = new LogFornecimentoDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public FrmlogFornecimento()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmlogFornecimento_Load(object sender, EventArgs e)
        {
            cxbData.Checked = true;
            dtp1.Value = dtp1.Value.AddDays(-14);
            pesquisarVendaComFiltro(); //Puxa todos os orçamentos de 2 semanas para cá
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisarVendaComFiltro();
        }
        private void pesquisarVendaComFiltro()
        {
            try
            {
                string campo = cbxBuscar.Text.ToString();
                string finalSQL = "tb_log_fornecimento.id_log_fornecimento > 0"; // PARA LOGICA DO AND 
                if (campo == "ID DO LOG DE FORNECIMENTO") campo = "tb_log_fornecimento.id_log_fornecimento";
                if (campo == "NOME DO PRODUTO") campo = "tb_produto.descricao_produto";
                if (campo == "NOME DO FORNECEDOR") campo = "tb_fornecedor.nome_fornecedor";
                if (campo != "") finalSQL += " AND " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                if (cxbData.Checked)
                {
                    finalSQL = finalSQL + " AND tb_log_fornecimento.data_log_fornecimento BETWEEN ' " + dtp1.Value.ToString("yyyy/MM/dd") + " 00:00:00' AND ' " + dtp2.Value.ToString("yyyy/MM/dd") + " " + "23:59:59'";
                }
                FiltroModel.campoWhere = finalSQL;

                dg_log_fornecimento.DataSource = Filtro.buscaLogFornecimento();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void btn_mostrar_tudo_Click(object sender, EventArgs e)
        {
            dg_log_fornecimento.DataSource = LogFornecimentoDAO.ListarTodosFornecimentoS();
            txtBuscar.Text = "";
            cbxBuscar.Text = "";
            cxbData.Checked = false;
        }
    }
}
