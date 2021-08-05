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

                obj.id = int.Parse(txt_cargo.Text);
                obj.nome = txt_nome.Text;
                obj.sobrenome = txt_sobrenome.Text;
                obj.data_nasc = txt_nascimento.Text;
                obj.cpf = txt_cpf.Text;
                obj.sexo = cbx_sexo.Text;
                obj.cargo_fk = txt_cargo.Text;
                obj.data_contratacao = txt_contratacao.Text;

                FuncionarioDAO Cadastro = new FuncionarioDAO();

                Cadastro.cadastrarFuncionario(obj);
               
                dg_fornecedor.DataSource = Cadastro.ListarTodosFuncionario();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void Fmrfuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO Cadastro = new FuncionarioDAO();
            dg_fornecedor.DataSource = Cadastro.ListarTodosFuncionario();
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
    }
    
}
