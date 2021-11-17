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
        Fmrcaixa lp;
        public FmrListProdutos(Fmrcaixa lpp)
        {
            InitializeComponent();
            lp = lpp;
        }

        private void FmrListProdutos_Load(object sender, EventArgs e)
        {
            conexao.Open();
            ProdutoDAO Listar = new ProdutoDAO();

            Listar.ListarTodosProdutos();
            dgListProdutos.DataSource = Listar.ListarTodosProdutos();

            conexao.Close();

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
                    string campo = cbxBuscar.Text.ToString() + "_produto";
                    FiltroModel.filtro = @"select * from tb_produto where " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                    // MessageBox.Show("Test " + FiltroModel.filtro);
                    FiltroDAO dao = new FiltroDAO();
                    dgListProdutos.DataSource = dao.buscaCargo();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }
    }
}
