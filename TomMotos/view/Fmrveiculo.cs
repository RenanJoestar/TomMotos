using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrveiculo : Form
    {
        public Fmrveiculo()
        {
            InitializeComponent();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txt_marca.Text == "" || txt_modelo.Text == "" || txt_cliente.Text == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");

            }


            else
            {
                try
                {
                    VeiculoModel obj = new VeiculoModel();

                    obj.id = int.Parse(txt_cliente.Text);
                    obj.modelo = txt_modelo.Text;
                    obj.marca = txt_marca.Text;
                    obj.cor_veiculo = txt_cor.Text;
                    obj.ano_veiculo = txt_ano.Text;
                    obj.km_veiculo = txt_km.Text;
                    if (txt_placa.Text == "") obj.placa_veiculo = null;
                    else obj.placa_veiculo = txt_placa.Text;
                    obj.obs_veiculo = txt_obs.Text;
                    obj.cliente_fk = txt_cliente.Text;


                    VeiculoDAO Cadastro = new VeiculoDAO();

                    Cadastro.cadastrar(obj);


                    dg_veiculo.DataSource = Cadastro.ListarTodosVeiculos();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Erro: " + erro);
                }
            }
                                   
        }
       
        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cliente.Text = dgv_cliente.CurrentRow.Cells[0].Value.ToString();
        }

        private void Fmrveiculo_Load(object sender, EventArgs e)
        {
            VeiculoDAO Cadastro = new VeiculoDAO();                       
            dg_veiculo.DataSource = Cadastro.ListarTodosVeiculos();

            VeiculoDAO Cliente = new VeiculoDAO();
            dgv_cliente.DataSource = Cliente.ListarTodosClientes();
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                VeiculoModel obj = new VeiculoModel();
                obj.id = int.Parse(txt_cliente.Text);
                obj.modelo = txt_modelo.Text;
                obj.marca = txt_marca.Text;
                obj.cor_veiculo = txt_cor.Text;
                obj.ano_veiculo = txt_ano.Text;
                obj.km_veiculo = txt_km.Text;
                if (txt_placa.Text == "") obj.placa_veiculo = null;
                else obj.placa_veiculo = txt_placa.Text;
                obj.obs_veiculo = txt_obs.Text;
                obj.cliente_fk = txt_cliente.Text;

                VeiculoDAO dao = new VeiculoDAO();
                dao.alterar(obj);
                dg_veiculo.DataSource = dao.ListarTodosClientes();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }

        }

        private void dg_veiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_veiculo.CurrentRow.Cells[0].Value.ToString();
            txt_modelo.Text = dg_veiculo.CurrentRow.Cells[3].Value.ToString();
            txt_marca.Text = dg_veiculo.CurrentRow.Cells[2].Value.ToString();
            txt_cor.Text = dg_veiculo.CurrentRow.Cells[4].Value.ToString();
            txt_ano.Text = dg_veiculo.CurrentRow.Cells[5].Value.ToString();
            txt_km.Text = dg_veiculo.CurrentRow.Cells[6].Value.ToString();
            txt_obs.Text = dg_veiculo.CurrentRow.Cells[8].Value.ToString();
            txt_placa.Text = dg_veiculo.CurrentRow.Cells[7].Value.ToString();
            txt_cliente.Text = dg_veiculo.CurrentRow.Cells[9].Value.ToString();

            
        }
    }
}
