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
    public partial class Fmrfornecedor : Form
    {
        public Fmrfornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorModel obj = new FornecedorModel();

                obj.nome = txt_nome.Text;
                if (txt_cnpj.Text == "") obj.cnpj = null;
                else obj.cnpj = txt_cnpj.Text;

                FornecedorDAO Cadastro = new FornecedorDAO();

                Cadastro.cadastrarFornecedor(obj);

                
                dg_fornecedor.DataSource = Cadastro.ListarTodosFornecedores();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }


        private void Fmrfornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO Cadastro = new FornecedorDAO();
           
            dg_fornecedor.DataSource = Cadastro.ListarTodosFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorModel obj = new FornecedorModel();
                obj.id = int.Parse(txt_id.Text);
                obj.nome = txt_nome.Text;
                if (txt_cnpj.Text == "") obj.cnpj = null;
                else obj.cnpj = txt_cnpj.Text;

                FornecedorDAO dao = new FornecedorDAO();
                dao.alterar(obj);
                dg_fornecedor.DataSource = dao.ListarTodosFornecedores();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
        }

        private void dg_fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_fornecedor.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_fornecedor.CurrentRow.Cells[1].Value.ToString();
            txt_cnpj.Text = dg_fornecedor.CurrentRow.Cells[2].Value.ToString();
        }

        private void dg_fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
