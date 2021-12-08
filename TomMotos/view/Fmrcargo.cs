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
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrcargo : Form
    {
        FiltroDAO Filtro = new FiltroDAO();
        CargoDAO Cadastro = new CargoDAO();
        public Fmrcargo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
       {
            if (txt_nome.Text != "")
            {
            try
            {
                CargoDAO Cadastro = new CargoDAO();
                CargoModel obj = new CargoModel();

                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text.ToUpper();
                if (txt_salario.Text == "0,00") obj.salario = 0;
                else obj.salario = double.Parse(txt_salario.Text);

                Cadastro.cadastrarCargo(obj);

                dgCargo.DataSource = Cadastro.ListarTodosCargos();
                txt_id.Text = dgCargo.Rows[dgCargo.Rows.Count - 1].Cells[0].Value.ToString();
                }
                catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
             }
            }
            else MessageBox.Show("Preencha os campos obrigatórios =*");
        }

        private void Fmrcargo_Load(object sender, EventArgs e)
        {
            dgCargo.DataSource = Cadastro.ListarTodosCargos();
            txt_salario.Text = "0,00";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
            try
            {
                CargoModel obj = new CargoModel();

                obj.nome = txt_nome.Text.ToUpper();
                obj.salario = double.Parse(txt_salario.Text);
                 obj.id = int.Parse(txt_id.Text.ToUpper());

                CargoDAO dao = new CargoDAO();
                dao.alterar(obj);
                dgCargo.DataSource = dao.ListarTodosCargos();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
            }
            else MessageBox.Show("Escolha um id que deseja Alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgCargo.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dgCargo.CurrentRow.Cells[1].Value.ToString();
            if (txt_id.Text != "") txt_salario.Text = string.Format("{0:#,##0.00}", double.Parse(dgCargo.CurrentRow.Cells[2].Value.ToString()));
            else txt_salario.Text = "0,00";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                var result = MessageBox.Show("Deseja excluir o cargo " + txt_nome.Text + "?", "EXCLUIR",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CargoModel obj = new CargoModel();


                        obj.id = int.Parse(txt_id.Text);

                        CargoDAO dao = new CargoDAO();
                        dao.Excluir(obj);
                        dgCargo.DataSource = dao.ListarTodosCargos();
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Fmrcargo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                if (cbxBuscar.Text != "")
                {
                    string campo = cbxBuscar.Text.ToString();
                    string finalSQL = "";

                    if (campo == "ID DO CARGO") campo = "tb_cargo.id_cargo";
                    if (campo == "NOME DO CARGO") campo = "tb_cargo.nome_cargo";
                    if (campo == "SALARIO DO CARGO") campo = "tb_cargo.salario_cargo";
                    finalSQL += campo.ToLower() + " like " + "'%" + txtFiltro.Text.ToString() + "%'";

                    FiltroModel.campoWhere = finalSQL;

                    dgCargo.DataSource = Filtro.buscaCargo();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void txt_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacaoTxtDAO.FormatarValores(sender,e);
        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            dgCargo.DataSource = Cadastro.ListarTodosCargos();
        }

       
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_salario.Text = "0,00";
        }
    }
}

