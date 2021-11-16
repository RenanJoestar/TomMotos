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

namespace TomMotos.view
{
    public partial class FmrVenda : Form
    {
        VendaDAO VendaDAO = new VendaDAO();
        public FmrVenda()
        {
            InitializeComponent();
        }

        private void FmrVendacs_Load(object sender, EventArgs e)
        {
            dgVenda.DataSource = VendaDAO.listarTodos(false); //Puxa todas as vendas
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbxBuscar.Text.ToString();
                string finalSQL = "tb_venda.e_orcamento = false";
                if (campo == "ID DO ORÇAMENTO") campo = "tb_venda.id_venda";
                if (campo == "NOME DO CLIENTE") campo = "tb_cliente.nome_cliente";
                if (campo == "CPF DO CLIENTE") campo = "tb_cliente.cpf_cliente";
                if (campo != "") finalSQL += " AND " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                if (cxbData.Checked)
                {
                    finalSQL = finalSQL + " AND tb_venda.data_venda BETWEEN ' " + dtp1.Value.ToString("yyyy/MM/dd") + " 00:00:00' AND ' " + dtp2.Value.ToString("yyyy/MM/dd") + " " + "23:59:59'";
                }
                
                dgVenda.DataSource = VendaDAO.listarVendaPor(finalSQL);
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void btn_mostrar_tudo_Click(object sender, EventArgs e)
        {
            dgVenda.DataSource = VendaDAO.listarTodos(false); //Puxa todas as vendas
            txtBuscar.Text = "";
            cbxBuscar.Text = "";
            cxbData.Checked = false;
        }
    }
}
