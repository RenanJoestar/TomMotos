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
    
    public partial class FmrVeiculo_Cliente : Form
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        Fmrcaixa fp;
        public FmrVeiculo_Cliente(Fmrcaixa f)
        {           
            InitializeComponent();            
            fp = f;             
        }

        private void FmrVeiculo_Cliente_Load(object sender, EventArgs e)
        {
            conexao.Open();
            VendaDAO Cadastro = new VendaDAO();
            if (CaixaModel.valorPesquisa == "veiculo") {
                Cadastro.ListarTodosVeiculo();
                dg_listarVeiculoOuCliente.DataSource = Cadastro.ListarTodosVeiculo(); }
            else {
                Cadastro.ListarTodosCliente();
                dg_listarVeiculoOuCliente.DataSource = Cadastro.ListarTodosCliente();
            }
            conexao.Close();

            }

        private void dg_listarVeiculoOuCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_listarVeiculoOuCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CaixaModel.valorPesquisa == "veiculo")
            {
                CaixaModel.fk_veiculo_id = dg_listarVeiculoOuCliente.CurrentRow.Cells[0].Value.ToString();
                CaixaModel.fk_cliente_id = dg_listarVeiculoOuCliente.CurrentRow.Cells[8].Value.ToString();

                if (CaixaModel.fk_veiculo_id !="")
                {
                    fp.lbl_BuscarVeiculo.Text = CaixaModel.fk_veiculo_id.ToString();
                    fp.lbl_buscarCliente.Text = CaixaModel.fk_cliente_id.ToString();
                }
                this.Close();
            }
            else 
            {
                CaixaModel.fk_cliente_id = dg_listarVeiculoOuCliente.CurrentRow.Cells[0].Value.ToString();
                if (CaixaModel.fk_cliente_id != "")
                {
                    fp.lbl_buscarCliente.Text = CaixaModel.fk_cliente_id.ToString();
                }
                this.Close();
            }

        }

        private void FmrVeiculo_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //vp.lbl_BuscarVeiculo.Text = CaixaModel.fk_veiculo_id;

        }
    }
}
