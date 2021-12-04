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
    public partial class FmrDevedores : Form
    {
        DevedoresDAO DevedoresDAO = new DevedoresDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public FmrDevedores()
        {
            InitializeComponent();
        }

        private void FmrDevedores_Load(object sender, EventArgs e)
        {
            dgDevedores.DataSource = DevedoresDAO.listarTodos(); 
        }

        private void btn_mostrar_tudo_Click(object sender, EventArgs e)
        {
            dgDevedores.DataSource = DevedoresDAO.listarTodos();
            txtBuscar.Text = "";
            cbxBuscar.Text = "";
            cxbData.Checked = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbxBuscar.Text.ToString();
                string finalSQL = "";
                if (campo == "ID DA VENDA") campo = "tb_venda.id_venda";
                if (campo == "NOME DO CLIENTE") campo = "tb_cliente.nome_cliente";
                if (campo == "SOBRENOME DO CLIENTE") campo = "tb_cliente.sobrenome_cliente";
                if (campo == "CPF DO CLIENTE") campo = "tb_cliente.cpf_cliente";
                if (campo != "") finalSQL += " AND " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                if (cxbData.Checked)
                {
                    finalSQL = finalSQL + " AND tb_venda.data_venda BETWEEN ' " + dtp1.Value.ToString("yyyy/MM/dd") + " 00:00:00' AND ' " + dtp2.Value.ToString("yyyy/MM/dd") + " " + "23:59:59'";
                }
                FiltroModel.campoWhere = finalSQL;

                dgDevedores.DataSource = Filtro.buscaDevedores();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro.Message); }
        }
        private void dgDevedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdVenda.Text = dgDevedores.CurrentRow.Cells[0].Value.ToString();
            txtValorPago.Text = dgDevedores.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnAlterar(object sender, EventArgs e)
        {

            DevedorModel obj = new DevedorModel();
            obj.id_venda = txtIdVenda.Text;
            obj.valor_pago = double.Parse(txtValorPago.Text);

            DevedoresDAO.updateValorPago(obj);

            dgDevedores.DataSource = DevedoresDAO.listarTodos();
            txtIdVenda.Text = "";
            txtValorPago.Text = "";
        }

    }
}
