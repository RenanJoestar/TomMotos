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
                obj.cnpj = txt_cnpj.Text;

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
    }
}
