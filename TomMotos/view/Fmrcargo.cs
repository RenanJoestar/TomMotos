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
                if (txt_salario.Text == "") obj.salario = null;
                else obj.salario = txt_salario.Text.ToUpper();

                Cadastro.cadastrarCargo(obj);


                dgCargo.DataSource = Cadastro.ListarTodosCargos();
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
            CargoDAO Cadastro = new CargoDAO();
            dgCargo.DataSource = Cadastro.ListarTodosCargos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
            try
            {
                CargoModel obj = new CargoModel();

                obj.nome = txt_nome.Text.ToUpper();
                obj.salario = txt_salario.Text.ToUpper();
                 obj.id = int.Parse(txt_id.Text.ToUpper());

                CargoDAO dao = new CargoDAO();
                dao.alterar(obj);
                dgCargo.DataSource = dao.ListarTodosCargos();
                MessageBox.Show("Alterado com Sucesso!");
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
            txt_salario.Text = dgCargo.CurrentRow.Cells[2].Value.ToString();
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
                string campo = cbxBuscar.Text.ToString() + "_cargo";
                FiltroModel.filtro = @"select * from tb_cargo where " + campo.ToLower() + " like " + "'%" + txtFiltro.Text.ToString() + "%'";
                // MessageBox.Show("Test " + FiltroModel.filtro);
                FiltroDAO dao = new FiltroDAO();
                dgCargo.DataSource = dao.buscaCargo();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

    }
}

