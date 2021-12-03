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
        VeiculoDAO Veiculo = new VeiculoDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public Fmrveiculo()
        {
            InitializeComponent();
            
           

        }
        public void validaPlaca()
        {
            Regex Padrao = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");
            Regex Mercosul = new Regex(@"^[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}$");



            if (!Mercosul.IsMatch(txt_placa.Text)&& !Padrao.IsMatch(txt_placa.Text))
                    {
                        
                        txt_placa.ForeColor = Color.Red;
                    
                       
                    }
                    else
                    {
                        
                        txt_placa.ForeColor = Color.Green;
                    }

                
              
           
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

                    
                    obj.modelo = txt_modelo.Text.ToUpper();
                    obj.marca = txt_marca.Text.ToUpper();
                    obj.cor_veiculo = txt_cor.Text.ToUpper();
                    obj.ano_veiculo = txt_ano.Text;
                    obj.km_veiculo = txt_km.Text;
                    if (txt_placa.Text == "") obj.placa_veiculo = null;
                    else obj.placa_veiculo = txt_placa.Text.ToUpper();
                    obj.obs_veiculo = txt_obs.Text.ToUpper();
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
            dg_veiculo.DataSource = Veiculo.ListarTodosVeiculos();

            dgv_cliente.DataSource = Veiculo.ListarTodosClientes();
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    VeiculoModel obj = new VeiculoModel();
                    obj.id = int.Parse(txt_id.Text);
                    obj.modelo = txt_modelo.Text.ToUpper();
                    obj.marca = txt_marca.Text.ToUpper();
                    obj.cor_veiculo = txt_cor.Text.ToUpper();
                    obj.ano_veiculo = txt_ano.Text;
                    obj.km_veiculo = txt_km.Text;
                    if (txt_placa.Text == "") obj.placa_veiculo = null;
                    else obj.placa_veiculo = txt_placa.Text.ToUpper();
                    obj.obs_veiculo = txt_obs.Text.ToUpper();
                    obj.cliente_fk = txt_cliente.Text;

                    VeiculoDAO dao = new VeiculoDAO();
                    dao.alterar(obj);
                    dg_veiculo.DataSource = dao.ListarTodosVeiculos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu algum erro" + erro.Message);
                }
            }
            else MessageBox.Show("Erro","Escolha um id que deseja Alterar",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }


        private void txt_placa_Leave(object sender, EventArgs e)
        {
            if (txt_placa.Text != "")
            {
                validaPlaca();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {

                var result = MessageBox.Show("Deseja excluir o Veiculo" + txt_modelo.Text + "?", "EXCLUIR",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        VeiculoModel obj = new VeiculoModel();
                        obj.id = int.Parse(txt_id.Text);


                        VeiculoDAO dao = new VeiculoDAO();
                        dao.Excluir(obj);
                        dg_veiculo.DataSource = dao.ListarTodosVeiculos();
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void Fmrveiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBuscar.Text != "")
                {
                    string campo = cbxBuscar.Text.ToString();
                    string finalSQL = "";

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

                    dg_veiculo.DataSource = Filtro.buscaVeiculo();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro.Message); }
        }

        private void txt_ano_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txt_km_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void dg_veiculo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_veiculo.CurrentRow.Cells[0].Value.ToString();
            txt_modelo.Text = dg_veiculo.CurrentRow.Cells[2].Value.ToString();
            txt_marca.Text = dg_veiculo.CurrentRow.Cells[1].Value.ToString();
            txt_cor.Text = dg_veiculo.CurrentRow.Cells[3].Value.ToString();
            txt_ano.Text = dg_veiculo.CurrentRow.Cells[4].Value.ToString();
            txt_km.Text = dg_veiculo.CurrentRow.Cells[5].Value.ToString();
            txt_obs.Text = dg_veiculo.CurrentRow.Cells[7].Value.ToString();
            txt_placa.Text = dg_veiculo.CurrentRow.Cells[6].Value.ToString();
            txt_cliente.Text = dg_veiculo.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            dg_veiculo.DataSource = Veiculo.ListarTodosVeiculos();
        }
    }
}
