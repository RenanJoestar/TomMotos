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
    public partial class Fmrfuncionario : Form
    {
        public Fmrfuncionario()
        {
            InitializeComponent();

        }

     

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioModel obj = new FuncionarioModel();

                obj.id = int.Parse(txt_id.Text);
                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text;
                if (txt_sobrenome.Text == "") obj.sobrenome = null; 
                else obj.sobrenome = txt_sobrenome.Text;
                obj.data_nasc = txt_nascimento.Text;
                obj.cpf = txt_cpf.Text;
                obj.sexo = cbx_sexo.Text;
                obj.cargo_fk = txt_cargo.Text;
                obj.data_contratacao = txt_contratacao.Text;

                FuncionarioDAO Cadastro = new FuncionarioDAO();

                Cadastro.cadastrarFuncionario(obj);
               
                dg_funcionario.DataSource = Cadastro.ListarTodosFuncionario();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void Fmrfuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO Cadastro = new FuncionarioDAO();
            dg_funcionario.DataSource = Cadastro.ListarTodosFuncionario();
            FuncionarioDAO Showcargo = new FuncionarioDAO();
            dgv_cargo.DataSource = Showcargo.ListarTodosCargos();
        } 
          private void dgv_cargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cargo.Text = dgv_cargo.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_cargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioModel obj = new FuncionarioModel();
                obj.id = int.Parse(txt_id.Text);
                
                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text;
                if (txt_sobrenome.Text == "") obj.sobrenome = null;
                else obj.sobrenome = txt_sobrenome.Text;
                obj.data_nasc = txt_nascimento.Text;
                obj.cpf = txt_cpf.Text;
                obj.sexo = cbx_sexo.Text;
                obj.cargo_fk = txt_cargo.Text;
                obj.data_contratacao = txt_contratacao.Text;


                FuncionarioDAO dao = new FuncionarioDAO();
                dao.alterar(obj);
                dg_funcionario.DataSource = dao.ListarTodosFuncionario();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
        }

        private void dg_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_funcionario.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_sobrenome.Text = dg_funcionario.CurrentRow.Cells[2].Value.ToString();
            txt_nascimento.Text = dg_funcionario.CurrentRow.Cells[4].Value.ToString();
            txt_cpf.Text = dg_funcionario.CurrentRow.Cells[3].Value.ToString();
            cbx_sexo.Text = dg_funcionario.CurrentRow.Cells[6].Value.ToString();
            txt_cargo.Text = dg_funcionario.CurrentRow.Cells[7].Value.ToString();
            txt_contratacao.Text = dg_funcionario.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                var result = MessageBox.Show("Deseja excluir o Funcionario " + txt_nome.Text + "?", "EXCLUIR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        FuncionarioModel obj = new FuncionarioModel();
                        obj.id = int.Parse(txt_id.Text);


                        FuncionarioDAO dao = new FuncionarioDAO();
                        dao.Excluir(obj);
                        dg_funcionario.DataSource = dao.ListarTodosFuncionario();
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
    
}
