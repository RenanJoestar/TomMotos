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
            try
            {

                CargoDAO Cadastro = new CargoDAO();
                CargoModel obj = new CargoModel();


                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text;
                if (txt_salario.Text == "") obj.salario = null;
                else obj.salario = txt_salario.Text;

                Cadastro.cadastrarCargo(obj);


                dgCargo.DataSource = Cadastro.ListarTodosCargos();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
            }



        }


        private void Fmrcargo_Load(object sender, EventArgs e)
        {
            CargoDAO Cadastro = new CargoDAO();
            dgCargo.DataSource = Cadastro.ListarTodosCargos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                CargoModel obj = new CargoModel();

                obj.nome = txt_nome.Text;
                obj.salario = txt_salario.Text;
                 obj.id = int.Parse(txt_id.Text);

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
    }
}

