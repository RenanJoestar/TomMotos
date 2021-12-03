using MySql.Data.MySqlClient;
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
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class FmrListProdutos : Form
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        ProdutoDAO Produto = new ProdutoDAO();
        FiltroDAO Filtro = new FiltroDAO();
        Fmrcaixa lp;
        public FmrListProdutos(Fmrcaixa lpp)
        {
            InitializeComponent();
            lp = lpp;
        }

        private void FmrListProdutos_Load(object sender, EventArgs e)
        {
            dgListProdutos.DataSource = Produto.ListarTodosProdutos();
        }

        private void dgListProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lp.txtIdProduto.Text = dgListProdutos.CurrentRow.Cells[0].Value.ToString();
            lp.txtIdProduto.Focus();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBuscar.Text != "")
                {
                    string campo = cbxBuscar.Text.ToString();
                    string finalSQL = "";
     
                    if (campo == "ID") campo = "tb_produto.id_produto";
                    if (campo == "DESCRICAO") campo = "tb_produto.descricao_produto";
                    if (campo == "VALOR") campo = "tb_produto.valor_produto";
                    if (campo == "QUANTIDADE") campo = "tb_produto.quantidade_produto";
                    if (campo == "MARCA") campo = "tb_produto.marca_produto";
                    finalSQL += campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";

                    FiltroModel.campoWhere = finalSQL;

                    dgListProdutos.DataSource = Filtro.buscaProduto();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            dgListProdutos.DataSource = Produto.ListarTodosProdutos();
        }
    }
}
