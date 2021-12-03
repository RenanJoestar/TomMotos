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
        VendaDAO Cadastro = new VendaDAO();
        VeiculoDAO Veiculo = new VeiculoDAO();
        ClienteDAO Cliente = new ClienteDAO();
        FiltroDAO Filtro = new FiltroDAO();
        Fmrcaixa fp;
        Fmrveiculo fmrCli;
        //Fmrveiculo fmrCli = new Fmrveiculo();
        public FmrVeiculo_Cliente(Fmrcaixa fpp, Fmrveiculo fc)
        {           
            InitializeComponent();
            fmrCli = fc;
            fp = fpp;
        }

        private void FmrVeiculo_Cliente_Load(object sender, EventArgs e)
        {
            conexao.Open();
            if (CaixaModel.valorPesquisa == "veiculo") {                
                
                cbxBuscar.Items.AddRange(new object[] { "ID","MODELO","MARCA","COR","ANO","KM","PLACA","OBS", "NOME DO CLIENTE"});
                dg_listarVeiculoOuCliente.DataSource = Veiculo.ListarTodosVeiculos(); }
            else
            {
                cbxBuscar.Items.AddRange(new object[] { "ID", "NOME", "SOBRENOME", "CPF", "CNPJ"});
                dg_listarVeiculoOuCliente.DataSource = Cliente.ListarTodosClientes();
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

                if (CaixaModel.fk_veiculo_id != "")
                {
                    fp.lbl_BuscarVeiculo.Text = CaixaModel.fk_veiculo_id.ToString();
                    fp.lbl_buscarCliente.Text = CaixaModel.fk_cliente_id.ToString();
                }
                this.Close();
            }
            else if (CaixaModel.valorPesquisa == "cliente")
            {
                CaixaModel.fk_cliente_id = dg_listarVeiculoOuCliente.CurrentRow.Cells[0].Value.ToString();
                if (CaixaModel.fk_cliente_id != "")
                {
                    fp.lbl_buscarCliente.Text = CaixaModel.fk_cliente_id.ToString();
                }
                this.Close();
            }
            else
            {
                string id_cliente = dg_listarVeiculoOuCliente.CurrentRow.Cells[0].Value.ToString();
                if (id_cliente != "")
                {
                   fmrCli.txt_cliente.Text = id_cliente;
                    fmrCli.lblnomecliente.Text = "CLIENTE " + dg_listarVeiculoOuCliente.CurrentRow.Cells[1].Value.ToString();
                }
                this.Close();  
            }

        }

        private void FmrVeiculo_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbxBuscar.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBuscar.Text != "")
                {
                    if (cbxBuscar.Text != "")
                    {
                        string campo = cbxBuscar.Text.ToString();
                        string finalSQL = "";
                        if (CaixaModel.valorPesquisa == "veiculo") // SE O FORM FOR PARA VEICULO
                        {

                            if (campo == "ID") campo = "tb_veiculo.id_veiculo";
                            if (campo == "MODELO") campo = "tb_veiculo.modelo_veiculo";
                            if (campo == "MARCA") campo = "tb_veiculo.marca_veiculo";
                            if (campo == "COR") campo = "tb_veiculo.cor_veiculo";
                            if (campo == "ANO") campo = "tb_veiculo.ano_veiculo";
                            if (campo == "KM") campo = "tb_veiculo.km_veiculo";
                            if (campo == "PLACA") campo = "tb_veiculo.placa_veiculo";
                            if (campo == "OBS") campo = "tb_veiculo.obs_veiculo";
                            if (campo == "NOME DO CLIENTE") campo = "tb_cliente.nome_cliente";
                            finalSQL += campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";

                            FiltroModel.campoWhere = finalSQL;
                            dg_listarVeiculoOuCliente.DataSource = Filtro.buscaVeiculo();
                        }
                        else // SE O FORM FOR PARA CLIENTE
                        {
                            if (campo == "ID") campo = "tb_cliente.id_cliente";
                            if (campo == "NOME") campo = "tb_cliente.nome_cliente";
                            if (campo == "SOBRENOME") campo = "tb_cliente.sobrenome_cliente";
                            if (campo == "DATA DE NASCIMENTO") campo = "tb_cliente.data_nascimento_cliente";
                            if (campo == "CPF") campo = "tb_cliente.cpf_cliente";
                            if (campo == "CNPJ") campo = "tb_cliente.cnpj_cliente";
                            finalSQL += campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";

                            FiltroModel.campoWhere = finalSQL;

                            dg_listarVeiculoOuCliente.DataSource = Filtro.buscaCliente();
                        }
                    }

                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro.Message); }
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            conexao.Open();
            if (CaixaModel.valorPesquisa == "veiculo")
            {

                cbxBuscar.Items.AddRange(new object[] { "ID", "MODELO", "MARCA", "COR", "ANO", "KM", "PLACA", "OBS" });
                dg_listarVeiculoOuCliente.DataSource = Veiculo.ListarTodosVeiculos();
            }
            else
            {
                cbxBuscar.Items.AddRange(new object[] { "ID", "NOME", "SOBRENOME", "CPF", "CNPJ" });
                dg_listarVeiculoOuCliente.DataSource = Cliente.ListarTodosClientes();
            }
            conexao.Close();
        }
    }
}
